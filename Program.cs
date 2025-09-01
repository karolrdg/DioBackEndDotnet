// Program.cs — versão top-level, .NET 9

string? opcao;

while (true)
{
    Console.Clear();
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Apagar");
    Console.WriteLine("4 - Sair");

    opcao = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(opcao))
    {
        Console.WriteLine("Opção inválida");
        Console.WriteLine();
        continue;
    }

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar");
            break;
        case "2":
            Console.WriteLine("Listar");
            break;
        case "3":
            Console.WriteLine("Apagar");
            break;
        case "4":
            Console.WriteLine("Sair");
            return; // encerra o programa sem Environment.Exit
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine();
}
