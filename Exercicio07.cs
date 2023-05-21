using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio07
    * Data: 16/05/2023
    */
    public class Exercicio07
    {
        public static void Main(string[] args)
        {
            int qtdDay = 0;
            double taxService = 0.0,
             valueHosp = 60.00, 
             totalValue = 0.0;
             
            Console.WriteLine("Digite a quantidade de dias da hospedagem");
            qtdDay = int.Parse(Console.ReadLine());

            if(qtdDay > 15)
            {
                taxService = 5.50;

            }else if(qtdDay  == 15)
            {
                taxService = 6.0;

            }else if(totalValue < 15)
            {
                taxService = 8.0;
            }

            totalValue =  taxService + (qtdDay * valueHosp);

            Console.WriteLine($"Valor da Cobrança total da ghospedagem: R$ {totalValue.ToString("F2")}");
        }
    }
}