Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Qual o operador matemático que deseja utilizar?");
    Console.WriteLine(" 1 - Soma");
    Console.WriteLine(" 2 - Subtração");
    Console.WriteLine(" 3 - Multiplicação");
    Console.WriteLine(" 4 - Divisão");
    Console.WriteLine(" 5 - Sair");
    short opMatematico = short.Parse(Console.ReadLine());

    if (opMatematico == 5)
        System.Environment.Exit(0);

    Console.WriteLine("Quantos conjuntos de números deseja calcular?");
    short quantidade = short.Parse(Console.ReadLine());

    var quantidadeLista = QuantidadeListada(quantidade);

    switch (opMatematico)
    {
        case 1: Soma(quantidadeLista); break;
        case 2: Subtracao(quantidadeLista); break;
        case 3: Multiplicacao(quantidadeLista); break;
        case 4: Divisao(quantidadeLista); break;
        default: Menu(); break;
    }
}

static List<decimal> QuantidadeListada(short quantidade)
{
    List<decimal> vList = new List<decimal>();
    for (short i = 1; i <= quantidade; i++)
    {
        Console.WriteLine($"Digite o {i} valor: ");
        decimal v1 = decimal.Parse(Console.ReadLine());
        vList.Add(v1);
    }
    return vList;
}
static void Soma(List<decimal> quantidadeListada)
{
    decimal resultado = 0;

    foreach (decimal valor in quantidadeListada)
    {
        resultado = resultado + valor;
    }

    Console.WriteLine($"O resultado da soma dos número é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Subtracao(List<decimal> quantidadeListada)
{
    decimal resultado = 0;

    foreach (decimal valor in quantidadeListada)
    {
        resultado = resultado - valor;
    }

    Console.WriteLine($"O resultado da subtração dos número é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao(List<decimal> quantidadeListada)
{
    decimal resultado = 1;

    foreach (decimal valor in quantidadeListada)
    {
        resultado = resultado * valor;
    }

    Console.WriteLine($"O resultado da multiplicação dos número é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Divisao(List<decimal> quantidadeListada)
{
    decimal resultado = 1;

    foreach (decimal valor in quantidadeListada)
    {
        resultado = valor / resultado;
    }

    Console.WriteLine($"O resultado da divisão dos número é: {resultado}");
    Console.ReadKey();
    Menu();
}
