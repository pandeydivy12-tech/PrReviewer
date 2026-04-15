namespace RelinkMCP;

public static class InputOutput
{
    static readonly string debugPath = "C:/Users/pande/OneDrive/Desktop/Debugger_Bamroc.txt";
    public static void Log(string message)
    {
        if(!File.Exists(debugPath))
        {
            File.Create(debugPath).Close();
        }

        using (var writer = File.AppendText(debugPath))
        {
            writer.WriteLine(message);
        }
    }
    public static void Clear()
    {
        File.WriteAllText(debugPath,string.Empty);
    }
}