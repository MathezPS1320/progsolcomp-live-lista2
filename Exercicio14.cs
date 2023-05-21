using System;

namespace LogicaDeProgramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio14
    * Data: 17/05/2023
    */
    public class Exercicio14
    {
        public static void Main(string[] args)
        {           
            int[] vectorTwo = new int[50];

            for (int count = 0; count < vectorTwo.Length; count++)
            {
                vectorTwo[count] = 0;
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Todos os zeros inseridos no vetor:");

            for (int count = 0; count < vectorTwo.Length; count++)
            {
                Console.Write($"{vectorTwo[count]} \n");
            }
        }
    }
}