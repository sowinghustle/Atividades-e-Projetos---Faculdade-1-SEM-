


// (1. (Função sem retorno sem parâmetro) Faça uma função/método que leia dois valores positivos e apresente a soma dos N números existentes entre eles (inclusive).
// Exemplo: 
//     a = 2
//     b = 8
//     2 + 3 + 4 + 5 + 6 + 7 + 8
    // soma = 35

// void somafuncao() {
//     int num1, num2, i, total = 0;
//     System.Console.WriteLine("Digite um número positivo");
//     num1 = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Digite um outro número positivo");
//     num2 = Convert.ToInt32(Console.ReadLine());
//     for (i = num1; i <= num2; i++){
//         total = total + i;
//         System.Console.WriteLine(total);

//     }
//         System.Console.WriteLine("A soma de todos números entre" +num1 +" e " +num2 +" é = " + total);
// }
// somafuncao();

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
// bool imparOuParcalculo() {
//     System.Console.WriteLine("Digite um número: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int calculo = num % 2;
//     if (calculo == 0){
//     return true;
// }
// else {
//         return false;
// }

// }

//     System.Console.WriteLine(imparOuParcalculo());



//  4. (Função com retorno com parâmetro) Faça um programa contendo uma função/método 
//  que receba duas notas (P1, P2) calcule a média, chame outra função na main que avalie 
//  se este aluno esta aprovado ou reprovado retornando a str/string 'Aprovado' ou 'Reprovado'.

// double notasMedia( double par1, double par2){
//     double media = (par1 + par2) / 2;
//     return media;
// }
// string passouOuNao() {
//     if (media >= 6){
//          return "Aprovado";
//     }
//     else {
//            return "Reprovado";
//     }
// }
//     System.Console.WriteLine("Digite uma nota");
//    double p1 = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Digite uma outra nota");
//    double p2 = Convert.ToInt32(Console.ReadLine());
// double m = notasMedia( p1, p2);
// System.Console.WriteLine("A média do aluno foi: " +m +" e ele foi " +passouOuNao());