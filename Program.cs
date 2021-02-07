using System;

namespace Fibonachi
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Input quantity steps");
            byte stepsQuantity = byte.Parse(Console.ReadLine());
            int fist = 0, second = 1, result=0,n=0;
            while (n < 10)
            {
                result = fist + second;
                fist = second;
                second = result;
                n++;
                Console.WriteLine(result);
            }


        }
    }
}
