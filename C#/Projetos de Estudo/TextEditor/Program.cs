using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir arquivo de texto");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("0 - Sair");
    short option = short.Parse(Console.ReadLine());

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

    string textOpen = ReadFile(path);

    Console.Write(textOpen);

    Console.WriteLine("------------------------");
    Console.WriteLine("Deseja continuar escrevendo neste arquivo?");
    Console.WriteLine("1 - SIM // 2 NÃO");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 1: ContinuousEditing(textOpen); break;
        case 2: Menu(); break;
    }
}

static string ReadFile(string filePath)
{
    string textOpen;
    var fileStream = new FileStream(filePath, FileMode.Open,
    FileAccess.Read); //open text file
    //vvv read text file (or however you implement it like here vvv
    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
    {
        textOpen = streamReader.ReadToEnd();
    }
    //finally, close text file
    fileStream.Close();
    return textOpen;
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
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Save(text);
}

static void ContinuousEditing(string textfile)
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
        ReplaceFile(path, text);
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

static void ReplaceFile(string filePath, string textFile)
{
    Console.WriteLine($"Um arquivo já existe neste diretório {filePath}, deseja substitui-lo?");
    Console.WriteLine("1 - SIM // 2 - NÃO");
    short option = short.Parse(Console.ReadLine());

    if (option == 1)
    {
        File.Delete(filePath);
        using (var path = new StreamWriter(filePath))
        {

            path.Write(textFile);
        }
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

