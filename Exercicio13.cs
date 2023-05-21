using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio13
    * Data: 17/05/2023
    */
    public class Exercicio13
    {
        public static void Main(string[] args)
        {
            int number = 1,
            sum = 0;

            while (number <= 100)
            {
                sum += number;
                number++;
            }

            Console.WriteLine($"A soma dos números de vão de 1 a 100 é: {sum}");
        }
    }
}
