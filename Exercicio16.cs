using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio16
    * Data: 17/05/2023
    */
    public class Exercicio16
    {
        public static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Para sair do Sistema digite um número menor que Zero ( 0 ): ");
                number = int.Parse(Console.ReadLine());

            } while (number >= 0);
        }
    }
}