
/*
Criaçao de função
Função sem parâmetro sem retorno
Função com parâmetro sem retorno
Função sem parâmetro com retorno
função com parâmetro com retorno
*/

/*
Criando uma função que a partir de um número
multiplique por outro valor e apresente o resultado
*/
// System.Console.WriteLine("Exemplo de FUNÇÃO sem " + "Parâmetro e sem retorno\n");
// void Multiplicar() //Construção de uma FUNÇÃO
// {
// System.Console.WriteLine("Digite um número para ser multiplicado: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Digite o número multiplicador");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Resultado = " + n * m);
// }
// Multiplicar();


// System.Console.WriteLine("Exemplo de função com " + "Parâmetro e sem retorno\n");
// void multiplicar(int numero, int multiplicador)
// {
//     System.Console.WriteLine("Resultado = " + numero * multiplicador);
// }
// System.Console.WriteLine("Digite um número: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Digite o número multiplicador: ");
// int m = Convert.ToInt32(Console.ReadLine());
// multiplicar(n, m);




// void multiplicar(int numero, int a)
// {
//     System.Console.WriteLine("Número: " + numero);
//     System.Console.WriteLine("Resultado = " + numero * a);
// }
// System.Console.WriteLine("Digite um número: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Digite o número multiplicador: ");
// int multiplicador = Convert.ToInt32(Console.ReadLine());
// multiplicar(n, multiplicador); //Aqui a função está chamando os argumentos, neste caso os argumentos são 'n, multiplicador'
// System.Console.WriteLine("Término da execução.");


// System.Console.WriteLine("Exemplo de função sem" + "parâmetro e com retorno\n");
// int multiplicar(out int parametro_n)
// {
//     System.Console.WriteLine("Digite um número: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int resultado = n * 2;
//     parametro_n = n;
//     return resultado;
// }
// int r = multiplicar(out int parametro_n);
// System.Console.WriteLine("O resultado de " + parametro_n + " *" + " 2" + " é igual à: " + r);


// System.Console.WriteLine("Exemplo de função com " + "parâmetro e com retorno\n");
// int multiplicar(int n)
// {
//     return n * 2;
// }
// // chamada da função
// System.Console.WriteLine("Digite um número: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Resultado: " + multiplicar(num));
// System.Console.WriteLine("");
// void multiplicar(int numero, int multiplicador)
// {
//     System.Console.WriteLine("Resultado = " + numero * multiplicador);
// }


// (1. (Função sem retorno sem parâmetro) Faça uma função/método que leia dois valores positivos e apresente a soma dos N números existentes entre eles (inclusive).
// Exemplo: 
//     a = 2
//     b = 8
//     2 + 3 + 4 + 5 + 6 + 7 + 8
    // soma = 35

void somafuncao() {
    int num1, num2, agrupamento = 0, soma = 0, i, total = 0;
    System.Console.WriteLine("Digite um número positivo");
    num1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Digite um outro número positivo");
    num2 = Convert.ToInt32(Console.ReadLine());
    for (i = num1; i <= num2; i++){
        total = total + i;
        System.Console.WriteLine(total);
    System.Console.WriteLine("A soma de " +num1 +" e " +total +" é = " + + i++);
    }
    
}
somafuncao();

//  2. (Função sem retorno com parâmetro) Faça uma função/método para calcular a 
//  tabuada de um número informado pelo usuário. Crie outra função que calcule a 
//  tabuada de um intervalo, por exemplo realize as taduabas do 3 ao 8. 
//  Aqui deverá ocorrer para as duas funções, PASSAGEM DE PARÂMETRO POR VALOR.

// void tabuada(int numero){
//     for (int i=0; i >= 0 && i <10; i++) {
//     System.Console.WriteLine(numero +"*" +(i+1) +" = " +numero * (i+1));
//     }
// }
// int n;
// System.Console.WriteLine("Digite um número para calcular sua tábuada: ");
// n = Convert.ToInt32(Console.ReadLine());
// tabuada(n);


// void tabuadaIntervalo(int numero, int intervalo){
//     for (int i=0; i >= 0 && i <intervalo; i++) {
//     System.Console.WriteLine(numero +"*" +(i+1) +" = " +numero * (i+1));
//     }
// }
// int n, inter;
// System.Console.WriteLine("Digite um número para calcular sua tábuada: ");
// n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Digite o intervalo da sua tabuada: ");
// inter = Convert.ToInt32(Console.ReadLine());
// tabuadaIntervalo(n, inter);


//  3. (Função com retorno sem parâmetro) Faça um programa contendo uma 
//  função/método que verifique se um número é par, retorne/mostre o valor bool True para par e False para ímpar.
// int imparOuParcalculo(out int num) {
//     System.Console.WriteLine("Digite um número: ");
//     num = Convert.ToInt32(Console.ReadLine());
//     int calculo = num % 2;
//     return calculo;
// }
// int c = imparOuParcalculo(out int num);
// if (c == 0){
//     System.Console.WriteLine("O número " +num +" é par");
// }
// else {
//         System.Console.WriteLine("O número " +num +" é ímpar");
// }

//  4. (Função com retorno com parâmetro) Faça um programa contendo uma função/método 
//  que receba duas notas (P1, P2) calcule a média, chame outra função na main que avalie 
//  se este aluno esta aprovado ou reprovado retornando a str/string 'Aprovado' ou 'Reprovado'.

int notasMedia(out int p1, out int p2){
    System.Console.WriteLine("Digite uma nota");
    p1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Digite uma outra nota");
    p2 = Convert.ToInt32(Console.ReadLine());
    int media = (p1 + p2) / 2;
    return media;
}
int passouOuNao(out string situacao) {
int sit = notasMedia(out int p1, out int p2);
    if (sit > 6){
        situacao = "Aprovado";
    }
    else {
        situacao = "Reprovado";
    }
    return situacao;
}
int m = notasMedia(out int p1, out int p2);
System.Console.WriteLine("A média do aluno foi: " +m +" e ele foi " +passouOuNao(out int situacao));