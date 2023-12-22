/*11) As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem
compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e
escreva o custo total da compra. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a quantidade de maçãs compradas:");
        int quantidademaca = int.Parse(Console.ReadLine());

        if (quantidademaca < 12) {
            double valormaca = quantidademaca * 1.30;
            Console.WriteLine("O custo da sua compra é: " + valormaca);
        }
        else {
            double valormaca = quantidademaca * 1.00;
            Console.WriteLine("O custo da sua compra é: " + valormaca);
        }
    }
}

