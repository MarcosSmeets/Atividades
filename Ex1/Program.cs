using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            Console.WriteLine("Digite o Dia: ");
            data.setDia(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o Mês: ");
            data.setMes(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o Ano: ");
            data.setAno(int.Parse(Console.ReadLine()));
            data.Mostrar();
        }
    }
}
