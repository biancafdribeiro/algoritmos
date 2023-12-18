/*3)  Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a
área do retângulo. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor para a base:");
        int @base = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para a altura:");
        int altura = int.Parse(Console.ReadLine());

        int area = @base * altura;
        Console.WriteLine("O valor da área do retângulo é: " + area);
    }
}

