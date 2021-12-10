using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    class Program
    {
        public static int Minimum(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i]<min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int Maximum(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            return max;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length ; i++)
            {
                sum += array[i];
            }
            
            return sum;
        }

        public static int Average(int[] array)
        {
            int average = 0;
            int sum = Sum(array);
            average = sum / array.Length;
            return average;
        }

        public static int[] RemoveDuplicates(int[] arr)
        {
            
            List<int> newArray = new List<int>();
            for(int i=0; i<arr.Length; i++)
            {
                if(newArray.Contains(arr[i])==false)
                {
                    newArray.Add(arr[i]);
                }
            }
            return newArray.ToArray();
        }
        private static void Menu()
        {
            try
            {
                Console.WriteLine("Please choose a number : \n" +
                    "1 : Minimum in an array \n" +
                    "2 : Maximum in an array \n" +
                    "3: Sum of all numbers in an array \n" +
                    "4: Average of all numbers of an array \n" +
                    "5: Remove duplicates in an array");

                int choice = int.Parse(Console.ReadLine());

                

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Please enter the size of the array : ");
                        int n = int.Parse(Console.ReadLine());
                        int[] arr = new int[n];
                        for (int i = 0; i <n; i++)
                        {
                            Console.WriteLine("Please another number : ");
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"The minimum is {Minimum(arr)}");

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please enter the size of the array : ");
                        int n2 = int.Parse(Console.ReadLine());
                        int[] arr2 = new int[n2];
                        for (int i = 0; i < n2; i++)
                        {
                            Console.WriteLine("Please another number : ");
                            arr2[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"The maximum is {Maximum(arr2)}");

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Please enter the size of the array : ");
                        int n3 = int.Parse(Console.ReadLine());
                        int[] arr3 = new int[n3];
                        for (int i = 0; i < n3; i++)
                        {
                            Console.WriteLine("Please another number : ");
                            arr3[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"The sum is {Sum(arr3)}");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Please enter the size of the array : ");
                        int n4 = int.Parse(Console.ReadLine());
                        int[] arr4 = new int[n4];
                        for (int i = 0; i < n4; i++)
                        {
                            Console.WriteLine("Please another number : ");
                            arr4[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"The average is {Average(arr4)}");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Please enter the size of the array : ");
                        int n5 = int.Parse(Console.ReadLine());
                        int[] arr5 = new int[n5];
                        for (int i = 0; i < n5; i++)
                        {
                            Console.WriteLine("Please another number : ");
                            arr5[i] = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Your array is ");

                        for (int j = 0; j < arr5.Length; j++)
                        {
                            Console.Write(arr5[j] + " ");
                        }

                        int[] result = RemoveDuplicates(arr5);

                        Console.Write("\nThe new array without duplicates is ");
                        for(int j=0; j<result.Length; j++)
                        {
                            Console.Write(result[j] + " ");
                        }
                        break;

                    default:
                        Console.WriteLine("Please enter a proper number." + "\n");
                        
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Error.");
                Console.WriteLine("Please enter a proper number.");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
        static void Main(string[] args)
        {            
            Menu();
            Console.ReadKey();
        }
    }
}
