using System;

namespace Week7Day2_Banking_App
{
    class Program
    {
        static void Main(string[] args)
        {
            const string BANK_NAME = "NMAD Bank Inc.";

            //  This starting balance variable holds the current balance
            double balance = 0;

            Console.WriteLine($"Welcome to {BANK_NAME}");

            //  This is an array for options. Use this in a for loop to show options to the user
            string[] bankingOptions = {"Check Balance", "Withdraw", "Deposit Cash"};

            //  This boolean controls the banking loop
            bool continueBanking = true;

            //  ASSUME STARTING BALANCE IS ALWAYS VALIDATESD
            string balanceInput;

            //  ASSUME THIS IS ALWAYS VALID
            Console.Write("Enter a starting balance to begin Banking: ");
            balanceInput = Console.ReadLine();

            //  Once the starting balance is validated, continue to the banking app
            do
            {
                if (double.TryParse(balanceInput, out balance) && balance >= 0)
                {
                    Console.WriteLine("Please insert your debit card... reading...\nWhat would you like to do? ");

                    ShowBankingOptions(bankingOptions);

                    switch (Console.ReadLine().ToLower())
                    {
                        case "1":
                        case "balance":
                        case "check balance":
                            Console.WriteLine($"Balance: {balance:C}");

                            break;
                        case "2":
                        case "withdraw":
                        case "give me my money":
                            Console.Write($"How much would you like to withdraw?\n" +
                                $"Current Balance - {balance:C}: ");

                            //  Ensure withrawal amount is not more than available balance
                            if (double.TryParse(Console.ReadLine(), out double withdrawalAmount) && withdrawalAmount > 0 && withdrawalAmount <= balance)
                            {
                                Console.WriteLine($"Withdrawal Amount {withdrawalAmount:C}\n");

                                balance = Withdraw(balance, withdrawalAmount);

                                Console.WriteLine($"Your new balance is {balance:C}\n" +
                                    $"Don't forget to take your cash!");
                            }
                            else
                            {
                                ShowError("Invalid withdrawal amount entered");
                            }

                            break;
                        case "3":
                        case "deposit":
                        case "deposit cash":
                            Console.Write($"How much would you like to deposit?\n" +
                                $"Current Balance - {balance:C}: ");

                            if (double.TryParse(Console.ReadLine(), out double depositAmount) && depositAmount > 0)
                            {
                                Console.WriteLine($"Deposit Amount {depositAmount:C}");

                                balance = Deposit(balance, depositAmount);

                                Console.WriteLine($"Your new balance is {balance:C}");
                            }
                            else
                            {
                                ShowError("Invalid deposit amount entered");
                            }

                            break;
                        default:
                            ShowError("Invalid Option.");

                            break;
                    }
                }
                else
                {
                    ShowError($"Invalid balance '{balanceInput}' entered");
                }

                //  ASSUME THIS IS AN ATM MACHINE AND ONLY HAS "YES" AND "NO" INPUT
                Console.Write("Do you want to continue with another transaction? ");

                switch (Console.ReadLine().ToLower())
                {
                    case "no":
                        continueBanking = false;

                        break;
                }
            } while (continueBanking);

            Console.WriteLine($"Thank you for Banking with {BANK_NAME}\n Have a Nice Day with your Benjamins!");
        }

        private static double Withdraw(double balance, double withdrawal)
        {
            return balance - withdrawal;
        }

        private static double Deposit(double balance, double deposit)
        {
            return balance + deposit;
        }

        private static void ShowBankingOptions(string[] bankingOptions)
        {
            for (int i = 0; i < bankingOptions.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {bankingOptions[i]}");
            }
        }

        private static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{message}");

            //  sets to default white
            Console.ResetColor();
        }
    }
}
