/*
    01-Exercício 20:
    Escreva um algorítimo para imprimir os números de 1 a 10 em ordem crescente.

    02-Algorítimo:
    01-Limpar o console
    02-Criar uma coleção randômica de 10 elementos
    03-Ordenar a coleção
    04-Imprimir a coleção do menor para o maior
Foreach
For
While

List<T>
Array (T[])
Queue<T> = Não aceita índice e portanto não aceita intervaloFila[indice] para recuperar um item da coleção. A propriedade .Peak() somente lê sem alterar o conteúdo da fila. Como a fila, atua em FIFO, somente leitura ficará eternamente lendo o primeiro item, o de índice 0. Para a fila andar é necessário remover o primeiro item e depois ler o novo primeiro item. A função é .Dequeue(), mas isso estragará a fila. Há duas opções:
1-Replicar a fila, manter a fila original intacta e depenar a nova fila.
2-Utilizar um Enumerator que atuará como uma senha, se movimentando ao longo da fila sem depená-la.
Esse problema só surge porque estou forçando a coleção Queue com While o que não é apropriado. O Ideal é somente um Foreach.
Stack<T>
HashSet<T>

Queue<int> intervaloFila = new();

// 1. Criamos uma cópia exata que pode ser destruída
Queue<int> filaTemporaria = new(intervaloFila);

// 2. O laço roda enquanto a cópia não estiver vazia
while (filaTemporaria.Count > 0)
{
    // Dequeue remove da cópia e nos dá o número
    int numero = filaTemporaria.Dequeue(); 
    Console.WriteLine($"Item (via cópia): {numero}");
}

// Sua fila original continua intacta aqui com 10 itens!
Console.WriteLine($"Total na fila original: {intervaloFila.Count}");


xxxxxxx
Queue<int> intervaloFila = new();

// 1. Pedimos um "leitor sequencial" para a fila
using var leitor = intervaloFila.GetEnumerator();

// 2. O método MoveNext() avança para o próximo item e retorna true. 
// Quando chega no fim, ele retorna false e o while para.
while (leitor.MoveNext())
{
    // Leitor.Current pega o valor atual sem remover nada da fila
    int numero = leitor.Current; 
    Console.WriteLine($"Item (via leitor): {numero}");
}

// Sua fila original continua intacta aqui com 10 itens!
Console.WriteLine($"Total na fila original: {intervaloFila.Count}");



*/
namespace Project_KantoNerd_20_50;

class Program
{
    static void Main(string[] args)
    {
        //Declarar variáveis:
        string duplo = new('=', 90);
        List<int> intervalo = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]; //Suporta collection expression
        int[] intervaloMatriz = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        Queue<int> intervaloFila = new([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]); //não suporta collection expression.

        Console.Clear();

        //Código Caso 01 - 01|01|01 = Pré-Ordenada| Lista de inteiros| Foreach:
        Console.WriteLine($"{"",0}{duplo,60}");
        Console.WriteLine("");
        Console.WriteLine("Caso 01 - 01|01|01 = Pré-Ordenada| Lista de inteiros| Foreach:");
        int indice = 0;
        foreach (var item in intervalo)
        {
            Console.WriteLine($"Imprimindo item {indice}, contendo valor {item}");
            indice++;
        }
        Console.WriteLine("Fim Caso 01 - 01|01|01 = Pré-Ordenada| Lista de inteiros| Foreach.");
        Console.WriteLine($"{"",0}{duplo,60}");

        //Código Caso 02 - 01|01|02 = Pré-Ordenada| Lista de inteiros| For:
        Console.WriteLine("");
        Console.WriteLine("Caso 02 - 01|01|02 = Pré-Ordenada| Lista de inteiros| For:");
        for (int indiceFor = 0; indiceFor <= intervalo.Count - 1; indiceFor++)
        {
            Console.WriteLine($"Imprimindo item {indiceFor}, contendo valor {intervalo[indiceFor]}");
        }
        Console.WriteLine("Fim Caso 02 - 01|01|02 = Pré-Ordenada| Lista de inteiros| For:");
        Console.WriteLine($"{"",0}{duplo,60}");

        //Código Caso 03 - 01|01|03 = Pré-Ordenada| Lista de inteiros| While:
        Console.WriteLine("");
        Console.WriteLine("Caso 03 - 01|01|03 = Pré-Ordenada| Lista de inteiros| While:");
        int indiceWhile = intervalo.Count - 1;
        //O meu racional me levou a criar um Console.WriteLine com sequencia invertida. Farei o próximo com sequencia desejada.
        while (indiceWhile >= 0)
        {
            Console.WriteLine($"Imprimindo item {indiceWhile}, contendo valor {intervalo[indiceWhile]}");
            indiceWhile--;
        }
        Console.WriteLine("Fim Caso 03 - 01|01|03 = Pré-Ordenada| Lista de inteiros| While.");
        Console.WriteLine($"{"",0}{duplo,60}");

        //Código Caso 03_02 - 01|01|03_02 = Pré-Ordenada| Lista de inteiros| While_02:
        Console.WriteLine("");
        Console.WriteLine("Caso 03_02 - 01|01|03_02 = Pré-Ordenada| Lista de inteiros| While_02:");
        int indiceWhile_2 = 0;
        //O meu racional me levou a criar um Console.WriteLine com sequencia invertida. Farei o próximo com sequencia desejada.
        while (indiceWhile_2 < intervalo.Count)
        {
            Console.WriteLine($"Imprimindo item {indiceWhile_2}, contendo valor {intervalo[indiceWhile_2]}");
            indiceWhile_2++;
        }
        Console.WriteLine("Fim Caso 03_02 - 01|01|03_02 = Pré-Ordenada| Lista de inteiros| While_02.");
        Console.WriteLine($"{"",0}{duplo,60}");

        //Código Caso 04 - 01|02|01 = Pré-Ordenada| Matriz de inteiros| Foreach:
        Console.WriteLine("");
        Console.WriteLine("Caso 04 - 01|02|01 = Pré-Ordenada| Matriz de inteiros| Foreach:");
        indice = 0; //Não precisa criar novamente. Só reestabelecer o valor de início.
        foreach (var item in intervaloMatriz)
        {
            Console.WriteLine($"Imprimindo item {indice}, contendo valor {item}");
            indice++;
        }
        Console.WriteLine("Fim Caso 04 - 01|02|01 = Pré-Ordenada| Matriz de inteiros| Foreach.");
        Console.WriteLine($"{"",0}{duplo,60}");

        //Código Caso 05 - 01|02|02 = Pré-Ordenada| Matriz de inteiros| For:
        //Mudou a propriedade .Count para .Length.
        Console.WriteLine("");
        Console.WriteLine("Caso 05 - 01|02|02 = Pré-Ordenada| Matriz de inteiros| For:");
        for (int indiceFor = 0; indiceFor <= intervaloMatriz.Length - 1; indiceFor++)
        {
            Console.WriteLine($"Imprimindo item {indiceFor}, contendo valor {intervaloMatriz[indiceFor]}");
        }
        Console.WriteLine("Fim Caso 05 - 01|02|02 = Pré-Ordenada| Matriz de inteiros| For.");
        Console.WriteLine($"{"",0}{duplo,60}");

        //Código Caso 06 - 01|02|03 = Pré-Ordenada| Matriz de inteiros| While:
        Console.WriteLine("");
        Console.WriteLine("Caso 06 - 01|02|03 = Pré-Ordenada| Matriz de inteiros| While:");
        indiceWhile = intervaloMatriz.Length - 1;
        //O meu racional me levou a criar um Console.WriteLine com sequencia invertida. Farei o próximo com sequencia desejada.
        while (indiceWhile >= 0)
        {
            Console.WriteLine($"Imprimindo item {indiceWhile}, contendo valor {intervaloMatriz[indiceWhile]}");
            indiceWhile--;
        }
        Console.WriteLine("Fim Caso 06 - 01|02|03 = Pré-Ordenada| Matriz de inteiros| While.");
        Console.WriteLine($"{"",0}{duplo,60}");

        //Código Caso 06_02 - 01|02|03_02 = Pré-Ordenada| Matriz de inteiros| While_02:
        Console.WriteLine("");
        Console.WriteLine("Caso 06_02 - 01|02|03_02 = Pré-Ordenada| Matriz de inteiros| While_02:");
        indiceWhile_2 = 0;
        //O meu racional me levou a criar um Console.WriteLine com sequencia invertida. Farei o próximo com sequencia desejada.
        while (indiceWhile_2 < intervaloMatriz.Length)
        {
            Console.WriteLine($"Imprimindo item {indiceWhile_2}, contendo valor {intervaloMatriz[indiceWhile_2]}");
            indiceWhile_2++;
        }
        Console.WriteLine("Fim Caso 06_02 - 01|02|03_02 = Pré-Ordenada| Matriz de inteiros| While_02.");
        Console.WriteLine($"{"",0}{duplo,60}");


        //Código Caso 07 - 01|03|01 = Pré-Ordenada| Queue de inteiros| Foreach:
        Console.WriteLine($"{"",0}{duplo,60}");
        Console.WriteLine("");
        Console.WriteLine("Caso 07 - 01|01|01 = Pré-Ordenada| Queue de inteiros| Foreach:");
        indice = 0;
        foreach (var item in intervaloFila)
        {
            Console.WriteLine($"Imprimindo item {indice}, contendo valor {item}");
            indice++;
        }
        Console.WriteLine("Fim Caso 07 - 01|01|01 = Pré-Ordenada| Queue de inteiros| Foreach.");
        Console.WriteLine($"{"",0}{duplo,60}");


        //Código Caso 08 - 01|03|02 = Pré-Ordenada| Queue de inteiros| For:
        Console.WriteLine("");
        Console.WriteLine("Caso 08 - 01|03|02 = Pré-Ordenada| Queue de inteiros| For:");
        for (int indiceFor = 0; indiceFor <= intervaloFila.Count - 1; indiceFor++)
        {
            Console.WriteLine($"Imprimindo item {indiceFor}, contendo valor {intervalo[indiceFor]}");
        }
        Console.WriteLine("Fim Caso 08 - 01|03|02 = Pré-Ordenada| Queue de inteiros| For:");
        Console.WriteLine($"{"",0}{duplo,60}");
        //

        //Código Caso 09 - 01|03|03 = Pré-Ordenada| Queue de inteiros| While:
        Console.WriteLine("");
        Console.WriteLine("Caso 09 - 01|03|03 = Pré-Ordenada| Queue de inteiros| While:");
        indiceWhile = intervaloFila.Count - 1;
        //O meu racional me levou a criar um Console.WriteLine com sequencia invertida. Farei o próximo com sequencia desejada.
        while (indiceWhile >= 0)
        {
            Console.WriteLine($"Imprimindo item {indiceWhile}, contendo valor {intervaloFila.Peek()}");
            indiceWhile--;
        }
        Console.WriteLine("Fim Caso 09 - 01|03|03 = Pré-Ordenada| Lista de inteiros| While.");
        Console.WriteLine($"{"",0}{duplo,60}");
        /*
                //Código Caso 03_02 - 01|01|03_02 = Pré-Ordenada| Lista de inteiros| While_02:
                Console.WriteLine("");
                Console.WriteLine("Caso 03_02 - 01|01|03_02 = Pré-Ordenada| Lista de inteiros| While_02:");
                int indiceWhile_2 = 0;
                //O meu racional me levou a criar um Console.WriteLine com sequencia invertida. Farei o próximo com sequencia desejada.
                while (indiceWhile_2 < intervalo.Count)
                {
                    Console.WriteLine($"Imprimindo item {indiceWhile_2}, contendo valor {intervalo[indiceWhile_2]}");
                    indiceWhile_2++;
                }
                Console.WriteLine("Fim Caso 03_02 - 01|01|03_02 = Pré-Ordenada| Lista de inteiros| While_02.");
                Console.WriteLine($"{"",0}{duplo,60}");
        */

        //While 2 ordenação crescente na matriz. Depois fazer Queue. Stack não faz sentido.

        Console.WriteLine("Fim de Tudo ==== Fim de Tudo ==== Fim de Tudo ==== Fim de Tudo");


    }
}
