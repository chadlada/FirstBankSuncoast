using System;
using System.Collections.Generic;
using System.Linq;

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


            // TEST DATA
            var testTransaction = new Transaction()
            {
                Date = DateTime.Now,
                Amount = 10,
                Account = "Checking",
                Type = "Deposit"
            };
            transactions.Add(testTransaction);
            var testTransaction1 = new Transaction()
            {
                Date = DateTime.Now,
                Amount = 10,
                Account = "Savings",
                Type = "Deposit"
            };
            transactions.Add(testTransaction1);
            var testTransaction2 = new Transaction()
            {
                Date = DateTime.Now,
                Amount = 5,
                Account = "Checking",
                Type = "Withdraw"
            };
            transactions.Add(testTransaction2);




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
                    case "W":
                        Console.WriteLine("\nWhere would you like to withdraw from?: [C]hecking or [S]avings\n");
                        var withdrawAccountChoice = Console.ReadLine().ToUpper();

                        if (withdrawAccountChoice == "C")
                        {
                            var checkingWithdraw = new Transaction();

                            checkingWithdraw.Type = "Withdraw";
                            checkingWithdraw.Account = "Checking";
                            checkingWithdraw.Amount = PromptForInteger("Withdraw Amount: $");
                            checkingWithdraw.Date = DateTime.Now;

                            Console.WriteLine($"\n${checkingWithdraw.Amount} Withdrawn from your checking account. \n");

                            transactions.Add(checkingWithdraw);
                        }
                        else if (withdrawAccountChoice == "S")
                        {
                            var savingsWithdraw = new Transaction();

                            savingsWithdraw.Type = "Withdraw";
                            savingsWithdraw.Account = "Savings";
                            savingsWithdraw.Amount = PromptForInteger("Withdraw Amount: $");
                            savingsWithdraw.Date = DateTime.Now;

                            Console.WriteLine($"\n${savingsWithdraw.Amount} Withdrawn from your savings account. \n");

                            transactions.Add(savingsWithdraw);
                        }
                        else
                        {
                            Console.WriteLine("\n Not valid input. Try Again!");
                        }
                        break;


                    case "V":
                        // VIEW TRANSACTION HISTORY
                        Console.WriteLine("\nTRANSACTION HISTORY:\n");

                        foreach (var transaction in transactions)
                        {
                            if (transaction.Type == "Deposit")
                            {
                                Console.WriteLine($"{transaction.Date: M/dd/yyyy} {transaction.Type} to {transaction.Account}: ${transaction.Amount}\n ");
                            }
                            else if (transaction.Type == "Withdraw")
                            {
                                Console.WriteLine($"{transaction.Date: M/dd/yyyy} {transaction.Type} from {transaction.Account}: ${transaction.Amount}\n ");
                            }
                        }
                        break;




                    case "B":
                        // BALANCE STATEMENT
                        var totalCheckingDeposits = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Deposit")
                   .Sum(transaction => transaction.Amount);
                        var totalCheckingWithdraws = transactions.Where(transaction => transaction.Account == "Checking" && transaction.Type == "Withdraw")
                        .Sum(transaction => transaction.Amount);
                        var totalChecking = totalCheckingDeposits - totalCheckingWithdraws;

                        var totalSavingsDeposits = transactions.Where(transaction => transaction.Account == "Savings" && transaction.Type == "Deposit")
                   .Sum(transaction => transaction.Amount);
                        var totalSavingsWithdraw = transactions.Where(transaction => transaction.Account == "Savings" && transaction.Type == "Withdraw")
                        .Sum(transaction => transaction.Amount);
                        var totalSavings = totalSavingsDeposits - totalSavingsWithdraw;



                        Console.WriteLine("\nACCOUNT BALANCES: \n");
                        Console.WriteLine($"Checking: ${totalChecking}");
                        Console.WriteLine($"Savings: ${totalSavings}\n");

                        break;


                    case "Q":
                        keepGoing = false;
                        break;

                }

            }
        }
    }
}
