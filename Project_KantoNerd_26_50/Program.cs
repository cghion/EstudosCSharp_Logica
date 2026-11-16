/*
    01-Exercício 01:
    Ler 10 valores e informar quantos desses valores são negativos.

    02-Adição de complexidades:
    
    03-Variáveis e coleções:
    Variável => para receber a inserção do usuário a cada iteração do laço.
    List
    Array
    Queue
    Stack

    04-Laços:
    For / While => Trabalhar com inserção do usuário a cada iteração do laço.
    Foreach

    05-Algorítimo:

    For iterações igual ou menor que 10.
    No laço se for negativo adicionar ao contatador. Do contrário, sair.
    pedir numero
    verificar se é negativo
    
*/
namespace Project_KantoNerd_26_50;

class Program
{
    static void Main(string[] args)
    {
        int entrada;
        var contagemNegativo = 0;
        string? entradaUsuario;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Digite um número inteiro positivo ou negativo:");
            entradaUsuario = Console.ReadLine();

            if (!int.TryParse(entradaUsuario, out entrada))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }

            if (entrada < 0)
            {
                contagemNegativo = contagemNegativo + 1;
            }


        }

        Console.WriteLine($"A quantidade de números negativos é {contagemNegativo}");

        Console.WriteLine("Saiu do laço!");
    }
}
