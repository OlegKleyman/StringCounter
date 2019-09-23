using System;
using ConsoleTables;
using Counter.Core;

namespace Counter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new ArgumentException("No input provided", nameof(args));
            }

            var counter = new LetterCounter();

            var result = counter.Count(args[0]);

            var consoleTable = new ConsoleTable();
            consoleTable.Options.EnableCount = false;
            var resultWriter = new ResultWriter(consoleTable);

            resultWriter.Write(result);

            Console.WriteLine(
                $"The text has been processed.{Environment.NewLine}Total letters counted: {args[0].Length}");
        }
    }
}
