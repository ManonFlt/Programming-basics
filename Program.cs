using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        private static void Triangles()
        {
            Console.Write("Side A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Side B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Side C: ");
            int C = int.Parse(Console.ReadLine());

            if(A==B || B==C || A==C)
            {
                Console.WriteLine("There are 2 equal sides.");
            }
            else
            {
                Console.WriteLine("There are no equal sides.");
            }

            if (A == B && B == C)
            {
                Console.WriteLine("There are 3 equal sides.");
                Console.WriteLine("A, B and C are equal.");
            }

            else if (A == B)
            {
                Console.WriteLine("A and B are equal.");
            }
            else if (B == C)
            {
                Console.WriteLine("B and C are equal.");
            }
            else if (A == C)
            {
                Console.WriteLine("A and C are equal.");
            }

        }

        private static void Numbers()
        {
            Console.Write("Number 1: ");
            int A01 = int.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            int A02 = int.Parse(Console.ReadLine());

            Console.Write("Number 3: ");
            int A03 = int.Parse(Console.ReadLine());

            Console.Write("Number 4: ");
            int A04 = int.Parse(Console.ReadLine());

            Console.Write("Number 5: ");
            int A05 = int.Parse(Console.ReadLine());

            Console.Write("Number 6: ");
            int A06 = int.Parse(Console.ReadLine());

            Console.Write("Number 7: ");
            int A07 = int.Parse(Console.ReadLine());

            Console.Write("Number 8: ");
            int A08 = int.Parse(Console.ReadLine());

            Console.Write("Number 9: ");
            int A09 = int.Parse(Console.ReadLine());

            Console.Write("Number 10: ");
            int A10 = int.Parse(Console.ReadLine());

            long sum = 0;
            int count = 0;

            if(10 <= A01 && A01 <= 20)
            {
                count++;
                sum = sum + A01;
            }
            if (10 <= A02 && A02 <= 20)
            {
                count++;
                sum = sum + A02;
            }
            if (10 <= A03 && A03 <= 20)
            {
                count++;
                sum = sum + A03;
            }
            if (10 <= A04 && A04 <= 20)
            {
                count++;
                sum = sum + A04;
            }
            if (10 <= A05 && A05 <= 20)
            {
                count++;
                sum = sum + A05;
            }
            if (10 <= A06 && A06 <= 20)
            {
                count++;
                sum = sum + A06;
            }
            if (10 <= A07 && A07 <= 20)
            {
                count++;
                sum = sum + A07;
            }
            if (10 <= A08 && A08 <= 20)
            {
                count++;
                sum = sum + A08;
            }
            if (10 <= A09 && A09 <= 20)
            {
                count++;
                sum = sum + A09;
            }
            if (10 <= A10 && A10 <= 20)
            {
                count++;
                sum = sum + A10;
            }

            Console.WriteLine("Count of numbers between 10 and 20 is: " + count);
            Console.WriteLine("Sum of numbers between 10 and 20 is: " + sum);
        }

        private static void SportSelector()
        {
            Console.WriteLine("Please enter your height in centimeters: ");
            int height = int.Parse(Console.ReadLine());

            if (height > 190)
            {
                Console.WriteLine("Basketball");
            }
            else if (height > 175)
            {
                Console.WriteLine("Athletics");
            }
            else
            {
                Console.WriteLine("Horse riding");
            }

        }

        private static void Greeting()
        {
            Console.WriteLine("Please enter the day of the week (number between 1 and 7): ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the time (number between 0 and 23): ");
            int hour = int.Parse(Console.ReadLine());

            string time;
            if (hour<12)
            {
                time = "morning";
            }
            else if (hour<19)
            {
                time = "afternoon";
            }
            else
            {
                time = "evening";
            }

            string day2;
            string weekend;

            switch(day)
            {
                case 1: 
                    day2="Monday";
                    break;
                case 2: 
                    day2 = "Tuesday";
                    break;
                case 3: 
                    day2 = "Wednesday";
                    break;
                case 4: 
                    day2 = "Thursday";
                    break;
                case 5: 
                    day2 = "Friday";
                    break;
                case 6:
                    day2 = "Saturday";
                    break;
                case 7: 
                    day2 = "Sunday";
                    break;
                default: 
                    day2 = "Error!"; 
                    break;
            }

            if (day<6)
            {
                weekend = $"coming in {6-day} days.";
            }

            else
            {
                weekend = "here !";
            }
 

            Console.WriteLine($"Good {time}, it is a lovely {day2} today. Weekend is {weekend}");
        }

        private static void Greeting2(DateTime argument)
        {
            int hour = argument.Hour;
            string time;
            if (hour < 12)
            {
                time = "morning";
            }
            else if (hour < 19)
            {
                time = "afternoon";
            }
            else
            {
                time = "evening";
            }

            string weekend="";
            switch(argument.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    weekend = "coming in 5 days.";
                    break;
                case DayOfWeek.Tuesday:
                    weekend = "coming in 4 days.";
                    break;
                case DayOfWeek.Wednesday:
                    weekend = "coming in 3 days.";
                    break;
                case DayOfWeek.Thursday:
                    weekend = "coming in 2 days.";
                    break;
                case DayOfWeek.Friday:
                    weekend = "coming in 1 day.";
                    break;
                case DayOfWeek.Saturday:
                    weekend = "here!";
                    break;
                case DayOfWeek.Sunday:
                    weekend = "here!";
                    break;
            }


            Console.WriteLine($"Good {time}, it is a lovely {argument.DayOfWeek} today. Weekend is {weekend}");

        }

        private static void FormValidation()
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your date of birth: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Please enter your student number: ");
            string studentNumber = Console.ReadLine();

            if(firstName.Length>100 || lastName.Length>100 || studentNumber.Length!=12)
            {
                Console.WriteLine("not valid");
            }
            else
            {
                Console.WriteLine("valid");
            }
            
        }
        static void Main(string[] args)
        {
            //Triangles();
            //Numbers();
            //SportSelector();
            //Greeting();
            //Greeting2(DateTime.Now);
            FormValidation();
            Console.ReadKey();
        }
    }
}
