// 1) Implemente um algoritmo, que mostre todos os números ímpares entre 0 e 200.
// int numAtual;
// numAtual = 1;

// while (numAtual > 0 && numAtual < 200)
// {
//     if (numAtual % 2 != 0)
//     {
//         Console.WriteLine(numAtual + ", ");
//     }
//     numAtual++;
//     Console.WriteLine("Esses são todos números ímpares entre 0 e 200.");
// }

// 2) Implemente um algoritmo, que dado um número inteiro positivo n. Imprima a soma dos n primeiros
// números ímpares de 0 até n
// int n, soma, numAtual;
// soma = 0;
// numAtual = 1;
// Console.WriteLine("Digite um número inteiro positivo:");
// n = Convert.ToInt32(Console.ReadLine());
// if (n > 0)
// {
//     for (numAtual = 1; numAtual > 0 && numAtual < n; numAtual++)
//     {
//         if (numAtual % 2 != 0)
//         {
//             soma = soma + numAtual;
//         }

//     }
//     Console.WriteLine("A soma dos " + n + " Primeiros números ímpares é: " + soma);
// }
// else
// {
//     Console.WriteLine("O número digitado não é positivo.");
// }


// 3) Implemente um algoritmo, que dado dois números inteiros positivos a e b calcule 𝐚
// 𝐛
// (a elevado a b).
// Observação: Não utilize a função Math.pow(a,b) faça utilizando laço de repetição.

// int num_a, num_b, pot, qtdNum;
// Console.WriteLine("Digite um número inteiro positivo de sua escolha: ");
// num_a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite um segundo número inteiro positivo de sua escolha: ");
// num_b = Convert.ToInt32(Console.ReadLine());
// if (num_a > 0 && num_b > 0)
// {
//     pot = num_a;
//     qtdNum = 1;
//     for (qtdNum = 1; qtdNum < num_b; qtdNum++)
//     {
//         pot = pot * num_a;
//     }
//     Console.WriteLine("O primeiro número elevado ao segundo número é igual à: " + pot);
// }
// else
// {
//     Console.WriteLine("Os valores inseridos não são números inteiros positivos!");
// }



// 4) Implemente um algoritmo, que dado um número inteiro positivo n, calcule e exiba o fatorial desse
// número. Obs: Exemplo, se n = 5, o fatorial do número 5 é 120, ou seja 5! = 5 * 4 * 3 * 2 * 1

// int num, fat, qtdNum;
// Console.Write("Digite um número inteiro positivo de sua escolha: ");
// num = Convert.ToInt32(Console.ReadLine());
// fat = num;
// qtdNum = num--;
// if (num > 0)
// {
//     for (qtdNum = num--; qtdNum > 0; qtdNum--)
//     {
//         fat = fat * qtdNum;
//     }
//     Console.WriteLine("O fatorial do número digitado é: " + fat);
// }
// else
// {
//     Console.WriteLine("O valor inserido não é um número inteiro positivo!");
// }


// 5) Implemente um algoritmo, que dado um número inteiro positivo p, verificar se esse número é um
// número primo.

// int p, qtdNum, totalDividendos;
// System.Console.WriteLine("Digite um número inteiro positivo qualquer: ");
// p = Convert.ToInt32(Console.ReadLine());
// if (p > 0)
// {
//     qtdNum = 1;
//     totalDividendos = 0;
//     for (qtdNum = 1; qtdNum < p; qtdNum++)
//     {
//         if (p % qtdNum == 0)
//         {
//             totalDividendos++;
//         }
//     }
//     if (totalDividendos >= 2)
//     {
//         Console.WriteLine(p + " É um número composto");
//     }
//     else
//     {
//         Console.WriteLine(p + " É um número primo");
//     }
// }