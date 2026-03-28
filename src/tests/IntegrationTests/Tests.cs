namespace NightfallAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static NightfallAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("NIGHTFALL_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("NIGHTFALLAI_API_KEY") is { Length: > 0 } altKeyValue ? altKeyValue :
            throw new AssertInconclusiveException("NIGHTFALL_API_KEY environment variable is not found.");

        var client = new NightfallAIClient(apiKey);

        return client;
    }
}
