using System;

namespace Week7Day2_NMAD_Banking_Inc._Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            const string BANK_NAME = "NMAD Bank Inc.";

            Console.Write($"The following prompt is not part of the banking app. \n" +
                "This prompt will run only once.\n\n" +
                "Please enter a starting balance: $");

            string inputBalance = Console.ReadLine();

            //  First Prompt for Starting Balance, the Balance to work with, validate
            if (double.TryParse(inputBalance, out double balance))
            {
                Console.WriteLine($"Welcome to { BANK_NAME}\n\n" +
                    "Please insert your debit card... reading... pin accepted\n" +
                    "What would you like to do?");

                Console.WriteLine("1. Check Balance\n" +
                    "2. Withdraw\n" +
                    "3. Deposit\n");

                Console.Write("Choose Option: ");

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                    case "balance":
                    case "check balance":
                        Console.WriteLine($"\nBalance: {balance:C}");

                        break;
                    case "2":
                    case "withdraw":
                    case "give me my money":
                        Console.Write($"\nHow much would you like to withdraw?\n" +
                            $"Current Balance - {balance:C}: $");

                        //  Ensure withrawal amount is not more than available balance
                        if (double.TryParse(Console.ReadLine(), out double withdrawalAmount) && withdrawalAmount > 0 && withdrawalAmount <= balance)
                        {
                            Console.WriteLine($"Withdrawal Amount {withdrawalAmount:C}\n");

                            balance -= withdrawalAmount;

                            Console.WriteLine($"Your new balance is {balance:C}\n" +
                                $"Don't forget to take your cash!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid withdrawal amount entered");
                            Console.ResetColor();
                        }

                        break;
                    case "3":
                    case "deposit":
                    case "deposit cash":
                        Console.Write($"\nHow much would you like to deposit?\n" +
                            $"Current Balance - {balance:C}: $");

                        if (double.TryParse(Console.ReadLine(), out double depositAmount) && depositAmount > 0)
                        {
                            Console.WriteLine($"\nDeposit Amount {depositAmount:C}");

                            balance += depositAmount;

                            Console.WriteLine($"Your new balance is {balance:C}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid deposit amount entered");
                            Console.ResetColor();
                        }

                        break;
                    case "4":
                    case "exit":
                        Console.WriteLine("Exiting...");

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Invalid Selection '{selection}'");
                        Console.ResetColor();

                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nInvalid Starting Balance '{inputBalance}'");
                Console.ResetColor();
            }

            Console.WriteLine($"\nThank you for banking with {BANK_NAME}");
        }
    }
}
