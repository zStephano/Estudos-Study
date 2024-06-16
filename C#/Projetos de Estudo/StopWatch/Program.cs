Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Quanto tempo gostaria de cronometrar?");
    Console.WriteLine("Digite a quantidade de dias:");
    short dias = short.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de horas");
    short horas = short.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de minutos");
    short minutos = short.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de segundos");
    short segundos = short.Parse(Console.ReadLine());

    short[] time = [dias, horas, minutos, segundos];

    Cronometro(time);
}

static void Cronometro(short[] times)
{

    short dias = times[0];
    short horas = times[1];
    short minutos = times[2];
    short segundos = times[3];

    short currentTime = 0;

    while (currentTime < dias)
    {
        while (currentTime < horas)
        {
            while (currentTime < minutos)
            {
                while (currentTime < segundos)
                {
                    Console.Clear();
                    Console.WriteLine($"Dias: {dias}, horas: {horas}, minutos: {minutos}, segundos: {segundos}");
                }
            }
        }
    }

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