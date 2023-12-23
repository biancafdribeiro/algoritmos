/*21)  Ler 3 valores (considere que não serão informados valores iguais) e escrever a soma dos 2
maiores. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o primeiro valor:");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor:");
        double valor3 = double.Parse(Console.ReadLine());

        double soma;

        if (valor1 > valor2 && valor1 > valor3) 
        {
            if (valor2 > valor3) 
            {
                soma = valor1 + valor2;
                Console.WriteLine("A soma dos dois maiores valores, {0} e {1}, é {2}", valor1, valor2, soma);
            }
            else 
            {
                soma = valor1 + valor3;
                Console.WriteLine("A soma dos dois maiores valores, {0} e {1}, é {2}", valor1, valor3, soma);
            }
        }
        else if (valor2 > valor1 && valor2 > valor3) 
        {
            if (valor1 > valor3) 
            {
                soma = valor2 + valor1;
                Console.WriteLine("A soma dos dois maiores valores, {0} e {1}, é {2}", valor2, valor1, soma);
            }
            else 
            {
                soma = valor2 + valor3;
                Console.WriteLine("A soma dos dois maiores valores, {0} e {1}, é {2}", valor2, valor3, soma);
            }
        }
        else if (valor3 > valor1 && valor3 > valor2) 
        {
            if (valor2 > valor1) 
            {
                soma = valor3 + valor2; 
                Console.WriteLine("A soma dos dois maiores valores, {0} e {1}, é {2}", valor3, valor2, soma);
            }
            else 
            { 
                soma = valor3 + valor1;
                Console.WriteLine("A soma dos dois maiores valores, {0} e {1}, é {2}", valor3, valor1, soma);
            }
        }
    }
}
