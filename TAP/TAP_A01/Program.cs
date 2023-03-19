// Console.WriteLine("exemplo de operador ternário");
// double media = 6;
// if (media > 0)
//     System.Console.WriteLine("Aprovado");
// else
//     System.Console.WriteLine("Reprovado");


// utilizando o operador ternário
// System.Console.WriteLine(media >=6 ? "Aprovado": "Reprovado");

// System.Console.WriteLine("\n\nExemplo do Switch... Case");
// System.Console.WriteLine("1 - Primavera \n2 - Verão \n3 - Outone \n4 - Inverno");
// System.Console.WriteLine("Digite a estação desejada:");
// int estacao = Convert.ToInt32(Console.ReadLine());
// switch (estacao)
// {
//     case 1:
//         System.Console.WriteLine("Primavera");
//         break;
//     case 2:
//         System.Console.WriteLine("Verão");
//         break;
//     case 3:
//         System.Console.WriteLine("Outono");
//         break;
//     case 4:
//         System.Console.WriteLine("Inverno");
//         break;
//     default:
//         System.Console.WriteLine("Estação inexistente!");
//         break;
// }

// exemplo do FOR
// Console.WriteLine("Exemplo do For");
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine("7 x " + i + " = " + 7 * i);
// }

// exemplo com while
// System.Console.WriteLine("Exemplo com while");
// int i = 1;
// while (i <= 10)
// {
//     Console.WriteLine("7 x " + i + " = " + 7 * i);
//     i++;
// }

// exemplo com DO WHILE 
// System.Console.WriteLine("Exemplo com DO WHILE");
// int i = 1;
// do
// {
//     Console.WriteLine("7 x " + i + " = " + 7 * i);
//     i++;
// } while (i <= 10);


// exemplo com WHILE e menu
// System.Console.WriteLine("Exemplo com WHILE interrompido pelo usuário");
// int op = Menu();

// int Menu()
// {
//     Console.WriteLine("While interrompido pelo usuário");
//     Console.WriteLine("\nMenu");
//     Console.WriteLine("1 - Soma");
//     Console.WriteLine("2 - Subtração");
//     int op = Convert.ToInt32(Console.ReadLine());
//     return op;
// }
// while (op >= 1 && op <= 2)
// {
//     if (op == 1)
//         Console.WriteLine("Calculando a Soma");

//     else if (op == 2)
//         Console.WriteLine("Calculando a Subtração");
//     op = Menu();

// }

// System.Console.WriteLine("Exemplo com DO WHILE interrompido pelo usuário");
// int op = Menu();

// int Menu()
// {
//     Console.WriteLine("While interrompido pelo usuário");
//     Console.WriteLine("\nMenu");
//     Console.WriteLine("1 - Soma");
//     Console.WriteLine("2 - Subtração");
//     Console.WriteLine("Digite a opção desejada");
//     int op = Convert.ToInt32(Console.ReadLine());
//     return op;
// }
// do
// {
//     op = Menu();
//     if (op == 1)
//         Console.WriteLine("Calculando a Soma");
//     else if (op == 2)
//         Console.WriteLine("Calculando a Subtração");
// }
// while (op >= 1 && op <= 2);



//calculo de média de idades usando DO WHILE
// int idade = 0, media = 0, quant = 0, idade_ac = 0;
// do
// {
//     Console.WriteLine("Digite a idade de um aluno");
//     idade = Convert.ToInt32(Console.ReadLine());
//     idade_ac = idade + idade_ac;
//     quant++;
// }while (idade > 0);
// Console.WriteLine(quant);
// media = idade_ac / (quant-1);
// Console.WriteLine("A média das idades digitadas é: " + media);


//CALCULO DE MÉDIA DE IDADES USANDO WHILE
int idade = 0, media = 0, quant = 0, idade_ac = 0;
string usu_input;
Console.WriteLine("Digite uma idade");
usu_input = Console.ReadLine();
while (!usu_input.Equals(".")) {
    idade = Convert.ToInt32(usu_input);
    idade_ac = idade + idade_ac;
    quant++;
    Console.WriteLine("Digite uma idade");
}

media = idade_ac / quant;
Console.WriteLine("A média das idades digitadas é: " + media);