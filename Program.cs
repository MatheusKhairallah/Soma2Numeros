using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculos básicos com 27 e 10");
            int X=27;
            int Y=10;
            int soma=X + Y;
            int menos=X - Y;
            int multi=X * Y;
            int divisao=X / Y;
            Console.WriteLine($"{X} + {Y} = {soma}");
            Console.WriteLine($"{X} - {Y} = {menos}");
            Console.WriteLine($"{X} * {Y} = {multi}");
            Console.WriteLine($"{X} / {Y} = {divisao}");


        }
    }
}
