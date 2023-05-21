using System;

namespace logicadeprogramacao
{   
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio01
    * Data: 16/05/2023
    */
    
    public class Exercicio01
    {
        public static void Main(string[] args)
        {        
        int numberA = 0, 
        numberB = 0;
        Console.WriteLine("Informe um número A");
        numberA = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe um número B");
        numberB = int.Parse(Console.ReadLine());

        string result = (numberA > numberB) ?  "O número A é maior" : "O número B é maior";
        Console.WriteLine(result);                       
        }
    }
}