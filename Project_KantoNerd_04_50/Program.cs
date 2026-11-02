/*
    01-Exercício 04:
    Escreva um algorítimo para ler o número total de eleitores de um município, o número de votos brancos, nulos e válidos. 
    Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.

    02-Algorítimo:
    01-Limpar o console
    02-Solicitar individualmente cada valor.
    03-Validar, tratar erro e converter
    04-Obter os percentuais.
    05-Armazenar em variáveis.
    06-Retornar os valores das variáveis.
*/


namespace Project_KantoNerd_04_50;

class Program
{
    static void Main(string[] args)
    {
        //Declarando variáveis:
        string? entradaTotalEleitores;
        string? entradaVotosBrancos;
        string? entradaVotosNulos;
        int totalEleitores;
        int votosBrancos;
        int votosNulos;
        int votosValidos;
        int totalVotos;
        decimal percentVotosBrancos;
        decimal percentVotosNulos;
        decimal percentVotosValidos;

        //Limpar console, solicitar informações, validar e armazenar:
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Digite o número total de eleitores:");
            entradaTotalEleitores = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaTotalEleitores))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!int.TryParse(entradaTotalEleitores, out totalEleitores))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }
            if (totalEleitores < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Digite apenas números inteiros. Não existe negativo");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do total eleitores se tudo estiver correto
        }

        while (true)
        {
            Console.WriteLine("Digite o número total de votos brancos:");
            entradaVotosBrancos = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaVotosBrancos))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!int.TryParse(entradaVotosBrancos, out votosBrancos))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }
            if (votosBrancos < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Digite apenas números inteiros. Não existe negativo");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do votos brancos se tudo estiver correto
        }


        while (true)
        {
            Console.WriteLine("Digite o número total de votos nulos:");
            entradaVotosNulos = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaVotosNulos))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!int.TryParse(entradaVotosNulos, out votosNulos))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }
            if (votosNulos < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Digite apenas números inteiros. Não existe negativo");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do votos nulos se tudo estiver correto
        }

        //Iniciar o código
        votosValidos = totalEleitores - votosBrancos - votosNulos;
        percentVotosBrancos = (decimal)votosBrancos / totalEleitores;
        percentVotosNulos = (decimal)votosNulos / totalEleitores;
        percentVotosValidos = (decimal)votosValidos / totalEleitores;
        totalVotos = votosNulos + votosBrancos + votosValidos;

        Console.Clear();
        Console.WriteLine(percentVotosBrancos);
        Console.WriteLine($"{"Apuração:",44}");
        Console.WriteLine(new string('-', 44));
        Console.WriteLine();
        Console.WriteLine($"{"",-20}{"Total",10}{"Percentual",14}");
        Console.WriteLine($"{"",-20}{new string('-', 10),10}{new string('-', 12),14}");
        Console.WriteLine($"{"Votos Nulos:",-20}{votosNulos,10:N0}{(double)percentVotosNulos,14:P5}");
        Console.WriteLine($"{"Votos Brancos:",-20}{votosBrancos,10:N0}{(double)percentVotosBrancos,14:P5}");
        Console.WriteLine($"{"Votos Válidos:",-20}{votosValidos,10:N0}{(double)percentVotosValidos,14:P5}");
        Console.WriteLine($"{"",-20}{new string('-', 10),10}{new string('-', 12),14}");
        Console.WriteLine($"{"Votos Totais:",-20}{totalVotos,10:N0}{1.0,14:P0}");
    }
}
