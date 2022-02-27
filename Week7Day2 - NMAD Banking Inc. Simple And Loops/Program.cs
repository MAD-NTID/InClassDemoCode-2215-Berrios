using System;

namespace Week7Day2___NMAD_Banking_Inc._Simple_And_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            const string BANK_NAME = "NMAD Bank Inc.";

            Console.Write($"The following prompt is not part of the banking app. \n" +
                "This prompt will run only once.\n\n");

            //  The following do/while loop validates the starting balance
            bool startingBalanceValid = false;

            do
            {
                Console.Write("Please enter a starting balance: $");

                string inputBalance = Console.ReadLine();

                //  First Prompt for Starting Balance, the Balance to work with, validate
                if (double.TryParse(inputBalance, out double balance))
                {
                    //  Once the starting balance is valid, we set the true value so that the first do while loop exits after the banking loop
                    startingBalanceValid = true;

                    Console.WriteLine($"Welcome to { BANK_NAME}\n\n" +
                        "Please insert your debit card... reading... pin accepted\n" +
                        "What would you like to do?");

                    //  The following loop is used to validate the banking selections
                    bool doneTransaction = false;

                    do
                    {
                        Console.WriteLine("\n1. Check Balance\n" +
                            "2. Withdraw\n" +
                            "3. Deposit\n" +
                            "4. Exit");

                        Console.Write("Choose Option: ");

                        //  We store the user's input selection so that we can also use it to show errors in the default.
                        string selection = Console.ReadLine().ToLower();

                        switch (selection)
                        {
                            //  Cases for Banking Selection 1 (Check Balance)
                            case "1":
                            case "balance":
                            case "check balance":
                                Console.WriteLine($"\nBalance: {balance:C}");

                                break;

                            //  Cases for Banking Selection 2 (Withdraw Cash)
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

                            //  Cases for Banking Selection 3 (Deposit Cash)
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

                            //  Cases for Banking Selection 4 (Exit / End Transaction)
                            case "4":
                            case "exit":
                                doneTransaction = true;

                                break;

                            //  Default for Invalid Banking Selection
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Invalid Selection '{selection}'");
                                Console.ResetColor();

                                break;
                        }
                    } while (!doneTransaction);

                    Console.WriteLine($"\nThank you for banking with {BANK_NAME}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nInvalid Starting Balance '{inputBalance}'");
                    Console.ResetColor();
                }
            } while (!startingBalanceValid);
        }
    }
}
