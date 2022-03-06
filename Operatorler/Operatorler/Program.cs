using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

          
            int number2 = 95;

            number2 = number2 + 10;
            Console.WriteLine(number2);
            number2 += 2;
            Console.WriteLine(number2);
            number2 /= 5;
            Console.WriteLine(number2);

            bool Success = true;
            bool Completed = false;
            Console.WriteLine("------------------------------------");

            if (Success && Completed)
            {
                Console.WriteLine("Harika");
            }
            Console.WriteLine("------------------------------------");

            if (Success || Completed)
            {
                Console.WriteLine("İyi");
            }
            Console.WriteLine("------------------------------------");

            if (Success && !Completed)
            {
                Console.WriteLine("Eh işte");
            }
            Console.WriteLine("------------------------------------");

            int a = 6;
            int x = 18;
            bool result = a > x;
            Console.WriteLine(result);

            Console.WriteLine("------------------------------------");

            result = a < x;
            Console.WriteLine(result);

            Console.WriteLine("------------------------------------");
            result = a == x;
            Console.WriteLine(result);
            Console.WriteLine("------------------------------------");
            result = a != x;
            Console.WriteLine(result);

            Console.WriteLine("------------------------------------");

            int n1 = 50;
            int n2 = 100;
            int rslt = n2 / n1;
            Console.WriteLine(rslt);
            Console.WriteLine("------------------------------------");

            rslt = n1 + n2;
            Console.WriteLine(rslt);
            Console.WriteLine("------------------------------------");

            rslt = n2 - n1;
            Console.WriteLine(rslt);
            Console.WriteLine("------------------------------------");

            rslt = n1++;
            Console.WriteLine(rslt);
            Console.WriteLine("------------------------------------");

            int sonuc = 80 % 3;
            Console.WriteLine(sonuc);
        
        }
    }
}
