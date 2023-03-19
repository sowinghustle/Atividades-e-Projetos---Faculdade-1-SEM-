// Implemente um algoritmo, que mostre todos os números ímpares entre 0 e 200.
int numAtual;
numAtual = 1;
for (numAtual = 1; numAtual > 0 && numAtual < 200; numAtual++) ;
{
    if (numAtual % 2 != 0)
    {
        Console.WriteLine(numAtual + ", ");
        numAtual++;
    }
    Console.WriteLine("Esses são os números ímpares entre 0 e 200");
}