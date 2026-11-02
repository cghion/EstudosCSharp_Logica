/*
    01-Exercício 05:
    Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês, mais uma comissão fixa por carro vendido e mais 5% sobre o total de vendas efetuadas. Escreva um algorítimo para ler o número de carros vendidos, o valor total das vendas, o valor que ele recebe por cada carro e o salário fixo. Calcule o salário do funcionário.

    02-Algorítimo:
    01-Limpar o console
    02-Solicitar individualmente cada valor. Salário fixo mensal (decimal), vendas total (decimal), comissão por carro (decimal), qt carros vendidos (int).
    03-Validar, tratar erro e converter
    04-Calcular o novo salário.
    05-Armazenar em variáveis.
    06-Retornar os valores das variáveis.
*/
namespace Project_KantoNerd_06_50;

class Program
{
    static void Main(string[] args)
    {

        //Declarando variáveis:
        string? entradaSalarioFixo;
        string? entradaVendasTotal;
        string? entradaComissaoCarro;
        string? entradaQTCarros;
        decimal salarioFixo, vendasTotal, comissaoCarro, QTCarros, salarioFinal, comissaoCarroTotal, participacaoVendas;
        var percentParticipacao = 0.05m;

        //Limpar console, solicitar informações, validar e armazenar:
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Digite o salário fixo atual:");
            entradaSalarioFixo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaSalarioFixo))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!decimal.TryParse(entradaSalarioFixo, out salarioFixo))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite o salário fixo incluindo os centavos: ");
                Console.ResetColor();
                continue;
            }
            if (salarioFixo < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Não existe salário fixo negativo");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do salario fixo atual se tudo estiver correto
        }

        while (true)
        {
            Console.WriteLine("Digite o total de vendas do mês: ");
            entradaVendasTotal = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaVendasTotal))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!decimal.TryParse(entradaVendasTotal, out vendasTotal))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite o total de vendas incluindo os centavos: ");
                Console.ResetColor();
                continue;
            }
            if (vendasTotal < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Não existe vendas negativas.");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do total de vendas se tudo estiver correto
        }

        while (true)
        {
            Console.WriteLine("Digite o valor de comissão carro por carro vendido: ");
            entradaComissaoCarro = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaComissaoCarro))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!decimal.TryParse(entradaComissaoCarro, out comissaoCarro))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite o total de vendas incluindo os centavos: ");
                Console.ResetColor();
                continue;
            }
            if (comissaoCarro < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Não existe vendas negativas.");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop da comissão por carro se tudo estiver correto
        }

        while (true)
        {
            Console.WriteLine("Digite o valor de comissão carro por carro vendido: ");
            entradaQTCarros = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaQTCarros))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!decimal.TryParse(entradaQTCarros, out QTCarros))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite o total de vendas incluindo os centavos: ");
                Console.ResetColor();
                continue;
            }
            if (QTCarros < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Não existe vendas negativas.");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop de carros vendidos se tudo estiver correto
        }

        // Cálcular e retornar ao usuário:
        comissaoCarroTotal = (QTCarros * comissaoCarro);
        participacaoVendas = (percentParticipacao * vendasTotal);
        salarioFinal = comissaoCarroTotal + participacaoVendas + salarioFixo;

        Console.Clear();
        // Larguras: rótulo (30), valor (12), nota (recuo de 3 espaços)
        string traco = new string('-', 12);
        string duplo = new string('=', 12);

        Console.WriteLine($"{"Apuração salário:",43}");
        Console.WriteLine();
        Console.WriteLine($"{"",-30}{"BRL",12}");
        Console.WriteLine($"{"",-30}{traco,12}");
        Console.WriteLine($"{"Salário fixo:",-30}{salarioFixo,12:N2}");
        Console.WriteLine($"{"Participação nas vendas:",-30}{participacaoVendas,12:N2}   ({percentParticipacao:P0} * {vendasTotal:C2})");
        Console.WriteLine($"{"Comissão carros vendidos:",-30}{comissaoCarroTotal,12:N2}   ({comissaoCarro:C2} * {QTCarros:00} carros vendidos)");
        Console.WriteLine($"{"",-30}{traco,12}");
        Console.WriteLine($"{"Salário Final:",-30}{salarioFinal,12:N2}");
        Console.WriteLine($"{"",-30}{duplo,12}");
    }
}
