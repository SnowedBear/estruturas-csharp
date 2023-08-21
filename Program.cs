using System;

namespace EstruturasCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Console.WriteLine("Estou pensando em um numero de 1 a 10, qual numero é esse?");
             int numeroAleatorio = rnd.Next(1, 11);
            
            while (true)
            {
               int resposta;
                resposta = int.Parse(Console.ReadLine());

                if(resposta == numeroAleatorio)
                {
                    Console.WriteLine("Parabens! era o numero " + numeroAleatorio);
                    break;
                }
                else if (resposta != numeroAleatorio)
                {
                    Console.WriteLine("Errou! Tente denovo!");
                }
            }
        }
    }
}