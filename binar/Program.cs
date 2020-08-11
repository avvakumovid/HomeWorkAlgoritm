using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Algaritm
{

    class Program
    {
        //1. Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.

        static public void binar(int num)
        {
            if (num >= 2)
                binar(num / 2);
            Console.Write(num % 2);
        }
        static void Main(string[] args)
        {


            binar(236);


            Console.ReadKey();
        }
    }



}
