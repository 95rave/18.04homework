using System;

namespace _18._04homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            number = Choose (number);

            Console.Write("Please enter a number to be written first: ");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            newNumber = Choose (newNumber);

            Console.WriteLine("result" + turnNumberToNewNumber(number,newNumber));
        }
       
        public static int turnNumberToNewNumber(int number, int newNumber)
        {
            int count = 0;
            int Number = number;
            while(number>0)
            {
                number = number / 10;
                count++;
            }
            number = 1;
            for (int i = 0; i < count; i++)

            {
                number *= 10;
            }
            Number += newNumber * number;
            return Number;
        }
        public static int Choose(int newNumber)
        {
           return newNumber;
        }

    }
}
