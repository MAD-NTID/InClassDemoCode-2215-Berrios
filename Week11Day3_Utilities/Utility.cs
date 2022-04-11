using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Day3_Utilities
{
    public static class Utility
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static string YessesNays(this string value)
        {
            var yessesNays = new Dictionary<string, string>
            {
                //  "y" all the yesses
                {"y", "y"},
                {"yes", "y"},
                {"yh", "y" },
                {"yup", "y" },
                {"okay", "y" },
                {"sure", "y" },
                {"positive", "y" },
                {"yuppers", "y" },
                {"si", "y" },
                {"aye", "y" },
                {"oui", "y" },

                //  "n" all the nays
                {"n", "n" },
                {"no", "n" },
                {"nope", "n" },
                {"nay", "n" },
                {"nopey", "n" },
                {"nah", "n" },
                {"negative", "n" }
            };

            if(value != null && yessesNays.TryGetValue(value.ToLower(), out string finalResponse))
                return finalResponse;

            return null;
        }

        public static string ToUpperFirst(this string value)
        {
            // The long and ugly way
            value = value.ToLower();

            char[] theValue = value.ToCharArray();

            theValue[0] = theValue[0].ToString().ToUpper().ToCharArray()[0];

            string newValue = "";

            foreach (char c in theValue)
                newValue += c;

            return newValue;

            //  More Elegant solution
            //  Replaces the first character with an upper case of its own character
            //value = value.Remove(0, 1)
            //    .Insert(0, value[0].ToString().ToUpper());

            //return value;
        }
    }
}
