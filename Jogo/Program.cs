using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            //HELLO WORLD!

            Console.WriteLine("JOGO");
            Console.WriteLine();

            int cont = 0, vitoria = 0, derrota = 0;
            string resposta = "sim";                     

            while (resposta == "sim")
            {
                int x, y;

                Random r = new Random();

                x = r.Next(1, 6);

                Console.WriteLine("Digite um número e 1 a 6");
                Console.WriteLine();
                y = Int32.Parse(Console.ReadLine());
                                
                if (y == x)
                {
                    Console.WriteLine();
                    Console.WriteLine("Parabéns você venceu!");
                    vitoria++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Você perdeu!");
                    derrota++;
                }

                cont++;

                Console.WriteLine();
                Console.WriteLine("Deseja continuar jogando?");
                resposta = Console.ReadLine();
                Console.Clear();                               
            }
            Console.WriteLine("Vitórias = " + vitoria);
            Console.WriteLine();
            Console.WriteLine("Derrotas = " + derrota);
            Console.WriteLine();
            Console.WriteLine("Quantidade de vezes jogadas = " + cont);
            Console.ReadLine();
        }
    }
}
