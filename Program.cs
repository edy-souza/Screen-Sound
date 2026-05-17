// Screen Sound
string saudacao = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string>{"U2", "Pink Floyd", "Five"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 7, 9});
bandasRegistradas.Add("Araketu", new List<int>());

void ExibirLogo()
{   
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(saudacao);
        
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 ");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        
        case 2: MostrarBandasRegistradas();
            break;

        case 3: AvaliarUmaBanda();
            break;
        
        case 4: Console.WriteLine("Você escolheu a opção" + " " + opcaoEscolhidaNumerica);
            break;

        case -1: Console.WriteLine("Você escolheu a opção" + " " + opcaoEscolhidaNumerica);
            break;
        
        default: Console.WriteLine("Opção inválida! Tchau Tchau...");
            break;
    }

}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao ("Registro de Bandas");

    Console.Write("Digite o  nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);

    Console.Clear();
    ExibirLogo();
    ExibirOpcoesMenu();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas.");
  
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteristicos}\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandaAvaliada = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(bandaAvaliada))
    {
        Console.Write($"Digite a nota que deseja atribuir para banda: {bandaAvaliada}: ");
        int notaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[bandaAvaliada].Add(notaBanda);
        Console.WriteLine($"\nA nota {notaBanda} da banda {bandaAvaliada} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {bandaAvaliada} ainda não foi registrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

ExibirLogo();
ExibirOpcoesMenu();

