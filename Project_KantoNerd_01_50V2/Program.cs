using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;

namespace Project_KantoNerd_01_50V2;
/*
   01-Exercício 01:
    Escreva um algorítimo para ler as dimensões de um retângulo (Base e altura) e calcule a sua área.
    Não é possível fazer (Base * altura / 2) porque não sabemos quem é a base e não quero solicitar para aumentar a complexidade do exercício.
    Semiperímetro (p) = p = (a + b + c) / 2
    Área = (p * (p - a) * (p - b) * (p - c)) ^ (1/2)
       
   02-Adição de complexidades:
    02.01-Complexidade adicional 01 = Validar a entrada do usuário para obedecer o tipo de dado. Por exemplo, quando o tipo for Inteiro não pode haver fração. 
    02.02-Complexidade adicional 02 = Validar a entrada do usuário contra inserção de "0", de "", de "   ", NULL
    • String vazia (""): É uma caixa de sapatos existente, mas que está vazia. É o que acontece quando o usuário apenas aperta "Enter". O console lê uma linha vazia de texto.
    • Nulo (null): Significa que a caixa de sapatos sequer existe. No console, isso geralmente só acontece se o fluxo de entrada for fechado abruptamente (por exemplo, se o usuário pressionar Ctrl + Z no Windows ou Ctrl + D no Linux/Mac para encerrar a entrada de dados).
    02.03-Complexidade adicional 03 = Trocar retângulo por triângulo.
    02.03-Complexidade adicional 04 = Validar se as medidas fornecidas pelo usuário obedecem o teorema da desigualdade triangular. Do contrário não formará um triângulo com as medidas fornecidas.
    Para que o triângulo seja formado, as três condições abaixo precisam ser verdadeiras ao mesmo tempo:
    • (a + b > c)
    • (a + c > b)
    • (b + c > a)
    Exemplo Prático = Lados medindo 3 cm, 4 cm e 5 cm.
        • (3 + 4 = 7) (que é maior que 5)
        • (3 + 5 = 8) (que é maior que 4)
        • (4 + 5 = 9) (que é maior que 3)
	• Resultado: É possível formar um triângulo.
    02.04-Complexidade adicional 04 = Classificação do triângulo.
    O lado c é sempre o maior de todos.
        • Equilátero = a = b = c
        • Isósceles = a = b != c        
        • Escaleno = a != b != c
        • Retângulo = c^2 = a^2 + b^2
        • Acutângulo = c^2 < a^2 + b^2
        • Obtusângulo = c^2 > a^2 + b^2

    03-Algorítimo:
    Ok-Limpar o console,
    Ok-Solicitar para entrar o lado 01,
    OK-Validação 01 e 02 do L01,
    Ok-Tratar erro
    Ok-Solicitar para entrar o lado 02,
    Ok-Validação 01 e 02 do L02,
    Ok-Tratar erro
    Ok-Solicitar para entrar o lado 03,
    Ok-Validação 01 e 02 do L03
    Ok-Tratar erro
    Ok-Validação 03 Teorema da desigualdade triangular,
    Ok-Tratar erro,
    Ok-Calcular a área do triângulo,
    Ok-Retornar para o usuário os lados ingressados + a área do triângulo,
    Ok-Encerrar.

    Poderia primeiro aceitar a inserção de todos os lados do triângulo para depois executar a validação 01 e 02, mas isso exigirá um código mais complexo. Terei que identificar qual das entradas possui erro e solicitar para o usuário entrar novamente somente esse lado para alocar na variável correta. É muito para mim neste momento. Irei executar a validação 01 e 02 no momento da entrada de cada lado para depois seguir solicitando o próximo lado do triângulo.

    04-Outros
    Para quebrar linhas somente no editor sem afetar o console tem que clicar em ALT + Z. Não importa o tamanho da tela, o VS Code sempre ajustará para que nada fique fora do campo de visão sem forçar o desenvolvedor a criar quebras de linha no editor.
*/
class Program
{
    static void Main(string[] args)
    {
        //Declarando as varíaveis:
        int lado01;
        int lado02;
        int lado03;
        decimal semiPerimetro;
        decimal radicando;
        decimal areaTriangulo;
        string classificacaoTriangulo;
        bool par01;
        bool par02;
        bool par03;

        /*
                //Etapa 01:: Pegar os dados do usuário e validar o tipo de dado.
                Console.Clear();
                Console.WriteLine("Por gentileza informe os três lados do triângulo com valores positivos e inteiros:");
                //Etapa 01.01:: Validar a entrada de dados. Cada lado de cada vez

                Aviso CS8600: Conversão de literal nula ou possível valor nulo em tipo não anulável. 
                Somente "string entrada" não aceita nulo e o código quebra. Se inserir "?", "string? entrada" a variável passa a aceitar nulo. Portanto, se remover o "?" da variável ocorrerá o aviso CS8600.
        */

        lado01 = Program.LerLadoTriangulo("Informe o lado 01 do Triângulo: ");
        lado02 = Program.LerLadoTriangulo("Informe o lado 02 do Triângulo: ");
        lado03 = Program.LerLadoTriangulo("Informe o lado 03 do Triângulo: ");


        //Teste Teorema desigualdade triângulo
        if (
            lado01 + lado02 <= lado03 ||
            lado01 + lado03 <= lado02 ||
            lado02 + lado03 <= lado01)
        {
            Console.WriteLine("Os valores digitados não formam um triângulo e não obedecem ao Teorema da desigualdade dos triângulos. A soma de dois lados deve ser maior que o terceiro lado. Veja os valores digitados:");
            Console.WriteLine();
            Console.WriteLine($"Lado 01: {lado01}");
            Console.WriteLine($"Lado 02: {lado02}");
            Console.WriteLine($"Lado 03: {lado03}");
            Console.WriteLine("Re-inicie o programa.");
            Environment.Exit(0);
        }
        else
        {
            semiPerimetro = (lado01 + lado02 + lado03) / 2.0m;
            radicando = (semiPerimetro * (semiPerimetro - lado01) * (semiPerimetro - lado02) * (semiPerimetro - lado03));
            areaTriangulo = (decimal)Math.Sqrt((double)radicando);
            Console.WriteLine($"A área do triângulo é: {areaTriangulo:F8}");
            Console.WriteLine("Os lados do triângulo são:");
            Console.WriteLine($"Lado 01: {lado01},");
            Console.WriteLine($"Lado 02: {lado02},");
            Console.WriteLine($"Lado 03: {lado03}.");
            var comparaPares = new List<bool>
            {
                lado01 == lado02,
                lado01 == lado03,
                lado02 == lado03
            };
            int contaTrue = comparaPares.Count(compara => compara == true);
            switch (contaTrue)
            {
                case 0:
                    Console.WriteLine("O triângulo é Escaleno");
                    break;

                case 1:
                    Console.WriteLine("O triângulo é Isósceles");
                    break;

                case 3:
                    Console.WriteLine("O triângulo é Equilátero");
                    break;
            }

            List<int> lados = new() { lado01, lado02, lado03 };
            int maiorLado = lados.Max();
            int quadradoTodosLados = ((lado01 * lado01) + (lado02 * lado02) + (lado03 * lado03));
            int quadradoMairoLado = (maiorLado * maiorLado);
            int quadradoDemaisLados = quadradoTodosLados - quadradoMairoLado;

            if (quadradoMairoLado == quadradoDemaisLados)
            {
                Console.WriteLine("O triângulo é Retângulo");
            }
            else if (quadradoMairoLado < quadradoDemaisLados)
            {
                Console.WriteLine("O triângulo é Acutângulo");
            }
            else
            {
                Console.WriteLine("O triângulo é Obtusângulo");
            }
            ;
        }

    }


    static int LerLadoTriangulo(string mensagem)
    {

        while (true)
        {
            string? valorDigitado;
            int valorLado;

            Console.Write(mensagem);
            valorDigitado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(valorDigitado))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Entrada vazia ou nula. Não aperte apenas Enter. Não digite apenas aspas duplas ou simples.");
                Console.ResetColor();
                continue;
            }
            if (!int.TryParse(valorDigitado, out valorLado))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro02: Digite apenas números inteiros.");
                Console.ResetColor();
                continue;
            }
            if (valorLado <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro03: O lado deve ser maior que zero. Não existe triângulo com lado negativo ou zero");
                Console.ResetColor();
                continue;
            }
            return valorLado;
        }

    }









}
/*O lado c é sempre o maior de todos.
        • Retângulo = c^2 = a^2 + b^2
        • Acutângulo = c^2 < a^2 + b^2
        • Obtusângulo = c^2 > a^2 + b^2
*/

