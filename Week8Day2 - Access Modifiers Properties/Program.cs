using System;

namespace Week8Day2___Access_Modifiers_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessModifier am = new AccessModifier("Hello world from main");

            Console.WriteLine(am.hello);

            Console.WriteLine(am.Hello2);
        }
    }
}
