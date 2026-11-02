/*
    01-Exercício 08:
    Ler um valor e escrever se ele é maior ou menor que 10.

    02-Algorítimo:
    01-Limpar o console
    02-Solicitar o valor.
    03-Validar, tratar erro e converter.
    04-Verificar se é maior que 10.
    05-Retornar o resultado.
*/
namespace Project_KantoNerd_08_50;

class Program
{
    static void Main(string[] args)
    {
        //Declarando variáveis:
        string? entradaValor;
        decimal valor;

        //Limpar console, solicitar informações, validar e armazenar:
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Digite um número qualquer:");
            entradaValor = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaValor))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!decimal.TryParse(entradaValor, out valor))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite o valor desejado: ");
                Console.ResetColor();
                continue;
            }
            if (valor < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O valor é menor que 10.");
                Console.ResetColor();
                return;
            }
            else if (valor > 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("O valor é maior que 10.");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O valor é igual a 10.");
                Console.ResetColor();
                return;
            }
        }

    }
}
