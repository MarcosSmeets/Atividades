using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            Console.WriteLine("Digite o valor: ");
            cal.setV1(float.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o valor: ");
            cal.setV2(float.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a operação: ");
            cal.setOperacao(Console.ReadLine());
            cal.Calcular();
        }
    }
}
