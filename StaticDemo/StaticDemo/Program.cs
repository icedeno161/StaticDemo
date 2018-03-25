using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = String.Empty;

            while (selection != "q" && selection != "Q")
            {
                Console.Write("Enter C)elsius to Fahrenheit or F)ahrenheit to Celsius or Q): ");
                selection = Console.ReadLine();

                double fahrenheit = 0, celsius = 0;

                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Enter the Celsius temperature: ");
                        fahrenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"The temperature in Fahrenheit is {fahrenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Enter the Fahrenheit temperature: ");
                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"The temperature in Celsius is {celsius:f2}");
                        break;
                    case "Q":
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Please try again...");
                        break;
                }
            }
        }
    }
}
