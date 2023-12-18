/*2) Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu antecessor. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor inteiro:");
        int valor = int.Parse(Console.ReadLine());

        int antecessor = valor - 1;
        Console.WriteLine("O valor antecessor é: " + antecessor);
    }
}

