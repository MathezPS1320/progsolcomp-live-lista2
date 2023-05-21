using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio19
    * Data: 17/05/2023
    */
    public class Exercicio19
    {
        public static void Main(string[] args)
        {
            int initialvolume = 0,
            time;

            Console.Write("Digite o volume inicial em centímetros cúbicos: ");
            initialvolume = int.Parse(Console.ReadLine());
            time = 0;

            while (initialvolume <= 1000)
            {
                initialvolume *= 2;
                time++;
            }

            Console.WriteLine($"Tempo de ultrapassagem para 1000 é de  {time} segundos");
        }
    }
}