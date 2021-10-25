using System;

namespace brah
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(0, 10);

            char again = 'y';

            while (again == 'y')
            {
                int i = rand.Next(10);

                Console.WriteLine("Программа задала число");

                int b = Convert.ToInt32(Console.ReadLine());

                if (a == b) Console.WriteLine("Угадал");
                if (a > b) Console.WriteLine("Мало");
                if (a < b) Console.WriteLine("Много");

                Console.WriteLine("впишите число ещё раз");
                again = Convert.ToChar(Console.ReadLine());

            }


        }
    }
}
