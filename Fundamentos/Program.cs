using Fundamentos.Common.Models;

int[] arrayInteiros = new int[5];

arrayInteiros[0] = 72;
arrayInteiros[1] = 85;
arrayInteiros[2] = 23;
arrayInteiros[3] = 56;
arrayInteiros[4] = 91;

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

int valorPosicao = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Valor de cada posição do array: {valorPosicao} - {valor}");
    valorPosicao++;
}



