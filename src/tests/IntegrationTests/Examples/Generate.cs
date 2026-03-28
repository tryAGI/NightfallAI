/*
order: 10
title: Scanning Text
slug: scanning

Example showing how to scan text for sensitive data using the Nightfall AI API.
*/

namespace NightfallAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ScanText()
    {
        using var client = GetAuthenticatedClient();

        //// Create a scan request with inline detection rules
        var request = new ScanTextRequest
        {
            Payload = ["My email is test@example.com and my SSN is 123-45-6789"],
            Policy = new ScanPolicy
            {
                DetectionRules =
                [
                    new DetectionRule
                    {
                        Detectors =
                        [
                            new Detector
                            {
                                DetectorType = DetectorType.NightfallDetector,
                                NightfallDetector = "EMAIL_ADDRESS",
                                MinConfidence = Confidence.Possible,
                            },
                            new Detector
                            {
                                DetectorType = DetectorType.NightfallDetector,
                                NightfallDetector = "US_SOCIAL_SECURITY_NUMBER",
                                MinConfidence = Confidence.Possible,
                            },
                        ],
                        LogicalOp = LogicalOp.Any,
                    },
                ],
            },
        };

        //// Send the scan request
        var response = await client.Scanning.ScanTextAsync(
            request: request);

        response.Should().NotBeNull();
        response.Findings.Should().NotBeNull();
    }
}
