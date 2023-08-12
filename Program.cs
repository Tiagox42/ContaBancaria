// See https://aka.ms/new-console-template for more information

using ContaBancaria;
using System.Globalization;

Conta operacao;

Console.WriteLine("Bem vindo ao banco Dantas!");
Console.WriteLine("Digite o número da conta:");
int conta = int.Parse(Console.ReadLine());
Console.WriteLine("Entre o titular da conta:");
string nome = Console.ReadLine();
Console.WriteLine("Haverá depósito inicial (s/n)?");
char inicial = char.Parse(Console.ReadLine());
double valorInicial = 0;
if (inicial == 's' || inicial == 'S')
{
    Console.WriteLine("Entre o valor de depósito inicial:");
    valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    operacao = new Conta(conta, nome, valorInicial);
}
else
{
    operacao = new Conta(conta, nome);
}
Console.WriteLine("Dados da conta:");
Console.WriteLine(operacao);

Console.WriteLine("Entre um valor para depósito:");
double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
operacao.Deposito(deposito);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(operacao);

Console.WriteLine("Entre um valor para saque:");
double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
operacao.Saque(saque);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(operacao);

Console.WriteLine("-----------------\nDeseja alterar o nome de sua conta? (s/n)?");
char opcaoNome = char.Parse(Console.ReadLine());
if (opcaoNome == 's' || opcaoNome == 'S')
{
    Console.WriteLine("Digite o novo nome da conta:");
    string novoNome = Console.ReadLine();
    operacao.Nome = novoNome;
    Console.WriteLine("Dados da conta atualizados:");
    Console.WriteLine(operacao);
}
