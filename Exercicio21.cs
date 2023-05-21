using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio21
    * Data: 17/05/2023
    */
    public class Exercicio21
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número Inteiro para tabuada: ");
            int number = int.Parse(Console.ReadLine());

            for (int count = 1; count <= number; count++)
            {
                Console.WriteLine($"Tabuada do número {count}: ");

                for (int countTwo = 1; countTwo <= 10; countTwo++)
                {
                    int result = count * countTwo;
                    Console.WriteLine($"{count} x {countTwo} = {result}");
                }

                Console.WriteLine();
            }
        }
    }
}