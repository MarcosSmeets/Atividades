using System;

namespace Ex5
{
    class Retangulo
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;

        private int xp;
        
        private int yp;

        public int getX1(){
            return this.x1;
        }

        public int getX2(){
            return this.y1;
        }

        public int getY1(){
            return this.x2;
        }

        public int getY2(){
            return this.y2;
        }

        public int getXP(){
            return this.xp;
        }

        public int getYP(){
            return this.yp;
        }

        public void setX1(int x){
            this.x1 = x;
        }

        public void setY1(int y){
            this.y1 = y;
        }

        public void setX2(int x){
            this.x2 = x;
        }

        public void setY2(int y){
            this.y2 = y;
        }

        public void setYP(int y){
            this.yp = y;
        }

        public void setXP(int x){
            this.xp = x;
        }

        public void Base(){
            int Base = x2+y2;
            Console.WriteLine("Base: " + Base);
        }

        public void Altura(){
            int altura = x1+y1;
            Console.WriteLine("Alture:" + altura);
        }

        public void Area(){
            int area = (x2+y2)*(x1+y1);
            Console.WriteLine("Area: " + area);
        }

        public void Ponto(){
            if(xp < (x1+x2) && yp < (y1+y2)){
                Console.WriteLine("Ponto Y e X dentro do retangulo");
            }
            else if(yp < (y1+y2)){
                Console.WriteLine("Ponto Y dentro do retangulo");
            }
            else if(xp < (x1+x2)){
                Console.WriteLine("Ponto X dentro do retangulo");
            }
            else{
                Console.WriteLine("Ponto Y fora do retangulo");
            }
        }

        public void Mostrar(){
            Base();
            Altura();
            Area();
            Ponto();
        }
    }
}