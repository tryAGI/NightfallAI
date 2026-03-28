# CLAUDE.md -- NightfallAI SDK

## Overview

Auto-generated C# SDK for [Nightfall AI](https://nightfall.ai/) -- data security and DLP platform for detecting PII, PHI, PCI, secrets, and credentials in text and files.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from the [Nightfall Go SDK](https://github.com/nightfallai/nightfall-go-sdk) and API documentation.

## Build & Test

```bash
dotnet build NightfallAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new NightfallAIClient(apiKey); // NIGHTFALL_API_KEY env var
```

## Key Files

- `src/libs/NightfallAI/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Nightfall)
- `src/libs/NightfallAI/generate.sh` -- Runs autosdk generate (no download step, uses local spec)
- `src/libs/NightfallAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/NightfallAI/Extensions/NightfallAIClient.Tools.cs` -- MEAI AIFunction tools (AsScanTextTool, AsInitFileUploadTool, AsScanUploadedFileTool)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/v3/scan` | POST | Scan text payloads for sensitive data |
| `/v3/upload` | POST | Initialize file upload session |
| `/v3/upload/{fileId}` | PATCH | Upload file chunk |
| `/v3/upload/{fileId}/finish` | POST | Complete file upload |
| `/v3/upload/{fileId}/scan` | POST | Scan uploaded file |

## MEAI Tools

| Tool | Method | Description |
|------|--------|-------------|
| `AsScanTextTool()` | Extension | Scan text for PII/PHI/PCI/secrets |
| `AsInitFileUploadTool()` | Extension | Initialize file upload session |
| `AsScanUploadedFileTool()` | Extension | Trigger scan of uploaded file |

## API Concepts

- **Detectors**: Built-in (NIGHTFALL_DETECTOR) or custom (REGEX, WORD_LIST) rules for identifying sensitive data
- **Detection Rules**: Groups of detectors combined with logical operators (ANY/ALL)
- **Confidence Levels**: VERY_UNLIKELY, UNLIKELY, POSSIBLE, LIKELY, VERY_LIKELY
- **Redaction**: Masking, substitution, info-type replacement, or encryption
- **File Scanning**: Async process -- init upload, send chunks, complete, trigger scan, receive results via webhook
