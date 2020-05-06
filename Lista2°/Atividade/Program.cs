using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicicleta bike_29 = new Bicicleta();
            bike_29.Nova(29, 45);
            bike_29.Mostrar(); 

            Bicicleta bike_26 = new Bicicleta();
            bike_26.Nova(26, 35);
            bike_26.Mostrar(); 

            Bicicleta bike_20 = new Bicicleta();
            bike_20.Nova(20, 20);
            bike_20.Mostrar(); 

            Lancha lancha_16 = new Lancha();
            lancha_16.Nova(16, 90, 80);
            lancha_16.Mostrar();

            Lancha lancha_21 = new Lancha();
            lancha_21.Nova(21, 150, 120);
            lancha_21.Mostrar();

            Lancha lancha_30 = new Lancha();
            lancha_30.Nova(30, 250, 270);
            lancha_30.Mostrar();

            Carro carro_4 = new Carro();
            carro_4.Nova(4, 100, 210);
            carro_4.Mostrar();

            Carro carro_2 = new Carro();
            carro_2.Nova(2, 130, 270);
            carro_2.Mostrar();

            Carro carro_22 = new Carro();
            carro_22.Nova(2, 190, 350);
            carro_22.Mostrar();
        }
    }
}


//bicicleta aro 29 VM = 45KM/h
//aro 26 VM = 35KM/h
//aro 20 VM = 20KM/h
//16 pes 90hp VM = 80KM/h
//21 pes 150hp VM = 120KM/h
//30 pes 250hp VM = 270KM/h
//4 portas 100hp VM = 210Km/h
//2 portas 130hp VM = 270KM/h
//2 portas 190hp VM = 350Km/h