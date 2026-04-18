using System.ComponentModel;
using ModelContextProtocol.Server;
using RelinkMCP;
using RelinkMCP.models;
using RelinkMCP.scripts;

namespace RelinkMCP.PrReviewTool;

[McpServerToolType]
public static class PrTools
{

    [McpServerTool, Description("Retrieves the changes of PR request for git")]
    public static PRDiff RetrivePrChanges(
        [Description("The main branch where the git PR has to be merged into")]
        string DestinationBranch,
        [Description("The branch from which some fatures to merge into main branch of git")]
        string FeatureToBeMergedBranch)
    {
        try
        {
            InputOutput.Log("PR reviewer getting used");
            if (!ScriptRunner.IsGithubCliInstalled())
            {
                InputOutput.Log("Not detected");
                var pd = new PRDiff().SetTransactionStatus("github cli not detected on machine", false);
                return pd;
            }
            InputOutput.Log("Detected");
            return new PRDiff().SetTransactionStatus("success", true);
        }
        catch (System.Exception ex)
        {
            return new PRDiff().SetTransactionStatus(ex.Message, false);
        }
    }
}