using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Day2___Access_Modifiers_Properties
{
    class AccessModifier
    {
        public string hello
        {
            get; set;
        }

        private string hello2;

        public string Hello2
        {
            get
            {
                return hello2;
            }
            
            set
            {
                hello2 = value;

                //  uppercase all letters in odd index
                char[] hello2Array = hello2.ToCharArray();
                string finalString = "";

                for(int i = 0; i < hello2Array.Length; i++)
                {
                    if(i % 2 == 0)
                    {
                        finalString += hello2Array[i].ToString().ToUpper();
                    }
                    else
                    {
                        finalString += hello2Array[i].ToString();
                    }
                }

                hello2 = finalString;
            }
        }

        public AccessModifier(string value)
        {
            hello = value;
            Hello2 = value;
        }
    }
}
