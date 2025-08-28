
using Fundamentos.Models; // importa a classe Pessoa

/*public class Program
{
    static void Main()
    {
        // Testando a classe Pessoa
        Pessoa pessoa1 = new Pessoa("João", 15);
        pessoa1.Apresentar();

    }

*/

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

if (letra == "a" ||
letra == "e" ||
letra == "i" ||
letra == "o" ||
letra == "u")
{
    Console.WriteLine("Vogal");
}

else
{
    Console.WriteLine("Consoante");
}


