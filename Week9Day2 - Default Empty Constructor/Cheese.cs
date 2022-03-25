using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Day2___Default_Empty_Constructor
{
    class Cheese
    {
        public static string AMERICAN = "American", PROVOLONE = "Provolone", SWISS = "Swiss";

        string[] availableCheese = { AMERICAN, PROVOLONE, SWISS };
        string[] cheese = new string[100];

        int cheeseCounter = 0;

        public void AddCheese(string cheeseToAdd)
        {
            if(HasCheese(cheeseToAdd))
            {
                cheese[cheeseCounter] = cheeseToAdd;
                cheeseCounter++;
            }
        }

        public bool HasCheese(string cheeseToAdd)
        {
            return Array.IndexOf(availableCheese, cheeseToAdd) >= 0;
        }

        public string[] GetCheese()
        {
            return cheese;
        }
    }
}
