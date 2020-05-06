using System;

namespace Atividade
{
    class Veiculo : VeiculoCMotor
    {
        private int velocidadeMaxima;

        public void setVelocidadeMaxima(int velocidade)
        {
            this.velocidadeMaxima = velocidade;
        }

        public int getVelocidadeMaxima()
        {
            return this.velocidadeMaxima;
        }
    }

    class VeiculoCMotor 
    {
        private int potenciaMotor_HP;

        public int getPotenciaMotor_HP(){
            return this.potenciaMotor_HP;
        }

        public void setPorenciaMotor_HP(int hp){
            this.potenciaMotor_HP = hp;
        }
    }

    class Carro : Veiculo
    {
        private int numeroDePortas;

        public int getNumeroDePortas(){
            return this.numeroDePortas;
        }

        public void setNumeroDePortas(int portas){
            this.numeroDePortas = portas;
        }

        public void Nova(int portas, int hp, int velocidade){
            setNumeroDePortas(portas);
            setPorenciaMotor_HP(hp);
            setVelocidadeMaxima(velocidade);
        }

        public void Mostrar(){
            Console.WriteLine("Carro: " + getNumeroDePortas() + " portas " + getPotenciaMotor_HP() + " HP " + "VM: " + getVelocidadeMaxima() + " HM/h" );
        }
    }

    class Lancha : Veiculo
    {
        private int comprimentoPes;

        public int getComprimetoPes(){
            return this.comprimentoPes;
        }
        
        public void setComprimentoPes(int pes){
            this.comprimentoPes = pes;
        }

        public void Nova(int pes, int hp, int velocidade){
            setComprimentoPes(pes);
            setVelocidadeMaxima(velocidade);
            setPorenciaMotor_HP(hp);
        }

        public void Mostrar(){
            Console.WriteLine("Lancha: " + getComprimetoPes() + " pes " + getPotenciaMotor_HP() + " HP " + "VM: " + getVelocidadeMaxima() + " HM/h" );
        }
        
    }

    class Bicicleta : Veiculo
    {
        private int raioDoAro;
        public int getRaioDoAro()
        {
            return this.raioDoAro;
        }

        public void setRaioDoAro(int aro)
        {
            this.raioDoAro = aro;
        }

        public void Nova(int aro, int velocidade)
        {
            setRaioDoAro(aro);
            setVelocidadeMaxima(velocidade);
        }

        public void Mostrar()
        {
            Console.WriteLine("Bike aro: " + getRaioDoAro() + " VM: " + getVelocidadeMaxima() + " KM/h");
        } 
    }

}