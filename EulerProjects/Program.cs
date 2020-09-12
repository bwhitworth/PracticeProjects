using System;
using static System.Console;

namespace EulerProjects
{
    class Program
    {
        static string Intro()
        {
            WriteLine("Select Euler Project you want to try:");

            WriteLine("1. Flooring Cost Calculator");
            WriteLine("5. Exit");

            WriteLine();

            WriteLine("Please pick a number and press enter.");
            string input = ReadLine();
            return input;

        }
        static void Main()
        {
            string userInput;

            userInput = Intro();

            Menu(userInput);
        }

        static void Menu(string input)
        {
            string response;

            while (true)
            {
                switch (input)
                {
                    case "1":
                        WriteLine("This project will help calculate the total cost of flooring for a room, given the dimensions and cost per sq ft.");
                        
                        WriteLine("Please enter the width of the floor plan:");
                        response = ReadLine();
                        int widthInput = Convert.ToInt16(response);
                        
                        WriteLine("Please enter the length of the floor plan:");
                        response = ReadLine();
                        int lengthInput = Convert.ToInt16(response);
                        
                        WriteLine("Please enter the cost per sq ft of the flooring material:");
                        response = ReadLine();
                        Double costInput = Convert.ToDouble(response);

                        FlooringCost(widthInput, lengthInput, costInput);
                        // input = Intro();
                        break;
                    case "5":
                        WriteLine("Exit");
                        break;

                }
            }
        }

        static void FlooringCost(int width, int length, Double cost)
        {
            var totalCost = width * length * cost;
            WriteLine(totalCost);
        }
    }
}
