using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio02
    * Data: 16/05/2023
    */
    public class Exercicio2
    {
        public static void Main(string[] args)
        {
            int numberA = 0, 
            numberB = 0, 
            numberC = 0,
            suporte = 0;
       
            System.Console.Write("Informe o número A: ");
            numberA = int.Parse(Console.ReadLine());
            
            System.Console.Write("Informe o número B: ");
            numberB = int.Parse(Console.ReadLine());
            
            System.Console.Write("Informe o número C: ");
            numberC = int.Parse(Console.ReadLine());

            if(numberC > numberB)
            {
                suporte = numberC;
                numberC = numberB;  
                numberB = suporte;                                  
            }

            if(numberB > numberA)
            {
                suporte = numberB;
                numberB = numberA;
                numberA = suporte;
            }
            
            if(numberC > numberB)
            {
                suporte = numberC;
                numberC = numberB;
                numberB = suporte;
            }

            Console.WriteLine($"Sequencia Crescente é: {numberA} {numberB} {numberC}");
        }
    }
}