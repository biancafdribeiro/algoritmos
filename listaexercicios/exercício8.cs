/*8)  Faça um algoritmo que leia três notas de um aluno, calcule e escreva a média final deste aluno.
Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5.
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

        Console.WriteLine("Digite a terceira nota:");
        double nota3 = double.Parse(Console.ReadLine());

        double mediafinal = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5))/10;
        Console.WriteLine("Sua nota final é:" + mediafinal);
    }
}

