using System.Globalization;
namespace Project_KantoNerd_03_50;
/*
01-Exercício 03:
Escreva um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa pessoa expressa em dias.
Considerar ano 365 dias e mês 30 dias
 
quanto anos meses e dias você tem?
Perguntar isoladamente
Pergunta tudo de uma vez
Perguntar a data de nascimento
*/
class Program
{
    static void Main(string[] args)
    {

        CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
        int teste = 1234567;
        Console.WriteLine($"{teste:N0}"); // deve exibir 1.234.567

        int anos, meses, dias, saidaAnos, saidaMeses, saidaDias;
        string? entradaAno, entradaMes, entradaDia;

        while (true)
        {
            Console.WriteLine("Digite ano você tem:");
            entradaAno = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaAno))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!int.TryParse(entradaAno, out anos))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }
            if (anos < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Digite apenas números inteiros. Não existe negativo");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do Lado 3 se tudo estiver correto
        }

        while (true)
        {
            Console.WriteLine("Digite quantos meses:");
            entradaMes = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaMes))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!int.TryParse(entradaMes, out meses))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }
            if (meses < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Digite apenas números inteiros. Não existe negativo");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do Lado 3 se tudo estiver correto
        }


        while (true)
        {
            Console.WriteLine("Digite quantos dias:");
            entradaDia = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entradaDia))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!int.TryParse(entradaDia, out dias))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }
            if (dias < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: Digite apenas números inteiros. Não existe negativo");
                Console.ResetColor();
                continue;
            }
            break; // Sai do loop do Lado 3 se tudo estiver correto
        }

        saidaAnos = anos * 365;
        saidaMeses = meses * 30;
        saidaDias = dias;
        Console.WriteLine($"Sua idade em dias é {(saidaAnos + saidaMeses + saidaDias):N0}. Sendo que {saidaAnos:N0} refere-se a quantidade de dias para os seus anos; {saidaMeses:N0} refere-se a quantidade de dias para os seus meses; e {saidaDias:N0} refere-se a quantidade de dias");

    }
}
