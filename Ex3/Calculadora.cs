using System;

namespace Ex3
{
    class Calculadora
    {
        private float v1;
        private float v2;

        private string operacao;

        public float getV1(){
            return this.v1;
        }

        public float getV2(){
            return this.v2;
        }

        public string getOperacao(){
            return this.operacao;
        }

        public void  setV1(float valor){
            this.v1 = valor;
        }

        public void  setV2(float valor){
            this.v2 = valor;
        }

        public void  setOperacao(string operacao){
            this.operacao = operacao;
        }

        public void Calcular(){
            if (operacao == "+"){
                float soma = v1 + v2;
                Console.WriteLine("Soma: " + soma);
            }
            else if (operacao == "-"){
                float sub = v1 + v2;
                Console.WriteLine("Sub: " + sub);
            }
            else if (operacao == "*"){
                float mult = v1 * v2;
                Console.WriteLine("Mult: " + mult);
            }
            else if (operacao == "/"){
                float div = v1 / v2;
                Console.WriteLine("Div: " + div);
            }
        }
    }
}