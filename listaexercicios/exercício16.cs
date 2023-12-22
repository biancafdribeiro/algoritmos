/*16) Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os
minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é
de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte.  
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a hora que o jogo começou:");
        int horainicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a hora que o jogo terminou:");
        int horafim = int.Parse(Console.ReadLine());

        int duração;

        if (horainicio <= 24 && horainicio >= 0 && horafim <= 24 && horafim >= 0) {
            if (horainicio > horafim) {
                duração = (horafim + 24) - horainicio;
                Console.WriteLine("O jogo de xadrez durou {0} horas", duração);
        }
            else if (horafim > horainicio) {
                duração = horafim - horainicio;
                Console.WriteLine("O jogo de xadrez durou {0} horas", duração);
            }
        }
    }
}
