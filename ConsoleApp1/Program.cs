﻿namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string color = Console.ReadLine()?.ToLower();
            if (color == "red")
            {
                Console.WriteLine("Sa valisid punase varvi");
            }
            else if (color == "blue")
            {
                Console.WriteLine("Sa valisid sinine varvi");
            }
            else if(color == "green")
            {
                Console.WriteLine("Sa valisid roheline varvi");
            }
        }
    }
}
