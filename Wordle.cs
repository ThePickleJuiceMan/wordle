using System.IO;
using System;

namespace Wordle;

public class WorldleRun
{
    public static void Main(string[] args)
    {
        int wordle_number = int.Parse(args[0]);
        WordleLib wordle = new();

        Console.WriteLine($"WORDLE {wordle_number} is: {wordle.GetWordleByNumber(wordle_number)}");
    }
}