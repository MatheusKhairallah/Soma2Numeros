using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva um número:");
            double numero1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Escreva outro número:");
            double numero2=Convert.ToDouble(Console.ReadLine());
            double resultado=numero1 + numero2;
            Console.Clear();
            Console.WriteLine($"Resultado da soma dos dois números digítados: {resultado}");
            
             


            


        }
    }
}
