using System;

namespace MOES_Digitize_Schools
{
    public static class Helper
    {
        public static int getIsValidNumber(string prompt)
        {
            int number;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number");
                }
            }
        }

        public static string provideExitOption(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            if (input == "00")
            {
                throw new OperationCanceledException(); // Signal to go back to the main menu
            }

            return input;
        }
    }
}