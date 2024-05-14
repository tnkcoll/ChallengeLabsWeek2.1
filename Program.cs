using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ChallengeLabsWeek2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int temp;
            bool isInt;
            do
            { 
                do
                {
                    Console.WriteLine("Please enter the temperature in fahrenheit or hit X to exit the program.");
                    userInput = Console.ReadLine();  
                } while (userInput == "");
                
                
                isInt = int.TryParse(userInput, out temp);
                if (isInt)
                {
                    switch (temp)
                    {
                        case <= 10:
                            Console.WriteLine("Freezing weather");
                            break;
                        case int i when i >= 11 && i <= 20:
                            Console.WriteLine("Very cold weather");
                            break;
                        case int i when i >= 21 && i <= 35:
                            Console.WriteLine("Cold weather");
                            break;
                        case int i when i >= 36 && i <= 50:
                            Console.WriteLine("Normal weather");
                            break;
                        case int i when i >= 51 && i <= 65:
                            Console.WriteLine("Hot");
                            break;
                        case int i when i >= 66 && i <= 80:
                            Console.WriteLine("Very hot");
                            break;
                        default:
                            Console.WriteLine("Get in the AC!");
                            break;
                    }
                }
            } while (userInput != "X" && userInput != "x");

            
        }
    }
}
