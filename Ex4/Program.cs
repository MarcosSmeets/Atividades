using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado fun = new Empregado();
            Console.WriteLine("Digite o Nome: ");
            fun.setNome(Console.ReadLine());
             Console.WriteLine("Digite o Departamento: ");
            fun.setDp(Console.ReadLine());
             Console.WriteLine("Digite a quantidade de Horas: ");
            fun.setHorasTrabalhadasNoMes(int.Parse(Console.ReadLine()));
             Console.WriteLine("Digite o Salario/H: ");
            fun.setSalarioPorHora(float.Parse(Console.ReadLine()));
            fun.Mostrar();
        }
    }
}
