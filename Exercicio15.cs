using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio15
    * Data: 17/05/2023
    */
    public class Exercicio15
    {
        public static void Main(string[] args)
        {
            int linesM = 10, columnM = 10;
            int[,] matriz = new int[linesM, columnM];

            for (int line = 0; line < linesM; line++)
            {
                for (int column = 0; column < columnM; column++)
                {
                    matriz[line, column] = 0;
                }
            }
           
            for (int line = 0; line < linesM; line++)
            {
                for (int column = 0; column < columnM; column++)
                {
                    Console.Write($"{matriz[line , column]} ");
                }
                Console.WriteLine();
            }
        }
    }
}