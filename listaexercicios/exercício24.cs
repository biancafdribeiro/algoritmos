/*24) Um posto está vendendo combustíveis com a seguinte tabela de descontos:
        Gasolina até 20 litros, desconto de 3% por litro 
               acima de 20 litros, desconto de 5% por litro

        Álcool até 20 litros, desconto de 4% por litro 
                 acima de 20 litros, desconto de 6% por litro

Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da
seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se
que o preço do litro da gasolina é R$ 3,30 e o preço do litro do álcool é R$ 2,90. 
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Escolha o tipo de combustível:");
        Console.WriteLine("G - Gasolina");
        Console.WriteLine("A - Álcool");


        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "G": 
                Console.WriteLine("Digite quantos litros você quer:");
                double litrosgasolina = double.Parse(Console.ReadLine());
                double valorgasolina = litrosgasolina * 3.30;
                double valorgasolinadesconto;
                
                if (litrosgasolina <= 20) {
                    valorgasolinadesconto = valorgasolina - (valorgasolina * 0.03);
                    Console.WriteLine("O valor a ser pago é {0}", valorgasolinadesconto.ToString("F2"));

                }
                else {
                    valorgasolinadesconto = valorgasolina - (valorgasolina * 0.05);
                    Console.WriteLine("O valor a ser pago é {0}", valorgasolinadesconto.ToString("F2"));
                }
                break;

            case "A": 
                Console.WriteLine("Digite quantos litros você quer:");
                double litrosalcool = double.Parse(Console.ReadLine());
                double valoralcool = litrosalcool * 2.90;
                double valoralcooldesconto;
                
                if (litrosalcool <= 20) {
                    valoralcooldesconto = valoralcool - (valoralcool * 0.04);
                    Console.WriteLine("O valor a ser pago é {0}", valoralcooldesconto.ToString("F2"));

                }
                else {
                    valoralcooldesconto = valoralcool - (valoralcool * 0.06);
                    Console.WriteLine("O valor a ser pago é {0}", valoralcooldesconto.ToString("F2"));
                }
                break;
        }
    }
}
