using System;

class Program
{
    static void  Main()
    {
        string parseResultSummary;
        string stringFirst = "28";

        bool success = int.TryParse(stringFirst, out int First);

        parseResultSummary = success ? "was successfully parsed" : "was not successfully parsed";

        Console.WriteLine($"String {stringFirst} {parseResultSummary}");


    }
}
