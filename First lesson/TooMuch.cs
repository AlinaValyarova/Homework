using System;

namespace TooMuch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tumakov classwork
            //Task 2.1
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //Task 2.2
            Console.WriteLine("Task 2.2");
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Division by 0 is impossible, it makes me sad too :(");
            }
            Console.WriteLine($"num1 / num2 = {num1 / num2}");

            //Tumakov homework
            //Task 2.1

            Console.WriteLine("Enter any letter from alphabet in lowercase and you will get the next one");
            string letter = Console.ReadLine();
            if (letter == "a")
                Console.WriteLine("The next letter is b");
            else if (letter == "b")
                Console.WriteLine("The next letter is c");
            else if (letter == "c")
                Console.WriteLine("The next letter is d");
            else if (letter == "d")
                Console.WriteLine("The next letter is e");
            else if (letter == "e")
                Console.WriteLine("The next letter is f");
            else if (letter == "f")
                Console.WriteLine("The next letter is g");
            else if (letter == "g")
                Console.WriteLine("The next letter is h");
            else if (letter == "h")
                Console.WriteLine("The next letter is i");
            else if (letter == "i")
                Console.WriteLine("The next letter is g");
            else if (letter == "g")
                Console.WriteLine("The next letter is k");
            else if (letter == "k")
                Console.WriteLine("The next letter is l");
            else if (letter == "l")
                Console.WriteLine("The next letter is m");
            else if (letter == "m")
                Console.WriteLine("The next letter is n");
            else if (letter == "n")
                Console.WriteLine("The next letter is o");
            else if (letter == "o")
                Console.WriteLine("The next letter is p");
            else if (letter == "p")
                Console.WriteLine("The next letter is q");
            else if (letter == "q")
                Console.WriteLine("The next letter is r");
            else if (letter == "r")
                Console.WriteLine("The next letter is s");
            else if (letter == "s")
                Console.WriteLine("The next letter is t");
            else if (letter == "t")
                Console.WriteLine("The next letter is u");
            else if (letter == "u")
                Console.WriteLine("The next letter is v");
            else if (letter == "v")
                Console.WriteLine("The next letter is w");
            else if (letter == "w")
                Console.WriteLine("The next letter is x");
            else if (letter == "x")
                Console.WriteLine("The next letter is y");
            else if (letter == "y")
                Console.WriteLine("The next letter is z");
            else if (letter == "z")
                Console.WriteLine("You entered the last letter of the alphabet");

            //Task 2.2

            Console.WriteLine("We will help you solve a quadratic equation. Just enter the values of a, b and c below");
            Console.WriteLine("Enter the value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            int c = Convert.ToInt32(Console.ReadLine());
            int discriminant = (b * b - 4 * a * c);
            Console.WriteLine("The first x equals " + (-b + discriminant) / 2 * a);
            int X2 = (-b - discriminant) / 2 * a;
            Console.WriteLine("the second x equals " + X2);
        }
    }
}
