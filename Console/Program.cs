using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Console Calculator");
                Console.WriteLine("==================");
                Console.ResetColor();

                Console.Write("Enter the ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("first");
                Console.ResetColor();
                Console.Write(" value: ");

                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ResetColor();
                    Console.Write("Enter the first value: ");
                }

                Console.Write("Enter the ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("second");
                Console.ResetColor();
                Console.Write(" value: ");

                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ResetColor();
                    Console.Write("Enter the second value: ");
                }

                Console.Write("What operation do you want? Press ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("+ - * /");
                Console.ResetColor();
                Console.Write(" : ");

                string character = Console.ReadLine();

                double result = 0;

                switch (character)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/": result = (num2 != 0) ? num1 / num2 : 0; break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid operation");
                        Console.ResetColor();
                        break;
                }

                Console.Write("The result of your operation is: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(result);
                Console.ResetColor();

                Console.Write("Do you want to perform another operation? (");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("y");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("n");
                Console.ResetColor();
                Console.Write("): ");

                string response = Console.ReadLine();

                if (response.ToLower() != "y")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    Console.ResetColor();
                    Thread.Sleep(3000); // Pausa durante 3 segundos
                    break;
                }

                Console.WriteLine(); // Espacio en blanco para mejor legibilidad
            }
        }
    }
}
