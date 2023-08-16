using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(String[] args)
        {
            // app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Bo Bonning";
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // Reset text color
            Console.ResetColor();

        }
    }
}