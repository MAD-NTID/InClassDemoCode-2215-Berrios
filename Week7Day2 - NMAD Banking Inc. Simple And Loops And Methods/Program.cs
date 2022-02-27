using System;

namespace Week7Day2___NMAD_Banking_Inc._Simple_And_Loops_And_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            const string BANK_NAME = "NMAD Bank Inc.";

            string[] bankingSelections = { "Check Balance", "Withdraw", "Deposit", "Exit" };

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

                    WelcomeToBank(BANK_NAME);

                    //  The following loop is used to validate the banking selections
                    bool doneTransaction = false;

                    do
                    {
                        string selection = PromptBankingSelection(bankingSelections);

                        switch (selection)
                        {
                            //  Cases for Banking Selection 1 (Check Balance)
                            case "1":
                            case "balance":
                            case "check balance":
                                CheckBalance(balance);

                                break;

                            //  Cases for Banking Selection 2 (Withdraw Cash)
                            case "2":
                            case "withdraw":
                            case "give me my money":
                                balance = WithdrawCash(balance);

                                break;

                            //  Cases for Banking Selection 3 (Deposit Cash)
                            case "3":
                            case "deposit":
                            case "deposit cash":
                                balance = DepositCash(balance);

                                break;

                            //  Cases for Banking Selection 4 (Exit / End Transaction)
                            case "4":
                            case "exit":
                                doneTransaction = true;

                                break;

                            //  Default for Invalid Banking Selection
                            default:
                                ShowError($"Invalid Selection '{selection}'");

                                break;
                        }
                    } while (!doneTransaction);

                    Console.WriteLine($"\nThank you for banking with {BANK_NAME}");
                }
                else
                {
                    ShowError($"Invalid Starting Balance '{inputBalance}'");
                }
            } while (!startingBalanceValid);
        }

        //  ===================================================== //
        //  CUSTOM METHODS ====================================== //
        private static void WelcomeToBank(string bankName)
        {
            Console.WriteLine($"Welcome to {bankName}\n\n" +
                        "Please insert your debit card... reading... pin accepted\n" +
                        "What would you like to do?");
        }

        private static string PromptBankingSelection(string[] bankingSelection)
        {
            for (int i = 0; i < bankingSelection.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {bankingSelection[i]}");
            }

            Console.Write("\nChoose Option: ");

            //  We return the user's input selection so that we can also use it to show errors in the default.
            return Console.ReadLine().ToLower();
        }

        private static void CheckBalance(double balance)
        {
            Console.WriteLine($"\nBalance: {balance:C}");
        }

        private static double WithdrawCash(double balance)
        {
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
                ShowError($"Invalid withdrawal amount entered");
            }

            return balance;
        }

        private static double DepositCash(double balance)
        {
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
                ShowError("Invalid deposit amount entered");
            }

            return balance;
        }

        //  ===================================================== //
        //  HELPER METHODS ====================================== //
        private static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{message}");
            Console.ResetColor();
        }
    }
}
