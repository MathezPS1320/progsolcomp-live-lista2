using System;

 namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio18
    * Data: 17/05/2023
    */
     public class Exercicio18
    {
       public static void Main(string[] args)
       {
            Console.Write("Digite um número para verificar o fatorial: ");

            int number = 0 , factorial;

            number = int.Parse(Console.ReadLine());
            factorial = 1;

            for (int count = 1; count <= number; count++)
            {
                factorial *= count;
            }

            Console.WriteLine($"O fatorial de {number} é {factorial}");
      }
   }
}