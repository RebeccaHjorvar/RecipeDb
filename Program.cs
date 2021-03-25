using Recipes.Models;
using System;
using System.Collections.Generic;

namespace Recipes
{
    class Program
    {
        static void Main(string[] args)
        {   // Colors
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            // App
            DisplayMainMenu();

            var hej = new Recipe();


        }

        static void DisplayMainMenu()
        {   
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1: Add a recipe");
                Console.WriteLine("2: View recipe categories");
                Console.WriteLine("3: Update/remove a recipe");
                Console.WriteLine("4: Add a category");
                Console.WriteLine("5: Update/remove category");
                Console.WriteLine("6: Exit program");
               
        }
    }
}
