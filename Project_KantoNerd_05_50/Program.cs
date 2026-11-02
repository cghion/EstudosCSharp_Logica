/*
    01-Exercício 05:
    Escreva um algorítimo para ler o salário mensal atual de um funcionário e o percentual de reajuste. Calcular e escrever o valor do novo salário.

    02-Algorítimo:
    01-Limpar o console
    02-Solicitar individualmente cada valor.
    03-Validar, tratar erro e converter
    04-Calcular o novo salário.
    05-Armazenar em variáveis.
    06-Retornar os valores das variáveis.
*/
namespace Project_KantoNerd_05_50;

class Program
{
    static void Main(string[] args)
    {

        //Declarando variáveis:
        string? entradaSalarioAtual;
        string? entradaReajuste;
        decimal salarioAtual;
        decimal percentReajuste, novoSalario;


        while (true)
        {
            Console.WriteLine("Digite o salário atual:");
            entradaSalarioAtual = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaSalarioAtual))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!decimal.TryParse(entradaSalarioAtual, out salarioAtual))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite o salário incluindo os centavos.");
                Console.ResetColor();
                continue;
            }
            if (salarioAtual < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Não existe salário negativo");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do salario atual se tudo estiver correto
        }

        while (true)
        {
            Console.WriteLine("Digite o percentual de realuste no formato 5% = 0,05:");
            entradaReajuste = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaReajuste))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!decimal.TryParse(entradaReajuste, out percentReajuste))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite apenas o percentual sem o símbolo %.");
                Console.ResetColor();
                continue;
            }
            if (percentReajuste < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Não existe reajuste negativo");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do percentual reajuste salário se tudo estiver correto
        }
        Console.Clear();
        novoSalario = (percentReajuste * salarioAtual) + salarioAtual;
        Console.WriteLine($"Seu salário de R${salarioAtual:C2}, foi reajustado em {percentReajuste:P2}, totalizando R${novoSalario:C2}");
    }
}
