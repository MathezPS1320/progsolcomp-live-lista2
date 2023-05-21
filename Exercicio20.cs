using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio20
    * Data: 17/05/2023
    */
    public class Exercicio20
    {
        public static void Main(string[] args)
        {
            int cargAt = 0, peapleAt = 0, maxCarg = 0, qtdPleaple = 0;
            
            Console.Write("Informe a quantidade de carga máxima para o elevador: ");
            maxCarg = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade máxima de pessoas: ");
            qtdPleaple = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite o peso da pessoa em kg: ");
                int peso = int.Parse(Console.ReadLine());

                cargAt += peso;
                peapleAt++;

            }while (cargAt < maxCarg && peapleAt < qtdPleaple);

            Console.WriteLine($"Carga atual:{cargAt} kg Número de pessoas:{peapleAt}");
            Console.WriteLine("Limite de carga ou pessoa excedido!");
          
        }
    }
}