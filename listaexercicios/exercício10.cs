/*10) Ler um valor e escrever se é positivo ou negativo (considere o valor zero como positivo). 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor.");
        double valor = double.Parse(Console.ReadLine());

        if (valor >= 0) {
            Console.WriteLine("É positivo!");
        }
        else if (valor < 0) {
            Console.WriteLine("É negativo!");
        }
    }
}

