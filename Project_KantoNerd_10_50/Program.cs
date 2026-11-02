/*
    01-Exercício 10:
    Ler dois valores e escrever se qual deles é maior.

    02-Algorítimo:
    01-Limpar o console
    02-Solicitar os dois valores.
    03-Validar, tratar erro e converter.
    04-Verificar qual é maior.
    05-Retornar o resultado.
*/
namespace Project_KantoNerd_10_50;

class Program
{
    static void Main(string[] args)
    {
        //Declarando variáveis:
        string? entradaValor01, entradaValor02;
        decimal valor01, valor02;

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
            Console.WriteLine("Digite o segundo número:");
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
            break;
        }

        if (valor01 > valor02)
        {
            Console.WriteLine($"O Primeiro valor é o maior");
        }
        else if (valor01 < valor02)
        {
            Console.WriteLine("O segundo valor é o maior");
        }
        else
        {
            Console.WriteLine("Os dois valores são iguais");
        }

    }
}

