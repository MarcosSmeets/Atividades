using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            Console.WriteLine("Digite um valor: ");
            cal.setV1(float.Parse(Console.ReadLine()));
            Console.WriteLine("Digite um valor: ");
            cal.setV2(float.Parse(Console.ReadLine()));

            cal.Mostrar();
        }
    }
}
