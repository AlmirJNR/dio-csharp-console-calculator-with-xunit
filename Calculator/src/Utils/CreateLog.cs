namespace Calculator.Utils;

static class LogMaker
{
    public static void CreateLog(string[] originalArgs, string[] modifiedArgs, double? calcResult)
    {
        var logsDirectory = Path.Combine(Environment.CurrentDirectory, "Calculator", "Logs");
        Directory.CreateDirectory(logsDirectory);

        var logsFilePath = Path.Combine(logsDirectory, "Logs.log");

        using var file = File.AppendText(logsFilePath);
        file.WriteLine($"[Date]: {DateTime.UtcNow}");
        file.WriteLine($"[Arguments]: {originalArgs[0]} {originalArgs[1]} {originalArgs[2]}");
        file.WriteLine($"[SanitizedExpression]: {modifiedArgs[0]} {modifiedArgs[1]} {modifiedArgs[2]}");
        file.WriteLine($"[Result]: {calcResult}\n");
    }
}
