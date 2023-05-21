using System;

namespace logicadeprogramacao
{
    /* Nome do Aluno: Matheus Porciúncula
    * RA: 1272314837
    * Nome do Programa: Exercicio08
    * Data: 16/05/2023
    */
    public class Exercicio08
    {
            public static void Main(string[] args)
            {

                string nameMonth = "", station = "";

                Console.WriteLine("Informe o número de 1 a 12 para saber o mês correspondente: ");
                int numberMonth = int.Parse(Console.ReadLine());

                switch (numberMonth)
                {
                    case 1:
                        nameMonth = "Janeiro";
                        station = "Verão";
                        break;
                    case 2:
                        nameMonth = "Fevereiro";
                        station = "Verão";
                        break;
                    case 3:
                        nameMonth = "Março";
                        station = "Outono";
                        break;
                    case 4:
                        nameMonth = "Abril";
                        station = "Outono";
                        break;
                    case 5:
                        nameMonth = "Maio";
                        station = "Outono";
                        break;
                    case 6:
                        nameMonth = "Junho";
                        station = "Inverno";
                        break;
                    case 7:
                        nameMonth = "Julho";
                        station = "Inverno";
                        break;
                    case 8:
                        nameMonth = "Agosto";
                        station = "Inverno";
                        break;
                    case 9:
                        nameMonth = "Setembro";
                        station = "Primavera";
                        break;
                    case 10:
                        nameMonth = "Outubro";
                        station = "Primavera";
                        break;
                    case 11:
                        nameMonth = "Novembro";
                        station = "Primavera";
                        break;
                    case 12:
                        nameMonth = "Dezembro";
                        station = "Verão";
                        break;
                    default:
                        nameMonth = "Mês inválido";
                        break;
            }

            Console.WriteLine($"Nome do Mês: {nameMonth} Estação do Mês: {station}");
        }
    }
}