/*20) Ler 3 valores (considere que não serão informados valores iguais) e escrever o maior deles. 
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

        if (valor1 > valor2 && valor1 > valor3) {
            Console.WriteLine("O maior valor é {0}", valor1);
        }
        else if (valor2 > valor1 && valor2 > valor3) {
            Console.WriteLine("O maior valor é {0}", valor2);
        }
        else if (valor3 > valor1 && valor3 > valor2) {
            Console.WriteLine("O maior valor é {0}", valor3);
        }
    }
}
