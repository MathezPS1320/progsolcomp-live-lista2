using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio10
    * Data: 16/05/2023
    */
    public class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Todos os números pares 1 a 100: ");

            for (int count = 1; count <= 100; count++)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count);
                }
            }
        }
    }
}