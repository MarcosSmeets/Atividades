using System;

namespace Ex2
{
    class Calculadora
    {
        private float v1;
        private float v2;

        public float getV1(){
            return this.v1;
        }

        public void setV1(float valor){
            this.v1 = valor;
        }

        public float getV2(){
            return this.v2;
        }

        public void setV2(float valor){
            this.v2 = valor;
        }

        public void Soma(){
           float soma = v1 + v2;
           Console.WriteLine("Soma: " + soma);
        }

        public void Sub(){
            float sub = v1 - v2;
            Console.WriteLine("Subtração: " + sub);
        }

        public void Mult(){
            float mult = v1 * v2;
            Console.WriteLine("Muiltiplicação: " + mult);
        }

        public void Div(){
            float div = v1/v2;
            Console.WriteLine("Divisão: " + div);
        }

        public void Mostrar(){
            Soma();
            Sub();
            Mult();
            Div();
        }
    }
}