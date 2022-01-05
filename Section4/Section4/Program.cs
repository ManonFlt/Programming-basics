using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4
{
    class Program
    {
        public static bool ValidEmail(string mail)
        {
            bool valid = false;

            if (mail == null || mail.Contains("@"))
            {
                valid = true;
                Console.WriteLine("Valid e-mail address.");
            }
            else
            {
                Console.WriteLine("Invalid e-mail address.");
                
            }
            return valid;
        }

        public static string CapitalizeWord(string word)
        {
            return word.ToUpper();
        }
        private static void MainMenu()
        {
            string menuOption;
            do
            {
                Console.Clear();

                Console.WriteLine(
                "1. Valid email address\n" +
                "2. Capitalize a word\n" +
                "3. Capitalize a sentence\n" +
                "===========\n" +
                "0. Exit    \n" +
                "===========\n");

                Console.Write("Please enter your choice: ");
                menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Please write the email address: ");
                        string email = Console.ReadLine();
                        ValidEmail(email);
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Please write the word: ");
                        string word = Console.ReadLine();

                        string[] array = word.Split(' ');
                        if (array.Length == 1)
                        {
                            Console.WriteLine(CapitalizeWord(word));
                        }
                        else
                        {
                            Console.WriteLine("Please enter only one word.");
                        }                        

                        Console.ReadKey();
                        
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Please write the sentence: ");
                        string sentence = Console.ReadLine();
                        Console.WriteLine(CapitalizeWord(sentence));
                        Console.ReadKey();
                        break;
                }
            } while (menuOption != "0");
        }

        static void Main(string[] args)
        {
            MainMenu();
            Console.ReadKey();
        }
    }
}
