using System;

namespace TorreHanoi
{
    class Program
    {
        private static void Mover(int origem, int destino)
        {
            Console.WriteLine("Move: origem "+ origem +" para: "+ destino);
        }

        public static void Hanoi(int disco, int origem, int destino, int trabalho)
        {
            if(disco > 0)
            {
                Hanoi(disco - 1, origem, trabalho,destino);
                Mover(origem, destino);
                Hanoi(disco - 1, trabalho, destino, origem);
            }
        }

        static void Main(string[] args)
        {
            Hanoi(3, 1, 3, 2);
            //3 discos, 1 = origem, 3 = destino, 2 = trabalho
        }
    }
}
