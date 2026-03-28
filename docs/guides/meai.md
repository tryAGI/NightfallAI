# Microsoft.Extensions.AI Integration

NightfallAI provides `AIFunction` tool wrappers compatible with any `Microsoft.Extensions.AI.IChatClient`. These tools enable AI agents to scan text and files for sensitive data.

## Available Tools

### AsScanTextTool

Scans text for sensitive data including PII, PHI, PCI, API keys, secrets, and credentials.

```csharp
using NightfallAI;

var client = new NightfallAIClient(apiKey);

// Scan for all common PII types
var scanTool = client.AsScanTextTool();

// Or scan for a specific detector
var creditCardTool = client.AsScanTextTool(
    detectorName: "CREDIT_CARD_NUMBER",
    minConfidence: Confidence.Likely);
```

### AsInitFileUploadTool

Initializes a file upload session for asynchronous file scanning.

```csharp
var uploadTool = client.AsInitFileUploadTool();
```

### AsScanUploadedFileTool

Triggers an asynchronous scan of a previously uploaded file.

```csharp
var fileScanTool = client.AsScanUploadedFileTool();
```

## Using with IChatClient

```csharp
using Microsoft.Extensions.AI;
using NightfallAI;

var nightfall = new NightfallAIClient(apiKey);
var scanTool = nightfall.AsScanTextTool();

// Use with any IChatClient
var options = new ChatOptions
{
    Tools = [scanTool],
};
```

## Built-in Detectors

Nightfall AI provides the following built-in detectors:

| Detector | Description |
|----------|-------------|
| `CREDIT_CARD_NUMBER` | Credit/debit card numbers |
| `US_SOCIAL_SECURITY_NUMBER` | US Social Security Numbers |
| `API_KEY` | API keys and tokens |
| `CRYPTOGRAPHIC_KEY` | Cryptographic/private keys |
| `EMAIL_ADDRESS` | Email addresses |
| `PHONE_NUMBER` | Phone numbers |
| `IP_ADDRESS` | IP addresses |
| `IBAN_CODE` | International bank account numbers |
| `PASSPORT_NUMBER` | Passport numbers |
| `DRIVER_LICENSE_NUMBER` | Driver's license numbers |
| `DATE_OF_BIRTH` | Dates of birth |
| `PERSON_NAME` | Person names |
| `STREET_ADDRESS` | Street/mailing addresses |
| `FINANCIAL_ACCOUNT_NUMBER` | Financial account numbers |
