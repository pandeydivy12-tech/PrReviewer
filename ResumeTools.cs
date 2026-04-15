using ModelContextProtocol.Server;
using System.ComponentModel;

namespace RelinkMCP;

[McpServerToolType]

public static class ResumeTools
{
    [McpServerTool, Description("Store Software Engineer's resume profile parameters in database")]
    public static void StoreResumeProfile(
        [Description("The amount of impact person had in previous company on scale (0-10)")]
         double Impact,
        [Description("DSA skills a person has in range(0-10) based on profile in dsa practise or competetive programming")]
         double DsaSkills,
        [Description("Real life System Design implimentation skills in range (0-10)")]
         double SystemDesign,

        [Description("General Bio of an engineer on scale (0-10)")]
         double GeneralBio


    )
    {
        InputOutput.Log($"Impact: {Impact}");
        InputOutput.Log($"DSA Skills : {DsaSkills}");
        InputOutput.Log($"System Design Skills : {SystemDesign}");
        InputOutput.Log($"General Bio : {GeneralBio}");
    }
}
