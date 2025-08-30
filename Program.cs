using Fundamentos.Models;
/*public class Program
{
    static void Main()
    {
        // Testando a classe Pessoa
        Pessoa pessoa1 = new Pessoa("João", 15);
        pessoa1.Apresentar();

    }

*/

/*Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();


switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Consoante");
        break;
}
*/
/*DisplayCharacter('K');  // Output: A lowercase letter: f
DisplayCharacter('7');  // Output: An uppercase letter: R
DisplayCharacter('8');  // Output: A digit: 8
DisplayCharacter('u');  // Output: Not alphanumeric character: ,

void DisplayCharacter(char ch)
{
    if (char.IsUpper(ch))
    {
        Console.WriteLine($"An uppercase letter: {ch}");
    }
    else if (char.IsLower(ch))
    {
        Console.WriteLine($"A lowercase letter: {ch}");
    }
    else if (char.IsDigit(ch))
    {
        Console.WriteLine($"A digit: {ch}");
    }
    else
    {
        Console.WriteLine($"Not alphanumeric character: {ch}");
    }
}*/


/*if (letra == "a" ||
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
*/

/*namespace ProdutividadeEmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int vitoria;
            vitoria = 1;
            Console.WriteLine(++vitoria);


            vitoria = 1;
            Console.WriteLine(vitoria++);

            Console.WriteLine(vitoria);
        }
    }
}
12
Calculadora calc = new Calculadora();
calc.Somar(5, 3);
calc.Subtrair(5, 3);
calc.Multiplicar(5, 3);
calc.Dividir(5, 3);
*/

namespace ProdutividadeEmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo	de	incremento	em	1
            /*for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 5; i += 2)
            {
                Console.WriteLine(i);
            }
*/
            {
                int i = 1;
                while (i < 5)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }


        }
    }
}