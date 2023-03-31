using System;

namespace Methods_Dallas
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number!");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Multiply(x,y));

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name);

            Goodbye();
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// prints out username to with text.
        /// </summary>
        /// <param name="username">the name of user</param>
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! It is nice to meet you!");
        }


        /// <summary>
        /// prints a goodbye message to the console.
        /// </summary>
        static void Goodbye()
        {
            Console.WriteLine("Have a fantasticday!");
        }
    }
}
