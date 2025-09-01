// Program.cs — versão top-level, .NET 9

string? opcao;
bool exibirMenu = true;
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Apagar");
    Console.WriteLine("4 - Sair");

    opcao = Console.ReadLine();

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
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }


}
Console.WriteLine("O programa foi encerrado.");