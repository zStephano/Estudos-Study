using System.Timers;

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

    OnTimerEvent(dias, horas, minutos, segundos);

}

static void OnTimerEvent(short dias, short horas, short minutos, short segundos)
{
    short currentTime = 0;
    short diasOnTimer = 0;
    short horasOnTimer = 0;
    short minutosOnTimer = 0;
    short segundosOnTimer = 0;

    while (segundosOnTimer != segundos
        || minutosOnTimer != minutos
        || horasOnTimer != horas
        || diasOnTimer != dias)
    {
        Console.Clear();
        currentTime++;
        segundosOnTimer = currentTime;
        if (segundosOnTimer == 60)
        {
            minutosOnTimer++;
            currentTime = 0;
            segundosOnTimer = 0;
        }
        if (minutosOnTimer == 60)
        {
            horasOnTimer++;
            minutosOnTimer = 0;
        }
        if (horasOnTimer == 24)
        {
            diasOnTimer++;
            horasOnTimer = 0;
        }
        Console.WriteLine($"Dias: {diasOnTimer}, horas: {horasOnTimer}, minutos: {minutosOnTimer}, segundos: {segundosOnTimer}");
        Thread.Sleep(10);

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

    switch (resposta)
    {
        case 1: Menu(); break;
        case 2: System.Environment.Exit(0); break;
    }
}