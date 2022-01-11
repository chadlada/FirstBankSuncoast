using System;

namespace FirstBankSuncoast
{
    class Program
    {

        static void DisplayGreeting()
        {
            Console.WriteLine(" #####                                                     ######                       ");
            Console.WriteLine("#     # #    # #    #  ####   ####    ##    ####  #####    #     #   ##   #    # #    # ");
            Console.WriteLine("#       #    # ##   # #    # #    #  #  #  #        #      #     #  #  #  ##   # #   #  ");
            Console.WriteLine(" #####  #    # # #  # #      #    # #    #  ####    #      ######  #    # # #  # ####   ");
            Console.WriteLine("      # #    # #  # # #      #    # ######      #   #      #     # ###### #  # # #  #   ");
            Console.WriteLine("#     # #    # #   ## #    # #    # #    # #    #   #      #     # #    # #   ## #   #  ");
            Console.WriteLine(" #####   ####  #    #  ####   ####  #    #  ####    #      ######  #    # #    # #    # ");
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, not good input. Gonna go with 0");
                return 0;
            }
        }



        static void Main(string[] args)
        {
            DisplayGreeting();
            Console.WriteLine("Welcome to C#");

        }
    }
}
