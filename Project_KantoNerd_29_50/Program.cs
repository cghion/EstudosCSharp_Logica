/*
    01-Exercício 01:
    Ler a quantidade de alunos existentes em uma turma. Ler suas notas e informar a média das notas da turma.

    02-Adição de complexidades:
    
    03-Variáveis e coleções:
    Variável => para receber a inserção da quantidade de alunos, para receber as notas dos alunos a cada iteração do laço e mais duas variáveis, uma para somar os valores recebidos e outra para contar os valores recebidos.
    Uma opção é a utilização de lista para gravar o que está dentro e fora do intervalo. São duas listas distintas.
    List => 
    Array
    Queue
    Stack

    04-Laços:
    For / While => Trabalhar com inserção do usuário a cada iteração do laço.
    Foreach

    05-Algorítimo:

    
*/



namespace Project_KantoNerd_29_50;

class Program
{
    static void Main(string[] args)
    {
        string? entradaQtdAlunos29, notaAluno29;
        int qtdAlunos29 = 0, notaAlunointeiro29 = 0, somatoria29 = 0, contagem29 = 0;

        Console.WriteLine($"Digite a quantidade de alunos da turma desejada:");
        entradaQtdAlunos29 = Console.ReadLine();
        if (!int.TryParse(entradaQtdAlunos29, out qtdAlunos29))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro01: Digite apenas números inteiros.");
            Console.ResetColor();
        }

        for (int i = 1; i <= qtdAlunos29; i++)
        {
            Console.WriteLine($"Digite a nota do {i}º aluno:");
            notaAluno29 = Console.ReadLine();
            if (!int.TryParse(notaAluno29, out notaAlunointeiro29))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro01: Digite apenas números inteiros.");
                Console.ResetColor();
            }
            somatoria29 = somatoria29 + notaAlunointeiro29;
            contagem29++;
        }



        Console.WriteLine($"Saiu do laço!!! A turma possui {qtdAlunos29} alunos. A somatória das notas é {somatoria29}, média da turma é {(decimal)somatoria29 / (decimal)qtdAlunos29}.");
    }
}
