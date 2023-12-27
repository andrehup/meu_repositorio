// Screen Sound

string MensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> {"U2","The Beatles","Pink Floyd","Scorpions"};

Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{8,3,4,10,9});
bandasRegistradas.Add("Beatles", new List<int> ());


void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(MensagemDeBoasVindas);
}
void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();       
    Console.WriteLine("\nDigite 1 para inserir uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas registradas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string OpcaoEscolhida = Console.ReadLine()!;
    int OpcaoEscolhidaNumerica = int.Parse(OpcaoEscolhida);
    switch (OpcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: Console.WriteLine("\nVocê escolheu a opção: " + OpcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("\nTchau Tchau =D");
            break;
        default: Console.WriteLine("\nOpção Inválida");
            break;
    }
}
void ExibirTituloDasOpcoes(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDasOpcoes("Registrar Bandas");
    Console.Write("\nDigite o nome da banda : ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(1000);
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDasOpcoes("Mostrar Bandas Registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"\nBanda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    // Digitar Qual banda deseja Avaliar
    // Descobrir se a banda existe no dicionário>>atribuir nota
    // Se nao existir, voltar ao menu principal

    Console.Clear();
    ExibirTituloDasOpcoes("Avaliar Banda");
    Console.Write("\nDigite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nQual nota a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Thread.Sleep(1000);
        Console.WriteLine($"\nA nota {nota} foi adicionada a banda {nomeDaBanda} com sucesso!");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} ainda não foi registrada");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}

    ExibirOpcoesDoMenu();