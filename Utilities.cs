using System;


namespace IntroOOP
{
    static class Utilities
    {
        //static classes cannot have constructors, as they cannot be instantiated, they don't need one.
        //therefore, you can't create a new instance of the class:
        //Utilities utilities = new Utilities();
        //public Utilities()
        //{
        //}

        public static void ColorfulWriteline(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
