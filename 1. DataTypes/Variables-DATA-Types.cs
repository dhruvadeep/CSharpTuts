using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;
            Console.WriteLine(isValid);
            //Default: False

            
            // Signed Integral
            // ...............

            sbyte level = 23;
            Console.WriteLine(level);
            //Range: -128 to 127
            //Default: 0

            short value = 623;
            Console.WriteLine(value);
            //Range: -32,768 to 32,767
            //Default: 0

            int score = 712737;
            Console.WriteLine(score);
            //Range: -2^31 to 2^31-1
            //Default: 0

            long range = 812813L;
            Console.WriteLine(range);
            //Range: -2^63 to 2^63-1
            //Default: 0L


            //UnSigned Integrals => x <= 0
            //..................

            byte age = 62;
            Console.WriteLine(age);
            //Range: 0 to 255
            //Default: 0

            ushort value2 = 65535;
            Console.WriteLine(value2);
            //Range: 0 to 65,535
            //Default: 0

            uint totalScore = 81283812;
            Console.WriteLine(totalScore);
            //Range: 0 to 232-1
            //Default: 0

            ulong range2 = 9912399123L;
            Console.WriteLine(range2);
            //Range: 0 to 264-1
            //Default: 0L


            //Floating Integrals => Mainly Decimal Points
            //..................

            float number = 23.23F;
            Console.WriteLine(number);
            //Range: 1.5 × 10^−45 to 3.4 × 10^38
            //Default: 0.0F

            double value3 = 123.232; //d is optional
            Console.WriteLine(value3);
            //Range: 5.0 × 10^−324 to 1.7 × 10^308
            //Default: 0.0 D

            char abc1 = '\u0042';
            char abc2 = 'A';
            Console.WriteLine(abc1); //B
            Console.WriteLine(abc2);
            //Range: U+0000 ('\u0000') to U+FFFF ('\uffff')
            //Default: \0

            decimal bankBalance = 530012.82M;
            Console.WriteLine(bankBalance);
            //Most preciesed and used for highly precised numbers
            //Default: 0.0M
            //Range: (-7.9 x 1028 to 7.9 x 1028) / (100 to 28)

        }
    }
}