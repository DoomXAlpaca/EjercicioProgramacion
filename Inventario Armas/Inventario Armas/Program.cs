using System;

namespace Inventario_Armas
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice;
            Arma Espada = new Espada(10, 2, 50, "Espada de Hierro");
            Arma Hacha = new Hacha(30, 1, 70, "Hacha de Oro");
            Arma Arco = new Arco(8, 1, 50, "Arco Corto" , 0);
            Arma Pistola = new Pistola(15, 3, 100, "Revolver" , 0);
            Console.WriteLine("¿Qué quiere comprar?");
            Console.WriteLine("1.- Espada");
            Console.WriteLine("2.- Arco");
            Console.WriteLine("3.- Pistola");
            Console.WriteLine("4.- Flecha");
            Console.WriteLine("5.- Bala");
            Console.WriteLine("5.- Hacha");

            indice = Convert.ToInt32(Console.ReadLine());


            //void AgregarArma(List<Arma> inventario)
            //{
            //    Console.WriteLine("¿Qué tipo de arma desea agregar?");
            //    Console.WriteLine("1. Arma de cuerpo a cuerpo");
            //    Console.WriteLine("2. Arma a distancia")
                    
            //}
            switch (indice)
            {
                case 1:
                    Console.WriteLine("Estas son las caracteristicas de la espada");
                    Console.WriteLine(Espada.dmg);
                    Console.WriteLine(Espada.aVelocidad);
                    Console,writeLine(Espada.precio);

                    break;
                case 2:
                    
                     break; 
                  case 3 ;
                    break;
                    
                case 4 ;
                    break;

                    case 5 ;
                    Console.WriteLine("Estas son las caracteristicas de la Hacha");
                    Console.WriteLine(Hacha.nombre);
                    Console.WriteLine(Hacha.dmg);
                    Console.WriteLine(Hacha.aVelocidad);
                    Console,writeLine(Hacha.precio);
                    break;



            }
        }
    }
}
