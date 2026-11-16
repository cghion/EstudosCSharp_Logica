/*
    01-Exercício 01:
    Escreva um algorítimo que calcule e imprima a tabuada do 8 de 1 a 10.

    02-Adição de complexidades:
    
    03-Variáveis e coleções:
    Variável => Pode ser variável ou constante para armazenar o número da tabuada. Não é necessário criar uma variável/constante/classe para os multiplicadores de 1 a 10. Isso roda por incremento dentro do laço, exceto se o laço for Foreach, o qual exige a existência de uma coleção.
    List
    Array
    Queue
    Stack

    04-Laços:
    For /While =>
    Foreach =>

    05-Algorítimo:
    
*/
namespace Project_KantoNerd_23_50;

class Program
{
    static void Main(string[] args)
    {
        int tabuada;
        tabuada = 8;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"8 * {i} é {tabuada * i};");
        }
    }
}
