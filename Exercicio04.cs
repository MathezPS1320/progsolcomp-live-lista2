using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio04
    * Data: 16/05/2023
    */
    public class Exercicio04
    {
        public static void Main(string[] args)
        {
            int numberA = 0;
            string result ="";

            System.Console.WriteLine("Informe um número");
            numberA = int.Parse(Console.ReadLine());
        
           
            if(numberA % 2 == 0)
            {
                result = (numberA > 0)? "Este número é um PAR positivo":"Este Número é um PAR negativo"; 

            }else if(numberA % 2 != 0)
            {
                result = (numberA > 0) ? "Este número é um Ímpar positivo":"Este número é um Ímpar negativo";
            }
            
            Console.WriteLine($"Resultado: {result}");
        }
    }
}