using System;

namespace Examples {
    public class Program
    {
        public static void Main()
        {
            const string Message = "Hello, my name is {0} and I am {1} years old.";
            int age = 30;
            string name = "Alice";

            /****** Interpolated strings example ******/
            string greeting = $"Hello, my name is {name} and I am {age} years old.";

            Console.WriteLine(greeting);
            //or
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");

            /****** Composite formatting strings example ******/
            Console.WriteLine(Message, name, age);

        }
    }
}