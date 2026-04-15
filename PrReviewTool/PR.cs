using System.ComponentModel;
using ModelContextProtocol.Server;

public static class PrTools
{
    [McpServerTool,Description("Retrieves the changes of PR request for git")]
    public static void RetrivePrChanges(
        [Description("The main branch where the git PR has to be merged into")]
        string DestinationBranch,
        [Description("The branch from which some fatures to merge into main branch of git")]
        string FeatureToBeMergedBranch)
    {
        
    } 
}