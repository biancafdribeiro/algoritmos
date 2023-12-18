/*Escreva um algoritmo que armazene o valor 10 em uma variável A e o valor 20 em uma variável B.
A seguir (utilizando apenas atribuições entre variáveis) troque os seus conteúdos fazendo com que o
valor que está em A passe para B e vice-versa. Ao final, escrever os valores que ficaram armazenados
nas variáveis.*/

using System;

class Program
{
    public static void Main()
    {
        int variavelA = 10;
        int variavelB = 20;

        int variavelC = variavelA;
        variavelA = variavelB;
        variavelB = variavelC;

        Console.WriteLine("Valor da variável A: " + variavelA);
        Console.WriteLine("Valor da variável B: " + variavelB);

        Console.ReadKey();
    }
}
