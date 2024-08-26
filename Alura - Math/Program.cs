// See https://aka.ms/new-console-template for more information
using math_exercicio;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

Console.WriteLine("Informe qual operação você deseja executar: ");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
short opcao = short.Parse(Console.ReadLine());

Console.WriteLine("Informe o primeiro número da operação: ");
double numero1 = double.Parse(s: Console.ReadLine());

Console.WriteLine("Informe o segundo número da operação: ");
double numero2 = double.Parse(s: Console.ReadLine());

//var add = new Adicao();
//var sub = new Subtracao();
//var mult = new Multiplicacao();
//var div = new Divisao();

switch (opcao)
{
    case 1: Console.WriteLine("A soma dos fatores é: "+Adicao.getAdicao(numero1, numero2)); break;
    case 2: Console.WriteLine("A subtração dos fatores é: "+Subtracao.getSubtracao(numero1, numero2)); break;
    case 3: Console.WriteLine("A multiplicação dos fatores é: "+Multiplicacao.getMultiplicao(numero1, numero2)); break;
    case 4: Console.WriteLine("A divisão dos fatores é: "+Divisao.getDivisao(numero1, numero2)); break;
    default: Console.WriteLine("Opção incorreta"); break;
}


