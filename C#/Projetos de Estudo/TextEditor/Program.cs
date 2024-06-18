using System.IO;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir arquivo de texto");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("0 - Sair");
    short option = short .Parse(Console.ReadLine());

    switch (option)
    {
        case 1: Open(); break;
        case 2: Edit(); break;
        case 0: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Open()
{
    Console.Clear();
    Console.WriteLine("Qual caminho do arquivo?");
    string path = Console.ReadLine();

    string textOpen = "";

    using (var file = new StreamReader(path))
    {
        textOpen = file.ReadToEnd();
        Console.Write(textOpen);

        Console.WriteLine("------------------------");
        Console.WriteLine("Deseja continuar escrevendo neste arquivo?");
        Console.WriteLine("1 - SIM // 2 NÃO");
        short option = short.Parse(Console.ReadLine());
        
        switch (option)
        {
            case 1: ContinuousEditing(textOpen, file); break;
            case 2: Menu(); break;
        }

    }
}

static void Edit()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
    Console.WriteLine("------------------------");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape) ;

    Save(text);
}

static void ContinuousEditing(string textfile, StreamReader file)
{
    Console.Clear();
    Console.Write(textfile);

    do
    {
        textfile += Console.ReadLine();
        textfile += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Save(textfile);
}

static void Save(string text)
{
    Console.Clear();
    Console.WriteLine("Qual caminho para salvar o arquivo?");
    var path = Console.ReadLine();

    if (File.Exists(path))
    {
        ReplaceFile(path);
    }
    else
    {
        using (var filePath = new StreamWriter(path))
        {

            filePath.Write(text);
        }
    }

    Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    Console.ReadLine();
    Menu();
}

static void ReplaceFile(string filePath)
{
    Console.WriteLine($"Um arquivo já existe neste diretório {filePath}, deseja substitui-lo?");
    Console.WriteLine("1 - SIM // 2 - NÃO");
    short option = short.Parse(Console.ReadLine());

    if (option == 1)
    {
        File.Replace(filePath, filePath, null);
    }
    else if (option == 2)
    {
        Console.WriteLine("Gostaria de voltar ao menu principal?");
        Console.WriteLine("1 - SIM // 2 - NÃO (o programa será encerrado)");
        short optionTwo = short.Parse(Console.ReadLine());

        switch (optionTwo)
        {
            case 1: Menu(); break;
            case 2: System.Environment.Exit(0); break;
        }

    }
}

