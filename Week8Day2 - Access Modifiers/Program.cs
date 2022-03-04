using System;

namespace Week8Day2___Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessModifier am = new AccessModifier();

            Console.WriteLine("Before assigning new value: " + am.GetHello());

            am.SetHello("Hello world from main");

            Console.WriteLine("After assigning new value: " + am.GetHello());

        }
    }
}
