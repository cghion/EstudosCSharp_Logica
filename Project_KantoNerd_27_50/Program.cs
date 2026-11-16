/*
    01-Exercício 01:
    Ler 10 valores e informar quantos desses valores estão entre 10 e 20, inclusive os dois e quantos deles estão fora do intervalo.

    02-Adição de complexidades:
    
    03-Variáveis e coleções:
    Variável => para receber a inserção do usuário a cada iteração do laço e mais duas variáveis para contagem dentro de fora do intervalo.
    Uma opção é a utilização de lista para gravar o que está dentro e fora do intervalo. São duas listas distintas.
    List => 
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
namespace Project_KantoNerd_27_50;

class Program
{
    static void Main(string[] args)
    {
        string? entradaUsuario27;
        int contagemDentro27 = 0, contagemFora27 = 0, entrada27;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Digite um número inteiro:");
            entradaUsuario27 = Console.ReadLine();
            if (!int.TryParse(entradaUsuario27, out entrada27))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }
            if (entrada27 >= 10 & entrada27 <= 20)
            {
                contagemDentro27 = contagemDentro27 + 1;
            }
            else
            {
                contagemFora27 = contagemFora27 + 1;
            }

        }
        Console.WriteLine($"São {contagemDentro27} números dentro do intervalo e {contagemFora27} números fora do intervalo.");
        Console.WriteLine("Saiu do laço!!!");
    }
}
