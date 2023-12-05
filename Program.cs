using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Faça um programa que mostre se um elevador pode entrar em funcionamento ou não.
 Primeiro, o programa deve solicitar o peso máximo, em Kg, suportado pelo elevador e o
 número de pessoas que desejam utilizá-lo. Depois, solicitar o peso de cada pessoa e, no
 final, exibir se o elevador poderá entrar em funcionamento ou não. Caso a soma dos pesos
 das pessoas for maior que o peso máximo suportado pelo elevador, ele não poderá entrar
 em funcionamento.
 */



namespace elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool conseguiuConverter = false;
            double pesoMaximo = 0, somaPesoTotal = 0;


            Console.WriteLine("-----ELEVADOR-----");

            do
            {

                Console.Write("Insira o peso(Kg) limte para o elevador:");
                conseguiuConverter = double.TryParse(Console.ReadLine(), out pesoMaximo);
            } while (!conseguiuConverter || pesoMaximo <= 0);

            int pessoas = 0;

            do
            {
                Console.Write("Quantas pessoas vão entrar?:");
                pessoas = int.Parse(Console.ReadLine());
            } while (!conseguiuConverter || pessoas <= 0);


            for (int i = 1; i <= pessoas; i++)
            {
                Console.Write("Digite o peso:");
                double peso = double.Parse(Console.ReadLine());

                somaPesoTotal += peso;
            }

            Console.WriteLine($"O peso máximo suportado pelo elevador:{pesoMaximo}");
            Console.WriteLine($"O peso total das pessoas{somaPesoTotal}");

            if (somaPesoTotal >= pesoMaximo)
                Console.WriteLine($"O peso foi ultrapassado!");
            else
            Console.WriteLine("O elevador está em funcionamento!!!");
            




            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
