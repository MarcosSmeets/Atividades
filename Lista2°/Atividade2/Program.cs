using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno ana = new Aluno();
            ana.setNome("Ana Souza");
            ana.setDataDeNascimento(new DateTime(1976, 12, 01));
            ana.setCPF(456788998);
            ana.setMatricula(1234);
            ana.agruparDadosAluno();

            Aluno bruno = new Aluno();
            bruno.setNome("Bruno Luiz");
            bruno.setDataDeNascimento(new DateTime(1992, 09, 24));
            bruno.setCPF(765098453);
            bruno.setMatricula(1456);
            bruno.agruparDadosAluno();

            Aluno carlos = new Aluno();
            carlos.setNome("Carlos Filho");
            carlos.setDataDeNascimento(new DateTime(1982, 02, 15));
            carlos.setCPF(753456098);
            carlos.setMatricula(1654);
            carlos.agruparDadosAluno();
        }
    }
}
