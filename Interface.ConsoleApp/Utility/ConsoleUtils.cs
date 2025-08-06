namespace FoothillOOPTask.Utility;

public class ConsoleUtils
{
    public static String ReadConsole(String prompt, String? def)
    {
        Console.Write(prompt);
        String line = Console.ReadLine() ?? "";

        if (def == null)
        {
            return line == "" ? ReadConsole(prompt, def) : line;
        }
        else
        {
            return line == "" ? def : line;
        }
    }
    
    public static int ReadInteger(String prompt, int? def, bool isPositive)
    {
        String input = ReadConsole(prompt, def?.ToString());
        int result;
        while (!int.TryParse(input, out result) || (result != def && isPositive && result < 0))
        {
            input = ReadConsole(prompt, def?.ToString());
        }

        return result;
    }

    public static decimal ReadDecimal(String prompt, decimal? def, bool isPositive)
    {
        String input = ReadConsole(prompt, def?.ToString());
        decimal result;
        while (!decimal.TryParse(input, out result) || (result != def && isPositive && result < 0))
        {
            input = ReadConsole(prompt, def?.ToString());
        }

        return result;
    }
}