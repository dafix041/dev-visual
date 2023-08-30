int tamanho = 20;
int[] vetor = new int[tamanho];
int auxiliar;
Random random = new Random();

Console.Clear();

for (int i = 0; i < tamanho; i++)
{
    vetor[i] = random.Next(1, 5000);
}

ImprimirVetor();

// Array.Sort(vetor);
bool troca = false;
do
{
    troca = false;
    for (int i = 0; i < tamanho - 1; i++)
    {
        if (vetor[i] > vetor[i + 1])
        {
            auxiliar = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = auxiliar;
            troca = true;
        }
    }
} while (troca);

ImprimirVetor();

void ImprimirVetor()
{
    for (int i = 0; i < tamanho; i++)
    {
        Console.Write(vetor[i] + " ");
    }
    Console.WriteLine("\n");
}