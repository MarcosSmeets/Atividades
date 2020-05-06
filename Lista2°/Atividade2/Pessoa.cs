using System;

namespace Atividade2
{
    class Pessoa
    {
        private string nome;
        private DateTime dataDeNascimento;

        private int cpf;

        public string getNome(){
            return this.nome;
        }

        public DateTime getDataDeNascimento(){
            return this.dataDeNascimento;
        }

        public int getCPF(){
            return this.cpf;
        }

        public void setNome(string nome){
            this.nome = nome;
        }

        public void setDataDeNascimento(DateTime data){
            this.dataDeNascimento = data;
        }

        public void setCPF(int cpf){
            this.cpf = cpf;
        }
    }

    class Aluno : Pessoa
    {
        private int matricula;

        public int getMatricula(){
            return this.matricula;
        }

        public void setMatricula(int matricula){
            this.matricula = matricula;
        }

        public void agruparDadosAluno(){
            Console.WriteLine(getNome() + " - " + getDataDeNascimento() + " - " + getCPF() + " - " + getMatricula());
        }    
    }
}