/*9)  Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso
contrário escrever NÃO É MAIOR QUE 10! 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um valor.");
        double valor = double.Parse(Console.ReadLine());

        if (valor > 10) {
            Console.WriteLine("É MAIOR QUE 10!");
        }
        else if (valor < 10) {
            Console.WriteLine("É MENOR QUE 10!");
        }
        else {
            Console.WriteLine("É IGUAL A 10!");
        }
    }
}

