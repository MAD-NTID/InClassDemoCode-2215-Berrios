using System;

namespace Week10Day2___MidtermPracticePracticel2
{
    class Program
    {
        #region Predefined Code, DO NOT MODIFY
        const string HEADER = "MAD4UFOS Data Collection System";
        const string DASHER = "--------";

        static readonly string[] menu = {
            "Enter a Sighting",
            "Display all sightings",
            "Display sightings filtered by species",
            "Display Record Count",
            "Exit"
        };

        static Alien[] aliens = Array.Empty<Alien>();
        #endregion

        static void Main(string[] args)
        {
            #region STUDENT CODE HERE
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            DisplayHeader();

            /*
             * This while loop is controlled by the continueProgram bool variable
             * For exiting this loop, set the continueProgram variable to false as needed
             * 
             * You may optional use Environment.Exit(0)
             * */
            bool continueProgram = true;
            while (continueProgram)
            {
                /*
                 * Uncomment this method when you are ready to code for it
                 * Create the method in the Region STUDENT METHOD CODES HERE
                 * */
                DisplayMenu();

                switch (GetMenuSelection())
                {
                    case 1:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        EnterASighting();

                        break;
                    case 2:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        DisplayAllSightings();

                        break;
                    case 3:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        FilterBySpecies();

                        break;
                    case 4:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        DisplayRecordCount();

                        break;
                    case 5:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        continueProgram = !Exit();

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("==> Invalid choice");
                        Console.ResetColor();

                        break;
                }
            }
            #endregion
        }

        #region STUDENT METHOD CODES HERE
        //  Code for DisplayHeader() here
        public static void DisplayHeader()
        {
            Console.WriteLine(HEADER);
            Console.WriteLine(DateTime.Now.ToString());
        }

        //  Code for DisplayMenu() here
        public static void DisplayMenu()
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("=========");

            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }

            Console.Write($"Enter your selection (1 - {menu.Length}): ");
        }

        //  Code for EnterASighting() here
        public static void EnterASighting()
        {
            string name, date, location;

            while (true)
            {
                Console.Write($"Enter the name of the alien ({string.Join(", ", Alien.Species)}): ");

                name = Console.ReadLine();

                if (Alien.HaveSpecies(name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Alien");
                }
            }

            while (true)
            {
                Console.Write("Enter the date of the sighting: ");
                date = Console.ReadLine();

                if (Alien.DateIsValid(date))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Date of Sighting");
                }
            }

            while (true)
            {
                Console.Write("Ener the location of the sighting: ");
                location = Console.ReadLine();

                if (string.IsNullOrEmpty(location))
                {
                    Console.WriteLine("Invalid location");
                }
                else
                {
                    break;
                }
            }

            IncreaseAliensArraySize();

            Alien alien = new Alien(name, date, location);

            aliens[aliens.Length - 1] = alien;
        }

        //  Code for DisplayAllSightings() here
        public static void DisplayAllSightings()
        {
            DisplaySightingsHeader();

            int counter = 0;

            foreach (Alien alien in aliens)
            {
                if (alien != null)
                {
                    Console.WriteLine(alien);
                    counter++;
                }
            }

            Console.WriteLine($"\n==> {counter} of Aliens Sighted");
        }

        //  Code for FilterBySpecies() here
        public static void FilterBySpecies()
        {
            Console.Write("Enter a species to filter by: ");
            string input = Console.ReadLine();

            DisplaySightingsHeader();

            int counter = 0;

            for (int i = 0; i < aliens.Length; i++)
            {
                if (aliens[i].Name.ToLower() == input)
                {
                    Console.WriteLine(aliens[i]);
                    counter++;
                }
            }

            Console.WriteLine($"{counter} records displayed");
        }

        //  Code for DisplayRecordCount() here
        public static void DisplayRecordCount()
        {
            Console.WriteLine($"There are {aliens.Length} sighted!");
        }

        //  Code for Exit() here
        public static bool Exit()
        {
            while (true)
            {
                Console.Write("Do you really want to exit? Press 'Y' to confirm: ");

                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    Console.WriteLine($"Thank you for using {HEADER}. Good Bye!");

                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }

                Console.WriteLine($"Invalid option {input}");
            }
        }
        #endregion

        #region PREDEFINED CODE, DO NOT MODIFY
        /// <summary>
        /// This method will validate that the menu choice is valid.
        /// </summary>
        /// <returns>Returns the int value for the menu selection made</returns>
        private static int GetMenuSelection()
        {
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= menu.Length)
                return choice;

            return -1;
        }

        /// <summary>
        /// This method takes care of increasing the array by 1 index so that any new Alien object can be added to the aliens Array
        /// </summary>
        /// <param name="aliens">Accepts a parameter of Aliens</param>
        private static void IncreaseAliensArraySize()
        {
            Array.Resize(ref aliens, aliens.Length + 1);
        }

        /// <summary>
        /// This method can be used when you want to display a header for all the Alien sightings before listing them
        /// </summary>
        private static void DisplaySightingsHeader()
        {
            Console.WriteLine($"\n{"Species",Alien.RIGHT_SPACER} {"Date",Alien.LEFT_SPACER} {"Location",Alien.RIGHT_SPACER}");
            Console.WriteLine($"{DASHER,Alien.RIGHT_SPACER} {DASHER,Alien.LEFT_SPACER} {DASHER,Alien.RIGHT_SPACER}");
        }
        #endregion
    }
}
