int idade = 10;
int maioridade = 18;
int idadeMaxima = 100;

// Condicional com IF
if (idade >= maioridade && idade <= idadeMaxima)) // Validando se a idade é MAIOR OU IGUAL que a maioridade e MENOR OU IGUAL idade máxima.
{
    Console.WriteLine("É maior de idade");
}
else if (idade > idadeMaxima) // SE NÃO SE a idade é MAIOR que a idade máxima
{
	Console.WriteLine("É maior que a idade máxima permitida");
}
else // Caso seja menor de idade
{
    Console.WriteLine("É menor de idade");
}


// Condicional comum com NOT
if (!(idade <= maioridade)) // Validando se a idade NÃO é MENOR que a maioridade.
{
    Console.WriteLine("É maior de idade");
}
else // Caso seja menor de idade
{
    Console.WriteLine("É menor de idade");
}


// Condicional invertida
if (idade <= maioridade) // Validando SE a idade é MENOR que a maioridade.
	return; // SE sim, encerra aqui.

//SE não, seguirá as linhas de código normalmente.
Console.WriteLine("É maior de idade");


// Condicional com SWITCH
int valor = 1;
switch (valor)
{
	case 1: Console.WriteLine($"O valor é {valor}"); break;
	case 2: Console.WriteLine($"O valor é {valor}"); break;
	case 3: Console.WriteLine($"O valor é {valor}"); break;
	default: Console.WriteLine($"O valor é {valor}"); break;
}

string nome = "stephano";
switch (nome)
{
	case "joao": Console.WriteLine($"O {nome} que você procura está aqui"); break;
	case "marcelo": Console.WriteLine($"O {nome} que você procura está aqui"); break;
	case "stephano": Console.WriteLine($"O {nome} que você procura está aqui"); break;
	default: Console.WriteLine($"O {nome} que você procura não está aqui"); break;
}

// Condicional - Laço de Repetição: FOR
for(var i = 0; i <= 5; i++)
{
	
}

// Condicional - Laço de Repetição: WHILE
var valor = 0;
while (valor <= 5)
{
	// Nesta ordem, será exibido os números de 0 a 5.
	Console.WriteLine(valor);
	valor++;
}

while (valor <= 5)
{
	// Nesta ordem, será exibido os números de 1 a 6.
	valor++;
	Console.WriteLine(valor);
}

while (true) // Nesta condicional, será exibido e repetido infinitamente e/ou até o delimitador do tipo da variável.
{
	valor++;
	Console.WriteLine(valor);
}

// Condicional - Laço de Repetição: DO
var valor = 0;
do
{
	Console.WriteLine("Teste");
	valor++;
} while (valor < 5);