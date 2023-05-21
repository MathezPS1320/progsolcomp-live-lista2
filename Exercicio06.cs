using  System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio06
    * Data: 16/05/2023
    */
    public class  Exercicio06
    {
        public static void Main(string[] args)
        {

            string result = "";

            Console.WriteLine("Digite a sua nota final: ");
            int grade = int.Parse(Console.ReadLine());
            
            if(grade >= 0 && grade <= 49 )
            {
                result = "Insuficiente";

            }else if(grade >= 50 && grade <= 64)
            {
                result = "Regular";
            
            }else if(grade >= 65 && grade <= 84 )
            {
                result = "Bom";
            
            }else if (grade >= 85 && grade <= 100)
            {
                result = "Ótima";
            }

            Console.WriteLine($"Nota Conceito: {result}");
        
        }
    }
}