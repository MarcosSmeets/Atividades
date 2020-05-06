using System;

namespace Ex4
{
    class Empregado
    {
        private string nome;
        private string departamento;
        private int horasTrabalhadasNoMes;
        private float salarioPorHora;

        public int getHorasTrabalhadasNoMes(){
            return this.horasTrabalhadasNoMes;
        }

        public float getSalarioPorHora(){
            return this.salarioPorHora;
        }

        public string getNome(){
            return this.nome;
        }

        public string getDp(){
            return this.departamento;
        }

        public void setHorasTrabalhadasNoMes(int horas){
            this.horasTrabalhadasNoMes = horas;
        }

        public void setSalarioPorHora(float salarioPorHora){
            this.salarioPorHora = salarioPorHora;
        }

        public void setNome(string nome){
            this.nome = nome;
        }

        public void setDp(string dp){
            this.departamento = dp;
        }

        public void mostrarDados(){
            Console.WriteLine("Nome: " + getNome());
            Console.WriteLine("Departamento: " + getDp());
        }

        public void calcularSalario(){
            float salarioDoMes = (salarioPorHora * horasTrabalhadasNoMes);
            Console.WriteLine("Salario Mensal: " + salarioDoMes);
        }

        public void Mostrar(){
            mostrarDados();
            calcularSalario();
        }
    }
}