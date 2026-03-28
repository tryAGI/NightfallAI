/* order: 20, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace NightfallAI.IntegrationTests;

public partial class Tests
{
    //// NightfallAI provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// data security scanning capabilities.

    [TestMethod]
    public async Task Meai_AsScanTextTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that scans text for sensitive data:
        var tool = client.AsScanTextTool();

        tool.Name.Should().Be("NightfallScanText");
        tool.Description.Should().Contain("PII");
    }

    [TestMethod]
    public async Task Meai_AsInitFileUploadTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that initializes file upload sessions:
        var tool = client.AsInitFileUploadTool();

        tool.Name.Should().Be("NightfallInitFileUpload");
        tool.Description.Should().Contain("file upload");
    }

    [TestMethod]
    public async Task Meai_AsScanUploadedFileTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that triggers file scans:
        var tool = client.AsScanUploadedFileTool();

        tool.Name.Should().Be("NightfallScanUploadedFile");
        tool.Description.Should().Contain("sensitive data");
    }
}
