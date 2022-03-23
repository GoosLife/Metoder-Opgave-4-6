using System;

namespace MetoderLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int userNumber;

            #region Exercise 4

            Console.WriteLine("I will now count to 10: \n");
            CountToTen();

            #endregion

            #region Exercise 5

            Console.WriteLine("\nI will now count back down to 1: \n");
            CountFromTen();

            #endregion

            #region Exercise 6

            Console.WriteLine("\nEnter a number: \n");
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out userNumber));

            CountFromNumber(userNumber);

            #endregion
        }

        private static void CountToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void CountFromTen()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void CountFromNumber(int num)
        {
            for (int i = 0; i < 32; i++)
            {
                num++;
                Console.WriteLine(num);
            }

            for (int i = 0; i < 16; i++)
            {
                num--;
                Console.WriteLine(num);
            }
        }
    }
}