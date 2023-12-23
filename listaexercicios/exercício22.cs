/*22)  Ler 3 valores (considere que não serão informados valores iguais) e escrevê-los em ordem
crescente. 
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
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", valor1, valor2, valor3);
            }
            else 
            {
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", valor1, valor3, valor2);
            }
        }
        else if (valor2 > valor1 && valor2 > valor3) 
        {
            if (valor1 > valor3) 
            {
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", valor2, valor1, valor3);
            }
            else 
            {
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", valor2, valor3, valor1);
            }
        }
        else if (valor3 > valor1 && valor3 > valor2) 
        {
            if (valor2 > valor1) 
            {
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", valor3, valor2, valor1);
            }
            else 
            { 
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", valor3, valor1, valor2);
            }
        }
    }
}
