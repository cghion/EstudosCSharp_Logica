/*
    01-Exercício 01:
    Ler 10 valores e informar a média aritmética.

    02-Adição de complexidades:
    
    03-Variáveis e coleções:
    Variável => para receber a inserção do usuário a cada iteração do laço e mais duas variáveis, uma para somar os valores recebidos e outra para contar os valores recebidos.
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
namespace Project_KantoNerd_28_50;

class Program
{
    static void Main(string[] args)
    {
        string? entradaUsuario28;
        int entrada28 = 0, contagem28 = 0, somatoria28 = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Digite um número inteiro, positivo ou negativo:");
            entradaUsuario28 = Console.ReadLine();
            if (!int.TryParse(entradaUsuario28, out entrada28))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }

            contagem28++;
            somatoria28 = somatoria28 + entrada28;
        }
        Console.WriteLine($"Fora do laço!!!! A somatória é de {somatoria28} e a quantidade de numeros digitados é de {contagem28}, consequentemente a média é de {(decimal)somatoria28 / (decimal)contagem28}.");
    }
}
