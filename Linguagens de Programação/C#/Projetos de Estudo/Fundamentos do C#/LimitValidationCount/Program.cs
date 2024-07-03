// Input dos dados
int[] inputArray = [1, 5, 2, 8];
int[] limitsArray = [2, 5, 4];

// Impressão dos dados através do retorno do método LimitValidationCount
int[] output = LimitValidationCount(inputArray, limitsArray);
Console.WriteLine(string.Join(", ", output)); // Output: 2, 3, 2

int[] LimitValidationCount(int[] inputArray, int[] Limits)
{
    // Intanciamento do result com o tamanho do Limit
    var result = new int[Limits.Length];

    // Ordenação da matriz A, ficando [1, 2, 5, 8]
    Array.Sort(inputArray);

    // Enquanto o i for menor que o tamanho da matriz Limits
    for (int i = 0; i < Limits.Length; i++)
    {
        // Variável limit receberá o valor da posição "i" da matriz Limit
        int limit = Limits[i];

        // A variável count irá percorrer a matriz A enquanto cada valor de A for menor igual ao valor da variável Limit
        int count = inputArray.TakeWhile(a => a <= limit).Count();
        
        // Quando a regra da variável count for atiginda, irá adicionar este valor a posição correspondente de "i"
        result[i] = count;
    }

    // Ao final do método, retornará uma nova matriz correspondendo a conta dos números que são menores de acordo com cada valor do limit
    return result;
}