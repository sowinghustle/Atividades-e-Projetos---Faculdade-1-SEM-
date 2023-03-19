int num, numAtual;
Console.WriteLine("Digite um número");
num = Convert.ToInt32(Console.ReadLine());

numAtual = 1;
while(numAtual <= num) {
    Console.Write(numAtual + ", ");
    numAtual++;
}

Console.WriteLine(" A soma dos " +num +" primeiros números é: " + num);