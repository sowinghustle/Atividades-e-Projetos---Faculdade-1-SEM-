int n, numAtual, soma;
Console.WriteLine("Digite um número");
n = Convert.ToInt32(Console.ReadLine());
numAtual = 1;
soma = 0;
    for (numAtual = 1; numAtual <= n; numAtual++){
        Console.WriteLine(numAtual + "");
        soma = soma + numAtual;
    }
    Console.WriteLine("A soma dos " +n +" Números naturais é: " +soma);