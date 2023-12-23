/*25) Faça um algoritmo para ler um número que é um código de usuário. Caso este código seja
diferente de um código armazenado internamente no algoritmo (igual a 1234) deve ser apresentada a
mensagem ‘Usuário inválido!’. Caso o Código seja correto, deve ser lido outro valor que é a senha. Se
esta senha estiver incorreta (a certa é 9999) deve ser mostrada a mensagem ‘senha incorreta’. Caso a
senha esteja correta, deve ser mostrada a mensagem ‘Acesso permitido’.
*/

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu código de usuário:");
        int codigousuario = int.Parse(Console.ReadLine());

        if (codigousuario != 1234) {
            Console.WriteLine("Usuário inválido!");
        }
        else { 
            Console.WriteLine("Digite sua senha:");
            int senhausuario = int.Parse(Console.ReadLine());

            if (senhausuario != 9999) {
                Console.WriteLine("Senha incorreta!");
            }
            
            else {
                Console.WriteLine("Acesso permitido!");
            }
        }
    }
}
