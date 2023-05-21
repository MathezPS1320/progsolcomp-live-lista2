 using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio03
    * Data: 16/05/2023
    */
     public class Exercicio03
    {
          public static void Main(string[] args)
          {
            int numberA = 0,
            numberB = 0;
            
            System.Console.Write("Informe um número A: ");
            numberA = int.Parse(Console.ReadLine());

            System.Console.Write("Informe um número B: ");
            numberB = int.Parse(Console.ReadLine());

            if(numberA % numberB == 0)
            {
                Console.Write("São Multiplos");
            }else
            {
                Console.Write("Não São Multiplos");
            }
          }
    }
 }