using System;

namespace Inventario_Armas
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice;
            Arma Espada = new Espada(10, 2, 50, "Espada de Hierro");
            Arma Hacha = new Hacha(30, 1, 70, "Hacha de Hierro");
            Arma Arco = new Arco(8, 1, 50, "Arco Corto");
            Arma Pistola = new Pistola(15, 3, 100, "Revolver");
            Console.WriteLine("¿Qué deseas comprar?");
            Console.WriteLine("1.- Espada");
            Console.WriteLine("2.- Arco");
            Console.WriteLine("3.- Pistola");
            Console.WriteLine("4.- Flecha");
            Console.WriteLine("5.- Bala");
            Console.WriteLine("5.- Hacha");

            indice = Convert.ToInt32(Console.ReadLine());
            switch(indice)
            {
                case 1:
                    Console.WriteLine("");
                     break;
            }
        }
    }
}
