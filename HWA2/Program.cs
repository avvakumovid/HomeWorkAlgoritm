using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 2. Реализовать функцию возведения числа a в степень b:
a. Без рекурсии.
b. Рекурсивно.
c. *Рекурсивно, используя свойство чётности степени
*/



namespace exponentiation
{
    
    class Program
    {
        // a. Без рекурсии.
        static public int exponentiationA(int num, int deg)
        {
            
            int a = num;
            for (int i = 1; i < deg; i++)
            {
                num *= a;
            }
            return num;
        }
        

        //b. Рекурсивно.
        static public int exponentiationB(int num, int deg)
        {
            if(deg == 1)
            {
                return num;
            }
            else
            {
                return num *= exponentiationB(num, deg - 1);
            }
        }

        // c. *Рекурсивно, используя свойство чётности степени
        static public int exponentiationC(int num, int deg)
        {
            if (deg == 1)
            {
                return num;
            }
            else
            {
                return exponentiationB(num, deg / 2) * exponentiationB(num, deg / 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(exponentiationA(2, 4));
            Console.WriteLine(exponentiationB(2, 4));
            Console.WriteLine(exponentiationC(2, 4));
            Console.ReadKey();
            
        }
    }
}
