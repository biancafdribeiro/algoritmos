/*18) ) Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendo-se que
ele recebe uma comissão de 3% sobre o total das vendas até R$ 1.500,00 mais 5% sobre o que
ultrapassar este valor, calcular e escrever o seu salário total. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o seu salário fixo:");
        double salariofixo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor das vendas efetuadas:");
        double vendasefetuadas = double.Parse(Console.ReadLine());

        double salariototal;

        if (vendasefetuadas <= 1500.0) {
            salariototal = salariofixo + (vendasefetuadas * 0.03);
        }
        else {
            salariototal = salariofixo + (1500.0 * 0.03) + ((vendasefetuadas - 1500.0) * 0.05);
        }

        Console.WriteLine("O seu salário é {0}", salariototal);
    }
}
