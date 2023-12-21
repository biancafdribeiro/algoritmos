/*5)   Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos
brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total
de eleitores.
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o número total de eleitores do município:");
        double eleitorestotal = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de votos brancos:");
        double votosbrancos = double.Parse(Console.ReadLine());
        
        double percentualbrancos = (votosbrancos/eleitorestotal) * 100.0;
        Console.WriteLine("O percentual de votos brancos é: " + percentualbrancos);

        Console.WriteLine("Digite a quantidade de votos nulos:");
        double votosnulos = double.Parse(Console.ReadLine());

        double percentualnulos = (votosnulos/eleitorestotal) * 100.0;
        Console.WriteLine("O percentual de votos nulos é: " + percentualnulos);

        Console.WriteLine("Digite a quantidade de votos válidos:");
        double votosvalidos = double.Parse(Console.ReadLine());

        double percentualvalidos = (votosvalidos/eleitorestotal) * 100.0;
        Console.WriteLine("O percentual de votos válidos é: " + percentualvalidos);
    }
}

