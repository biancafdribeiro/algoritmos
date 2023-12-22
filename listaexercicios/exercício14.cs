/*14) Ler dois valores (considere que não serão lidos valores iguais) e escrever o maior deles. 
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
            Console.WriteLine("O valor maior é: " + valor1);
        }
        else if (valor2 > valor1) {
            Console.WriteLine("O valor maior é: " + valor2);        
        }
        else {
            Console.WriteLine("Os valores são iguais.");
        }
    }
}

