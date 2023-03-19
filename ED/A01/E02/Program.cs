int num, numAtual, qtdPar;

Console.WriteLine("Digite um número");
num = Convert.ToInt32(Console.ReadLine());
numAtual = 0;
qtdPar = 0;
while(numAtual <= num){
if (numAtual % 2 == 0) {
    Console.WriteLine("Número par: " + numAtual);
    qtdPar++;
}
    numAtual++;
Console.WriteLine("A quantidade de números pares é: " +qtdPar);
}
