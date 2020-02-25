using System;

namespace CalculoEmArroba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o peso em KG a ser convertido em arroba: ");
            int valor = int.Parse(Console.ReadLine());

            int valorConvertido = valor / 30;

            Console.WriteLine("O valor convertido em arroba é:" + valorConvertido);
        }
    }
}
