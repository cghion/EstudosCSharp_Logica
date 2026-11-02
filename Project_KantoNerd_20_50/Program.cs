/*
    01-Exercício 20:
    Escreva um algorítimo para imprimir os números de 1 a 10 em ordem crescente.

    02-Algorítimo:
    01-Limpar o console
    02-Criar uma coleção randômica de 10 elementos
    03-Ordenar a coleção
    04-Imprimir a coleção do menor para o maior

*/
namespace Project_KantoNerd_20_50;

class Program
{
    static void Main(string[] args)
    {

        string duplo = new string('=', 90);
        var intervalo = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int indice = 0;
        Console.Clear();
        Console.WriteLine($"{"",0}{duplo,60}");
        Console.WriteLine("");
        Console.WriteLine("Caso 01:");
        Console.WriteLine("Entrada = Ordenada");
        Console.WriteLine("Coleção = Lista de inteiros");
        Console.WriteLine("Tipo de Loop = Foreach");
        Console.WriteLine("Ordenação = N/A");
        foreach (var item in intervalo)
        {
            Console.WriteLine($"Imprimindo item {indice}, contendo valor {item}");
            indice++;
        }
        Console.WriteLine("Fim Caso 01.");
        Console.WriteLine($"{"",0}{duplo,60}");


        Console.WriteLine("");
        Console.WriteLine("Caso 02:");
        Console.WriteLine("Entrada = Ordenada");
        Console.WriteLine("Coleção = Lista de inteiros");
        Console.WriteLine("Tipo de Loop = Foreach");
        Console.WriteLine("Ordenação = N/A");
        for (int indiceFor = 0; indiceFor <= intervalo.Count; indiceFor++)
        {
            Console.WriteLine($"Imprimindo item {indiceFor}, contendo valor {intervalo[indiceFor]}");

        }
        Console.WriteLine("Fim Caso 02.");
        Console.WriteLine($"{"",0}{duplo,60}");


    }
}
