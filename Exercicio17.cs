using System;

namespace LogicaDeProgramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio17
    * Data: 17/05/2023
    */
    public class Exercicio17
    {
        public static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                number--;

                if (number < -1000)
                {
                    if (number % 7 == 0)
                    {
                        Console.WriteLine(number);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}