using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //afisam par sau impar in functie de numar
            int a;
            Console.WriteLine("Introduceti un numar: ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("par");
            else Console.WriteLine("impar");
        }
    }
}
