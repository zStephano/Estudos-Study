Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Quanto tempo gostaria de cronometrar?");
    int time = int.Parse(Console.ReadLine());

    Cronometro(time);
}

static void Cronometro(int time)
{
    int currentTime = 0;

    while (currentTime < time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    FimCronometro();
}

static void FimCronometro()
{
    Console.Clear();
    Console.WriteLine("Tempo cronometrado com sucesso! Gostaria de cronometrar novamente?");
    Console.WriteLine(" 1 - SIM ");
    Console.WriteLine(" 2 - NÃO ");
    int resposta = int.Parse(Console.ReadLine());

    switch(resposta)
    {
        case 1: Menu(); break;
        case 2: System.Environment.Exit(0); break;
    }
}