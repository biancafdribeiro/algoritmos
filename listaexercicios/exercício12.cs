/*12) Ler as notas da 1a. e 2a. avaliações de um aluno. Calcular a média aritmética simples e escrever
uma mensagem que diga se o aluno foi ou não aprovado (considerar que nota igual ou maior que 6 o
aluno é aprovado). Escrever também a média calculada. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a primeira nota:");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        double nota2 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2)/2; 

        if (media >= 6) {
            Console.WriteLine("Aluno aprovado!");
            Console.WriteLine("A sua média é: " + media);
        }
        else {
            Console.WriteLine("Aluno reprovado!");
            Console.WriteLine("A sua média é: " + media);
        }
    }
}

