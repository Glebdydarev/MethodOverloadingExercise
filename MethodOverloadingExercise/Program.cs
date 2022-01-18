using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        public static int Add(int num1, int num2)

        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2, bool v)

        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (true && sum > 1 || sum < 1)

              { 
                return $"{sum} dollars";

            }
            else if (true && sum == 1)



            {
                return $"{sum} dollar";
            }

            else

            {

                return sum.ToString();
            } 
       }

        static void Main(string[] args)
        {

            //var my Bool = long.Tryparse(Console.ReadLine(), out var result);

            //var myAge = 25

            // print(myAge);

            //Console.WriteLIne();

            //Math.Old(myAge);
            // Console.WriteLine(Add(10, 15));

            // Console.WriteLine(Add(4.5m, 14.5m));


            Console.WriteLine();

            Console.WriteLine(Add(0, 0, true));
            Console.WriteLine();


            Console.WriteLine(Add(5, 2, true));
            Console.WriteLine();


            Console.WriteLine(Add(-5, 6, true));
            Console.WriteLine();


            Console.WriteLine(Add(8, 8, false));
            Console.WriteLine();


        }
    }
} 
