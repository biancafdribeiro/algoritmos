/*4)  Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade
dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a parte de anos da sua idade (exemplo: 20 anos, digite 20)");
        int ano = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a parte de meses da sua idade (exemplo: 20 anos e 2 meses, digite 2):");
        int mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a parte de dias da sua idade (exemplo: 20 anos, 2 meses e 15 dias, digite 15):");
        int dia = int.Parse(Console.ReadLine());

        int idadeconvertida = (ano * 365) + (mes * 30) + dia;
        Console.WriteLine("A idade convertida em dias é: " + idadeconvertida);
    }
}

