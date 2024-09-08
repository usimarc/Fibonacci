// See https://aka.ms/new-console-template for more information
int posicao1 = 0;
int posicao2 = 1;
int posicao3 = 0;
int posicaoLista = 0;

Console.WriteLine("Vamos descobrir de seu número está contido na lista de Fibonacci");
Console.WriteLine("Insira um número inteiro e digite 'ENTER'");
int buscarNumero = int.Parse(Console.ReadLine());
Console.WriteLine("");

while (posicao3 <= buscarNumero)
{
    Console.WriteLine(posicao3);
    posicao3 = posicao1 + posicao2;
    posicao1 = posicao2;
    posicao2 = posicao3;
    posicaoLista++;
}
if (posicao1 == buscarNumero)
{
    Console.WriteLine($"\n Seu número esta na lista, é o {buscarNumero} e ocupa a {posicaoLista}º posição da sequência de Fibonacci.");
}
else
{
    Console.WriteLine("\n Seu número não está na sequência de Fibonacci");
}


