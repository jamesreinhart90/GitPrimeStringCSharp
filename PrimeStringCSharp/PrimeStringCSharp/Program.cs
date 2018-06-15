using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStringCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string primestring = PrimeNumberString();
            WelcomeMessage();
            int inptValue = GetInput();
            int idNumber = GetIDNumber(primestring, inptValue);
            EndMessage(idNumber);
        }

        static string PrimeNumberString()
        {
            int isPrime;
            string primeString = "";

            for (int i = 2; i <= 1993; i++)
            {
                isPrime = 0;

                for (int j = 2; j < i; j++)
                {
                    
                    if (i % j == 0)
                    {
                        isPrime++;
                    }
                }

                if (isPrime == 0)
                {
                    primeString = primeString + i;
                }
            }

            return primeString;
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Prime String Finder");
            Console.WriteLine("Please enter a number between 1 and 1,000");
        }

        static int GetInput()
        {
            int inptValue = 0;

            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out inptValue);
                }
                catch (Exception e)
                {
                    inptValue = 0;
                }

                if (inptValue > 1000 || inptValue < 1)
                {
                    Console.WriteLine("Invalid input, please enter a number between 1 and 1,000");
                }
                else
                {
                    break;
                }
            }

            return inptValue;
        }

        static int GetIDNumber(string primeString, int inptVal)
        {
            string idString = "";
            inptVal--;

            idString = idString + primeString.Substring(inptVal, 5);

            int.TryParse(idString, out int idInt);
            return idInt;
        }

        static void EndMessage(int idNumber)
        {
            Console.WriteLine("Your ID is: " + idNumber);
            Console.ReadKey();
        }
    }
}
