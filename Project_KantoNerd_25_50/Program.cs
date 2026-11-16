/*
    01-Exercício 01:
    Escreva um algorítimo para imprimir os números de 1 a 10 em ordem crescente utilizando While e um contador.

    02-Adição de complexidades:
    
    03-Variáveis e coleções:
    Variável => Utilizar variável por determinação do enunciado.
    List
    Array
    Queue
    Stack

    04-Laços:
    For / While => Utilizar While por determinação do enunciado.
    Foreach

    05-Algorítimo:
    
*/
namespace Project_KantoNerd_25_50;

class Program
{
    static void Main(string[] args)
    {
        int iterador;
        iterador = 1;

        while (iterador <= 10)
        {
            Console.WriteLine($"Impressão de número {iterador}");
            iterador++;
        }
        Console.WriteLine("Saiu do Loop!");
    }
}
