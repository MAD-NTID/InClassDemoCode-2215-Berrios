using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Day2___Access_Modifiers
{
    class AccessModifier
    {
        string Hello = "Hello World";

        //  Getter method
        public string GetHello()
        {
            return Hello;
        }

        //  Setter Method
        public void SetHello(string value)
        {
            Hello = value;
        }
    }
}
