/*13) Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela
poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu). 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o ano atual:");
        int ano = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu ano de nascimento:");
        int anonascimento = int.Parse(Console.ReadLine());

        if (ano - anonascimento >= 16) {
            Console.WriteLine("Você pode votar!");
        }
        else {
            Console.WriteLine("Você não pode votar!");
        }
    }
}

