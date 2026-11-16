/*

    A partir deste ponto deixarei de introduzir complexidade e focarei apenas na lógica, deixarei de lado a inserção de dados e seus tratamentos. Foco total no centro do problema.
    A introdução de complexidade estava desviando o estudo de lógica. Preciso evoluir com a lógica e com os demais conceitos como classe/método/API/DTO/ORM/etc.
    *****************************************************************************************

    01-Exercício 22:
    Ler um valor N e imprimir todo os valores inteiros entre 1, inclusive, e N, inclusive. Considere que o N será sempre maior que zero.

    02-Algorítimo:
    01-Limpar o console
    02-Solicitar número inteiro maior que zero.
    03-Validar a entrada.
    04-Armazenar em uma variável para armazenar a entrada.
    05-Criar laço While ou For com condição "Enquanto a variavel do laço for menor ou igual à variável digitada, imprima a variável do laço. A cada passagem incrementar um inteiro na variável do laço." .

Foreach = Percorre uma coleção, sem coleção não há Foreach.
For e While são intercambeáveis, um substitui o outro. Ambos avaliam uma expressão booleana, ambos são no fundo uma condição IF.
For = A variável é declarada no cabeçalho e só existe dentro do laço.
While = A variável é declarada fora do bloco e pode ser acessada dentro do bloco e fora do bloco.
*/


namespace Project_KantoNerd_22_50;

class Program
{
    static void Main(string[] args)
    {

        int entrada;
        int i;
        entrada = 5;
        i = 1;
        while (i <= entrada)
        {
            Console.WriteLine($"Solução via While. O número digitado é {entrada}. Imprimindo o número {i}. Restam {entrada - i} impressões.");
            i++;
        }
    }
}
