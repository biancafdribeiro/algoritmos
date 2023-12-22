/*17) A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais
de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%.
Escreva um algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva
o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas
(considere que o mês possua 4 semanas exatas).  
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o salário por hora:");
        double salariohora = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite quantas horas foram trabalhadas na semana 1:");
        double horassemana1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite quantas horas foram trabalhadas na semana 2:");
        double horassemana2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite quantas horas foram trabalhadas na semana 3:");
        double horassemana3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite quantas horas foram trabalhadas na semana 4:");
        double horassemana4 = double.Parse(Console.ReadLine());

        double horastrabalhadas = horassemana1 + horassemana2 + horassemana3 + horassemana4;
        double salariosemana1 = 0.0;
        double salariosemana2 = 0.0;
        double salariosemana3 = 0.0;
        double salariosemana4 = 0.0;
        
        if (horassemana1 > 40.0) {
            salariosemana1 = ((salariohora + salariohora * 0.5) * horassemana1);
        }
        else if (horassemana1 == 40.0) {
            salariosemana1 = salariohora * horassemana1;
        }

        if (horassemana2 > 40.0) {
            salariosemana2 = ((salariohora + salariohora * 0.5) * horassemana2);
        }
        else if (horassemana2 == 40.0) {
            salariosemana2 = salariohora * horassemana2;
        }

        if (horassemana3 > 40.0) {
            salariosemana3 = ((salariohora + salariohora * 0.5) * horassemana3);
        }
        else if (horassemana3 == 40.0) {
            salariosemana3 = salariohora * horassemana3;
        }

        if (horassemana4 > 40.0) {
            salariosemana4 = ((salariohora + salariohora * 0.5) * horassemana4);
        }
        else if (horassemana4 == 40.0) {
            salariosemana4 = salariohora * horassemana4;
        }

        double salariototal = salariosemana1 + salariosemana2 + salariosemana3 + salariosemana4;
        Console.WriteLine("O seu salário é {0}, com {1} horas trabalhadas", salariototal, horastrabalhadas);
    }
}
