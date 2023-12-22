/*15)Ler dois valores (considere que não serão lidos valores iguais) e escrevê-los em ordem crescente. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o valor 1:");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor 2:");
        double valor2 = double.Parse(Console.ReadLine());

        if (valor1 > valor2) {
            Console.WriteLine("Valores em ordem crescente: {0}, {1}", valor1, valor2);
        }
        else if (valor2 > valor1) {
            Console.WriteLine("Valores em ordem crescente: {0}, {1}", valor2, valor1);
        }
        else {
            Console.WriteLine("Os valores são iguais: " + valor1);
        }
    }
}

