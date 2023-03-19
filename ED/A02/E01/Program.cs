//                  REVISÃO
// Dado um número inteiro positivo N, calcule e mostre para o usuário o fatorial de N
// class exerc4Correcao{}
// int n, fat = 1, i;
// Console.WriteLine("Digite o valor de N: ");
// n = Convert.ToInt32(Console.ReadLine());
// for (i = 1; i <= n; i++)
// {
//     fat = fat * i;
// }
// Console.WriteLine("Fatorial = " + fat);





//                  VETORES

// Exemplo da utilização da variável estruturada VETOR/ARRAY
// A estrutura para se criar um VETOR é: 'tipo de dado'[] 'nome' = new 'tipo de dado'['numero'];
// exemplo: float[] nome = new float[10];
// namespace codigos
// {
//     class inicializacao
//     {
//         int[] temperaturas = { 19, 7, 12, 5 };
//         string[] alunos = { "Bruno", "Cristiano", "Cássio" };
//     }
// }




//acessando posições do vetor
// acesso indexado (Feito por meio de um indíce)
// int[] vetor = new int[3]; //posições 0,1,2
// vetor[0] = 10;
// vetor[1] = 7;
// vetor[2] = 12;
// System.Console.WriteLine("Elementos do vetor");
// System.Console.WriteLine("Comandos do vetor: '0' => 10" + "\n'1' => 7" + "\n'2' => 12");

// Código para que seja exibido os elementos dentro do VETOR em ordem, utilizando estrutura de repetição FOR.
// int i;
// int[] vetor = { 14, 16, 18, 20 };
// for (i = 0; i < vetor.Length; i++)
// {
//     Console.WriteLine(vetor[i]);
// }



// Código para digitar o tamanho de um vetor, seus elementos, e por fim, exibir todos elemtos do vetor em questão.
// int n, vetor_dados, quant_elemento = -1;
// System.Console.WriteLine("Digite o tamanho do Vetor");
// n = Convert.ToInt32(Console.ReadLine());
// int[] vetor = new int[n];
// for (int i = 0; i < vetor.Length; i++)
// {
//     System.Console.WriteLine("Digite um elemento do vetor: ");
//     vetor[i] = Convert.ToInt32(Console.ReadLine());
//     vetor_dados = vetor[i];
// }
// for (int i = 0; i < vetor.Length; i++)
// {
//     quant_elemento++;
//     System.Console.WriteLine("O elemento da posição '" + quant_elemento + "' deste Vetor é: " + vetor[i]);
// }


// Código para se calcular a média dos elementos do Vetor utilizando FOR.
// int n, vetor_dados, quantidade_repeticao = 0;
// double valores_pra_media = 0, media = 0.0d;
// System.Console.WriteLine("Digite o tamanho do Vetor");
// n = Convert.ToInt32(Console.ReadLine());
// int[] vetor = new int[n];
// for (int i = 0; i < vetor.Length; i++)
// {
//     System.Console.WriteLine("Digite um elemento do vetor: ");
//     vetor[i] = Convert.ToInt32(Console.ReadLine());
//     vetor_dados = vetor[i];
//     quantidade_repeticao++;
//     valores_pra_media = valores_pra_media + vetor[i];
// }
// media = valores_pra_media / quantidade_repeticao;
// // outra forma de se calcular Média seria: media = valores_pra_media / vetor.Length;
// System.Console.WriteLine("A média de todos valores dentro do vetor é igual à: " + media);



//Algoritmo que leia N números inteiros e armazene cada um deles em um vetor,
//por fim, percorra o vetor para encontrar o maior número persente no conjunto e mostre-o para o usuário

// int n, comparacao, valorA, ValorN, maior, menor;
// System.Console.WriteLine("Quantidade de números a serem adicionados no Vetor: ");
// n = Convert.ToInt32(Console.ReadLine());
// int[] vetor = new int[n];
// for (int i = 0; i < n; i++)
// {
//     System.Console.WriteLine("Digite um elemento do vetor: ");
//     vetor[i] = Convert.ToInt32(Console.ReadLine());
//     if (i == 0)
//     {
//         valorA = vetor[i];
//     }
//     if (i > 0)
//     {
//         ValorN = vetor[i];
//         if (valorA > ValorN)
//         {

//         }
//     }
// }


// int maior_atual = -99999999, n;
// Console.WriteLine("Digite o tamanho do vetor: ");
// n = Convert.ToInt32(Console.ReadLine());
// int[] vetor = new int[n];
// for (int i = 0; i < vetor.Length; i++)
// {
//     System.Console.WriteLine("Digite um elemento do vetor: ");
//     vetor[i] = Convert.ToInt32(Console.ReadLine());

// }
// for (i = 0; i < vetor.Length; i++)
// {
//     if (vetor[i] > maior_atual)
//     {
//         maior_atual = vetor[i];
//     }
// }
// Console.WriteLine("Maior = " + maior_atual);


/* 1) Faça um algoritmo, em linguagem C#, que crie um vetor com n números inteiros e que permita o
usuário inserir cada um dos números, por fim, imprima os números armazenados no vetor em ordem
inversa */
// int n;
// System.Console.WriteLine("Digite o tamanho do Vetor");
// n = Convert.ToInt32(Console.ReadLine());
// int[] vetor = new int[n];
// for (int i = 0; i < vetor.Length; i++)
// {
//     System.Console.WriteLine("Digite um elemento do vetor: ");
//     vetor[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = n - 1; i >= 0; i--)
// {
//     System.Console.WriteLine("O elemento da posição " + (i + 1) + " deste Vetor é: " + vetor[i]);
// }

/*5) Faça um algoritmo, em linguagem C#, que crie um vetor com n números inteiros e que permita o
usuário inserir cada um dos números, por fim, utilizando um único laço de repetição, encontre e exiba
o MAIOR e o MENOR dos números inseridos. */
// int maior_atual = int.MinValue, n, menor_atual = int.MaxValue;
// Console.WriteLine("Digite o tamanho do vetor: ");
// n = Convert.ToInt32(Console.ReadLine());
// int[] vetor = new int[n];
// for (int i = 0; i < vetor.Length; i++)
// {
//     System.Console.WriteLine("Digite um elemento do vetor: ");
//     vetor[i] = Convert.ToInt32(Console.ReadLine());
//     if (vetor[i] > maior_atual)
//     {
//         maior_atual = vetor[i];
//     }
//     if (vetor[i] < menor_atual)
//     {
//         menor_atual = vetor[i];
//     }
// }
// Console.WriteLine("O Maior número deste vetor é: " + maior_atual + " E o menor número do mesmo é: " + menor_atual);

/* 7) Faça um algoritmo, em linguagem C#, que crie um vetor com n números inteiros e que permita o
usuário inserir cada um dos números, por fim, obtenha e exiba a soma e a multiplicação dos números
pares presentes no vetor e a respectiva quantidade de números pares. */
int n, soma = 0, multiplicacao = 1;
Console.Write("Digite o tamanho do vetor: ");
n = Convert.ToInt32(Console.ReadLine());
int[] vetor = new int[n];
for (int i = 0; i < vetor.Length; i++)
{
    System.Console.Write("\nDigite um elemento do vetor: ");
    vetor[i] = Convert.ToInt32(Console.ReadLine());
    if (vetor[i] % 2 == 0)
    {
        multiplicacao = multiplicacao * vetor[i];
        // Console.Write($"{multiplicacao} * {vetor[i]} = {multiplicacao}");

        soma = soma + vetor[i];
        Console.WriteLine($" || {soma} + {vetor[i]} = {soma}");
    }
}

System.Console.WriteLine("\nA soma de todos os números pares inseridos no vetor é: " + soma + "\nA multiplicação de todos números pares inseridos no vetor é: " + multiplicacao);


