// See https://aka.ms/new-console-template for more information

string pastelzao = RetornaPastel("Frango com Catupiry");
Console.WriteLine(pastelzao);
static void MeuMetodo()
{
    Console.WriteLine("Meu pastel é mais barato");
}

static string RetornaPastel(
    string tipo,
    string tamanho = " Médio",
    string acompanhamento = " nenhum")
{
    return  tipo + tamanho + acompanhamento;
}