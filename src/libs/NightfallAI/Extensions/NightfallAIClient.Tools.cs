using Microsoft.Extensions.AI;

namespace NightfallAI;

/// <summary>
/// Extensions for using NightfallAIClient as MEAI tools with any IChatClient.
/// </summary>
public static class NightfallAIToolExtensions
{
    private static readonly string[] CommonPiiDetectors =
    [
        "CREDIT_CARD_NUMBER",
        "US_SOCIAL_SECURITY_NUMBER",
        "API_KEY",
        "EMAIL_ADDRESS",
        "PHONE_NUMBER",
        "IP_ADDRESS",
    ];

    private static readonly string[] CommonFileDetectors =
    [
        "CREDIT_CARD_NUMBER",
        "US_SOCIAL_SECURITY_NUMBER",
        "API_KEY",
        "EMAIL_ADDRESS",
    ];

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that scans text for sensitive data
    /// (PII, PHI, PCI, secrets, credentials) using the Nightfall AI API.
    /// Suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Nightfall AI client to use for scanning.</param>
    /// <param name="detectorName">
    /// The built-in Nightfall detector to use (e.g., CREDIT_CARD_NUMBER,
    /// US_SOCIAL_SECURITY_NUMBER, API_KEY, EMAIL_ADDRESS, PHONE_NUMBER,
    /// IP_ADDRESS, PERSON_NAME). Defaults to scanning for all common PII types
    /// if not specified.
    /// </param>
    /// <param name="minConfidence">
    /// Minimum confidence level for findings. Defaults to Possible.
    /// </param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsScanTextTool(
        this NightfallAIClient client,
        string? detectorName = null,
        Confidence minConfidence = Confidence.Possible)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, CancellationToken cancellationToken) =>
            {
                var detectors = BuildDetectors(detectorName, CommonPiiDetectors, minConfidence);

                var request = new ScanTextRequest
                {
                    Payload = [text],
                    Policy = new ScanPolicy
                    {
                        DetectionRules =
                        [
                            new DetectionRule
                            {
                                Detectors = detectors,
                                LogicalOp = LogicalOp.Any,
                            },
                        ],
                    },
                };

                var response = await client.Scanning.ScanTextAsync(
                    request: request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatScanResponse(response);
            },
            name: "NightfallScanText",
            description: "Scans text for sensitive data such as PII (personally identifiable information), PHI (protected health information), PCI (payment card data), API keys, secrets, and credentials using Nightfall AI. Returns detected findings with their type, confidence, and location.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that initializes a file upload session
    /// for asynchronous file scanning with Nightfall AI.
    /// Suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Nightfall AI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsInitFileUploadTool(
        this NightfallAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (long fileSizeBytes, CancellationToken cancellationToken) =>
            {
                var response = await client.FileScanning.InitFileUploadAsync(
                    request: new InitFileUploadRequest
                    {
                        FileSizeBytes = fileSizeBytes,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Upload session created. ID: {response.Id}, Chunk Size: {response.ChunkSize} bytes, MIME Type: {response.MimeType}";
            },
            name: "NightfallInitFileUpload",
            description: "Initializes a file upload session with Nightfall AI for asynchronous file scanning. Returns the upload session ID and chunk size for uploading file data.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that triggers a scan of a previously
    /// uploaded file using Nightfall AI.
    /// Suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Nightfall AI client to use.</param>
    /// <param name="detectorName">
    /// The built-in Nightfall detector to use. Defaults to scanning for common PII types.
    /// </param>
    /// <param name="minConfidence">
    /// Minimum confidence level for findings. Defaults to Possible.
    /// </param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsScanUploadedFileTool(
        this NightfallAIClient client,
        string? detectorName = null,
        Confidence minConfidence = Confidence.Possible)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (Guid fileId, CancellationToken cancellationToken) =>
            {
                var detectors = BuildDetectors(detectorName, CommonFileDetectors, minConfidence);

                var request = new ScanFileRequest
                {
                    Policy = new FileScanPolicy
                    {
                        DetectionRules =
                        [
                            new DetectionRule
                            {
                                Detectors = detectors,
                                LogicalOp = LogicalOp.Any,
                            },
                        ],
                    },
                };

                var response = await client.FileScanning.ScanUploadedFileAsync(
                    fileId: fileId,
                    request: request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"File scan initiated. Scan ID: {response.Id}. Message: {response.Message}. Results will be delivered via configured webhook/alert.";
            },
            name: "NightfallScanUploadedFile",
            description: "Triggers an asynchronous scan of a previously uploaded file for sensitive data (PII, PHI, PCI, secrets) using Nightfall AI. Returns a scan ID for tracking. Results are delivered asynchronously via webhook.");
    }

    private static List<Detector> BuildDetectors(
        string? detectorName,
        string[] defaultDetectors,
        Confidence minConfidence)
    {
        var detectors = new List<Detector>();

        if (!string.IsNullOrEmpty(detectorName))
        {
            detectors.Add(new Detector
            {
                DetectorType = DetectorType.NightfallDetector,
                NightfallDetector = detectorName,
                MinConfidence = minConfidence,
            });
        }
        else
        {
            foreach (var name in defaultDetectors)
            {
                detectors.Add(new Detector
                {
                    DetectorType = DetectorType.NightfallDetector,
                    NightfallDetector = name,
                    MinConfidence = minConfidence,
                });
            }
        }

        return detectors;
    }

    private static string FormatScanResponse(ScanTextResponse response)
    {
        var parts = new List<string>();

        if (response.Findings is { Count: > 0 })
        {
            var totalFindings = 0;
            for (var i = 0; i < response.Findings.Count; i++)
            {
                var payloadFindings = response.Findings[i];
                if (payloadFindings is not { Count: > 0 })
                {
                    continue;
                }

                totalFindings += payloadFindings.Count;
                parts.Add($"Payload [{i}] findings:");
                foreach (var finding in payloadFindings)
                {
                    var detector = finding.Detector?.Name ?? "Unknown";
                    var confidence = finding.Confidence?.ToValueString() ?? "Unknown";
                    var entry = $"  - {detector} (confidence: {confidence})";

                    if (!string.IsNullOrWhiteSpace(finding.RedactedFinding))
                    {
                        entry += $": {finding.RedactedFinding}";
                    }
                    else if (!string.IsNullOrWhiteSpace(finding.Finding1))
                    {
                        // Show partial finding for context
                        var display = finding.Finding1.Length > 20
                            ? finding.Finding1[..10] + "..." + finding.Finding1[^4..]
                            : finding.Finding1;
                        entry += $": {display}";
                    }

                    if (finding.Location?.ByteRange is { } range)
                    {
                        entry += $" [bytes {range.Start}-{range.End}]";
                    }

                    parts.Add(entry);
                }
            }

            parts.Insert(0, $"Found {totalFindings} sensitive data finding(s):");
        }
        else
        {
            parts.Add("No sensitive data findings detected.");
        }

        if (response.RedactedPayload is { Count: > 0 })
        {
            parts.Add("\nRedacted payload:");
            for (var i = 0; i < response.RedactedPayload.Count; i++)
            {
                parts.Add($"  [{i}]: {response.RedactedPayload[i]}");
            }
        }

        return string.Join("\n", parts);
    }
}
