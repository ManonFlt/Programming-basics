﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    class Program
    {
        public static int Biggest(int n1, int n2)
        {
            return Math.Max(n1, n2);
        }


        public static int Biggest4(int n1, int n2, int n3, int n4)
        {
            return Biggest(Biggest(n1, n2), Biggest(n3, n4));

        }

        public static double Factorial(int n)
        {

            double fact = 1;
            for (int x = 1; x <= n; x++)
            {
                fact *= x;

            }
            return fact;
        }

        private static void Menu()
        {
            
            try
            {
                Console.WriteLine("Please choose a number : \n1 : Biggest number \n2 : Factorial\n0: Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Please enter a number : ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please another number : ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please another number : ");
                        int n3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please another number : ");
                        int n4 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"The biggest number between {n1}, {n2}, {n3} and {n4} is {Biggest4(n1, n2, n3, n4)}");
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please enter a number : ");
                        int n = int.Parse(Console.ReadLine());
                        if (n < 0)
                        {
                            Console.WriteLine("Please enter a positive integer.");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                        }
                        else
                        {
                            Console.WriteLine($"The factorial of {n} is {Factorial(n)}");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Please enter a proper number.");
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                }

            }

            catch
            {
                Console.WriteLine("Error.");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        
        }

        static void Main(string[] args)
        {
            Menu();
            //Console.ReadKey();
        }
    }
}
