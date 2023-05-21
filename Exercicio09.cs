using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio09
    * Data: 16/05/2023
    */
    public class Exercicio09
    {
        public static void Main(string[] args)
        {
            int option = 0;
            double total = 0,
            valueSales;

            Console.Write("Informe o valor total da Venda: R$ ");
            valueSales = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a condição de pagamento:");
            Console.WriteLine("1 - Venda à vista");
            Console.WriteLine("2 - Venda a prazo 30 dias");
            Console.WriteLine("3 - Venda a prazo 60 dias");
            Console.WriteLine("4 - Venda a prazo 90 dias");
            Console.WriteLine("5 - Venda com cartão de débito");
            Console.WriteLine("6 - Venda com cartão de crédito");

            Console.Write("Informe a opção de Pagamento: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    total = valueSales - (valueSales * 0.1); 
                    break;
                case 2:
                    total = valueSales - (valueSales * 0.05); 
                    break;
                case 3:
                    total = valueSales; 
                    break;
                case 4:
                    total = valueSales + (valueSales * 0.05); 
                    break;
                case 5:
                    total = valueSales - (valueSales * 0.08); 
                    break;
                case 6:
                    total = valueSales - (valueSales * 0.07); 
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    return;
            }

            Console.WriteLine($"Total da venda: R${total.ToString("F2")}");
        }
    }
}