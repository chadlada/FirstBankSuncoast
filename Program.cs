using System;
using System.Collections.Generic;

namespace FirstBankSuncoast
{
    class Transaction
    {
        public string Type { get; set; }
        public string Account { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }


    }


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

        static void DisplayMenu()
        {
            Console.WriteLine("\n\nPlease choose from the following options:");
            Console.WriteLine("[D]eposit\n[W]ithdraw\n[V]iew transaction history\n[B]alance Statement\n[Q]uit\n");
        }




        static void Main(string[] args)
        {
            DisplayGreeting();


            var transactions = new List<Transaction>();

            var keepGoing = true;

            while (keepGoing)
            {
                DisplayMenu();
                var choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "D":
                        Console.WriteLine("\nWhere would you like to deposit to?: [C]hecking or [S]avings\n");
                        var depositAccountChoice = Console.ReadLine().ToUpper();

                        if (depositAccountChoice == "C")
                        {
                            var checkingDeposit = new Transaction();

                            checkingDeposit.Type = "Desposit";
                            checkingDeposit.Account = "Checking";
                            checkingDeposit.Amount = PromptForInteger("Deposit Amount: $");
                            checkingDeposit.Date = DateTime.Now;

                            Console.WriteLine($"\n${checkingDeposit.Amount} desposited to your checking account. \n");

                            transactions.Add(checkingDeposit);
                        }

                        else if (depositAccountChoice == "S")
                        {
                            var savingsDeposit = new Transaction();

                            savingsDeposit.Type = "Desposit";
                            savingsDeposit.Account = "Checking";
                            savingsDeposit.Amount = PromptForInteger("Deposit Amount: $");
                            savingsDeposit.Date = DateTime.Now;

                            Console.WriteLine($"\n${savingsDeposit.Amount} desposited to your savings account. \n");

                            transactions.Add(savingsDeposit);
                        }
                        else
                        {
                            Console.WriteLine("\n Not valid input. Try Again!");
                        }
                        break;


                }

            }
        }
    }
}
