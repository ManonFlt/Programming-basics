using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        #region Section 1
        private static double CelsiusToF(double temperatureCelsius) // Celsius to Fahrenheit
        {
            try
            {               
                double toFahrenheit = (temperatureCelsius * 9 / 5) + 32;              
                return toFahrenheit;
            }
            catch
            {
                Console.WriteLine("Error.");
                return -1;
            }
        }
        private static double FahrenheitToC(double temperatureFahrenheit) // Fahrenheit to Celsius
        {
            try
            {                               
                double toCelsius = (temperatureFahrenheit - 32) * 5 / 9;   
                return toCelsius;
            }            
            catch
            {
                Console.WriteLine("Error.");
                return -1;
            }

        }       
        private static void BiggestTemperature()
        {
            Console.WriteLine("\n" + "Please enter a temperature in Celsius : ");
            double tempC = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a temperature in Fahrenheit : ");
            double tempF = double.Parse(Console.ReadLine());

            // Biggest in Celsius
            double tempFtoC = FahrenheitToC(tempF);

            double biggerCelsius = 0;
            double smallerCelsius = 0;
            double difference;

            if (tempC <= tempFtoC)
            {
                biggerCelsius = tempFtoC;
                smallerCelsius = tempC;
            }
            else if(tempFtoC < tempC)
            {
                biggerCelsius = tempC;
                smallerCelsius = tempFtoC;
            }
                    
            difference = biggerCelsius - smallerCelsius;
            Console.WriteLine($"The biggest temperature is {biggerCelsius}°C by {difference}°C.");
         
            double biggerFahrenheit = CelsiusToF(biggerCelsius);
            double differenceF = biggerFahrenheit - tempF;
            Console.WriteLine($"The biggest temperature is {biggerFahrenheit}°F by {differenceF}°F." + "\n");
        }
    


        private static void EuropeToUS()
        {
            try
            {
                Console.WriteLine("\n" + "Please enter fuel consumption in liters per 100km : ");
                double european = double.Parse(Console.ReadLine());

                // conversion to miles per gallon
                double europenToUS = (3.78 / 0.01609) / european;
                Console.WriteLine($"It equals to {europenToUS} miles per gallon" + "\n");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
        private static void USToEurope()
        {
            try
            {
                Console.WriteLine("\n" + "Please enter fuel consumption in miles per gallon : ");
                double US = double.Parse(Console.ReadLine());

                // conversion to miles per gallon
                double USToEuropean = (3.78 / 0.01609) / US;
                Console.WriteLine($"It equals to {USToEuropean} miles per gallon" + "\n");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        #endregion

        private static void Menu()
        {
            try
            {
                Console.WriteLine("Please choose a number : ");
                Console.WriteLine("1 : Temperature ");
                Console.WriteLine("2 : Fuel Consumption ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("\n" + "Please choose :" + "\n" + "1: Convert Celsius to Fahrenheit" + "\n" + "2: Convert Fahrenheit to Celsius" +"\n" + "3: Biggest Temperature");
                        int choice2 = int.Parse(Console.ReadLine());

                        switch(choice2)
                        {
                            case 1:
                                Console.Write("\n" + "Please enter a temperature in Celsius: ");
                                double temperatureCelsius = double.Parse(Console.ReadLine());
                                double toFahrenheit = CelsiusToF(temperatureCelsius);
                                Console.WriteLine($"{temperatureCelsius}°C in Fahrenheit is {toFahrenheit}°F" + "\n");
                                Menu();
                                break;

                            case 2:
                                Console.Write("\n" + "Please enter a temperature in Fahrenheit: ");
                                double temperatureFahrenheit = double.Parse(Console.ReadLine());
                                double toCelsius = FahrenheitToC(temperatureFahrenheit);
                                Console.WriteLine($"{temperatureFahrenheit}°F in Celsius is {toCelsius}°C" + "\n");
                                Menu();
                                break;

                            case 3:
                                BiggestTemperature();
                                Menu();
                                break;

                            default:
                                Console.WriteLine("Please enter a proper number. " + "\n");
                                Menu();
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n" + "Please choose :" + "\n" + "1: Europe to US" + "\n" + "2: US to Europe");
                        int choice3 = int.Parse(Console.ReadLine());

                        switch(choice3)
                        {
                            case 1:
                                EuropeToUS();
                                Menu();
                                break;
                            case 2:
                                USToEurope();
                                Menu();
                                break;
                            default:
                                Console.WriteLine("Please enter a proper number. " + "\n");
                                Menu();
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Please enter a proper number." + "\n");
                        Menu();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Error.");
            }
        }
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}
