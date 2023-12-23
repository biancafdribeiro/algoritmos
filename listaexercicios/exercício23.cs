/*23)  Ler 3 valores (A, B e C) representando as medidas dos lados de um triângulo e escrever se formam
ou não um triângulo. OBS: para formar um triângulo, o valor de cada lado deve ser menor que a soma
dos outros 2 lados. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o valor de A:");
        double valorA = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B:");
        double valorB = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de C");
        double valorC = double.Parse(Console.ReadLine());

        double somaAB = valorA + valorB;
        double somaAC = valorA + valorC;
        double somaBC = valorB + valorC;

        if (valorC < somaAB || valorB < somaAC || valorA < somaBC) 
        {
            Console.WriteLine("É um triângulo!");
        }
        else {
            Console.WriteLine("Não é um triângulo!");
        }
    }
}
