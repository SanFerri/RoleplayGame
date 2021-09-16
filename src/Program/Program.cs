using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            Player1 = Game.Start();
            while(Player1.health && Player2.health > 0)
            {
                contador++;
                Console.WriteLine($"Turno {contador} \n");   
            }
        }
    }
}
