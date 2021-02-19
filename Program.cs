using System;

namespace Methods_Exercise1a
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input for first addition number.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input for second addition number.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}");


            Console.WriteLine("Input for first multiplication number.");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input for second multiplication number.");
            int num4 = int.Parse(Console.ReadLine());

            int multi = Multiply(num3, num4);
            Console.WriteLine($"The answer is {multi}");


            Console.WriteLine("Input for first Division number.");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input for second Division number.");
            int num6 = int.Parse(Console.ReadLine());

            int div = Division(num5, num6);
            Console.WriteLine($"The answer is {div}");


            Console.WriteLine("Input for first Modulus number.");
            int num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input for second Modulus number.");
            int num8 = int.Parse(Console.ReadLine());

            int modul = Modulus(num7, num8);
            Console.WriteLine($"The Modulus is {modul}");


        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num3, int num4)
        {
            return num3 * num4;
        }

        public static int Division(int num5, int num6)
        {
            return num5 / num6;
        }

        public static int Modulus(int num7, int num8)
        {
            return num7 % num8;
        }

    }
}
