using Fundamentos.Common.Models;

// List<string> estados = new List<string>();

// estados.Add("SP");
// estados.Add("MG");
// estados.Add("BA");
// estados.Add("RJ");
// Console.WriteLine($"Quantidade de estados: {estados.Count} - {estados.Capacity}");

// estados.Add("SC");
// Console.WriteLine($"Quantidade de estados: {estados.Count} - {estados.Capacity}");






// // for (int contador = 0; contador < estados.Count; contador++)
// // {
// //     Console.WriteLine($"Estado: {estados[contador]}");
// // }

// // int indice = 0;
// // foreach (string estado in estados)
// // {
// //     Console.WriteLine($"Estado: {estado}");
// //     indice++;


class Programa
{
    static void Main()
    {
        string? entrada = Console.ReadLine();

        // TODO: Verifique se a entrada é igual a "basico"
        if (entrada == "basico")
        {
            // Imprime a recomendação para o plano básico
            Console.WriteLine("Recomendado: plano basico");
        }

        // TODO: Caso contrário, verifique se a entrada é igual a "intermediario"
        else if (entrada == "intermediario")
        {
            // TODO: Se for, imprima a recomendação para o plano intermediario
            Console.WriteLine("Recomendado: plano intermediario");
        }

        // TODO: Se não for nenhum dos anteriores, verifique se é "avancado" ou "premium"

        else if (entrada == "avancado" || entrada == "premium")
        {
            Console.WriteLine("Recomendado: plano avancado");
        }
    }
}

















// int[] arrayInteiros = new int[5];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 85;
// arrayInteiros[2] = 23;
// arrayInteiros[3] = 56;
// arrayInteiros[4] = 91;



// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }

// // int valorPosicao = 0;
// // foreach (int valor in arrayInteiros)
// // {
// //     Console.WriteLine($"Valor de cada posição do array: {valorPosicao} - {valor}");
// //     valorPosicao++;
// // }



