using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio12
    * Data: 17/05/2023
    */
    public class Exercicio12
    {
        public static void Main(string[] args)
        {
            int number = 0;

            do
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }

                number++;
            } while (number % 7 != 0);
        }
    }
}