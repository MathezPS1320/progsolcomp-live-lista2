using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio11
    * Data: 16/05/2023
    */
    public class Exercicio11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Números pares de 1 a 100 (ordem inversa):");

            for (int count = 100; count >= 1; count--)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count);
                }
            }
        }
    }
}