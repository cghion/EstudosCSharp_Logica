/*
    01-Exercício 18:
    Escreva um algorítimo para ler dois valores e se o segundo valor informado for zero, deve ser lido um novo valor, ou seja, para o segundo valor não pode ser aceito o valor zero e imprimir o resultado da divisão do primeiro valor lido pelo segundo valor lido (Utilizar a estrutura enquanto).

    02-Algorítimo:
    01-Limpar o console
    02-Solicitar individualmente cada valor. 
    03-Validar, tratar erro e converter do primeiro valor.
    04-Validar, tratar erro e converter o segundo valor.
    05-Armazenar em variáveis.
    06-Retornar os valores das variáveis.
*/
namespace Project_KantoNerd_18_50;

class Program
{
    static void Main(string[] args)
    {


        //Declarando variáveis:
        string? entradaValor01, entradaValor02;
        decimal valor01, valor02, quociente;

        //Limpar console, solicitar informações, validar e armazenar:
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Digite o primeiro número:");
            entradaValor01 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaValor01))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!decimal.TryParse(entradaValor01, out valor01))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite o valor desejado: ");
                Console.ResetColor();
                return;
            }
            break;
        }

        while (true)
        {
            Console.WriteLine("Digite o segundo número. Tem que ser maior que zero:");
            entradaValor02 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaValor02))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!decimal.TryParse(entradaValor02, out valor02))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite o valor desejado: ");
                Console.ResetColor();
                return;
            }
            if (valor02 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: O segundo valor é obrigatóriamente maior que zero. Digite novamente: ");
                Console.ResetColor();
                return;
            }

            break;
        }


        quociente = valor01 / valor02;
        Console.WriteLine($"A divisão de {valor01} e {valor02} é {quociente:N2}");

    }
}
