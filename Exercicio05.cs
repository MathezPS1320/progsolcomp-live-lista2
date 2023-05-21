using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 127231483
    * Nome do Programa: Exercicio05
    * Data: 16/05/2023
    */
    public class Exercicio05
    {
        public static void Main(string[] args)
        {
            string name = "", surname = "", naturalness = "", startSystem = "";
            int age = 0;
    
            Console.WriteLine("Informe o seus dados para concluir o registro:");

            Console.Write("Digite o seu nome: ");
            name = Console.ReadLine();

            Console.Write("Digite o seu sobrenome: ");
            surname = Console.ReadLine();

            Console.Write("Informe a sua idade: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Informe a sua naturalidade: ");
            naturalness = Console.ReadLine();

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Deseja Vizualizar os Dados Completos ? Digite S para Sim / N para Não");
            startSystem = Console.ReadLine();

            if(startSystem == "S" || startSystem == "s")
            {
                Console.WriteLine("Dados Cadastrados");
                Console.WriteLine($"Nome completo: {name} {surname} | Idade: {age} | Naturalidade: {naturalness}");

            }else if(startSystem == "N" || startSystem == "n")
            {
                Console.WriteLine($" Nome Completo: {name} {surname} | Idade: {age}");
            
            }else
            {
                Console.WriteLine("Digitação errada. Tente Novamente");
            }
        }
    }
}