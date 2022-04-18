using System;

namespace _18._04.task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            number = findNumber(number);

            Console.Write("Enter divisor");
            int divided = Convert.ToInt32(Console.ReadLine());
            divided = findNumber(divided);

            Console.WriteLine("result:"+ nearestDividedNumber(number,divided));

        }
        public static int nearestDividedNumber(int number, int divided)
        {
            if (number%divided==0)
            {
                return number;
            }

            int smallDividedNumber = (number / divided) * divided;
            int largeDividedNumber = smallDividedNumber + divided;
            if ((number - smallDividedNumber) > (largeDividedNumber - number))
                return largeDividedNumber;
            else
                return smallDividedNumber;

        }
        public static int findNumber(int number)
        {
            return number;
        }
    }
}
