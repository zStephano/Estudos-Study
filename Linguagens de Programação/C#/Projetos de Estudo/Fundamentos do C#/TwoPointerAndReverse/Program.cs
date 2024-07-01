// Input dos dados
string inputOne = "###$$$1234*";
string inputTwo = "abc@12#ef$";

// Impressão dos dados através do método ReverseString
Console.WriteLine(ReverseString(inputOne));
Console.WriteLine(ReverseString(inputTwo));

static string ReverseString(string data)
{
    // Converte o data paraa um Char Array
    char [] chars = data.ToCharArray();

    // Instanciamento dos pointers Left e Right
    int leftPointer = 0, rightPointer = data.Length - 1;

    // Enquanto os pointers não se encontrarem (for menor que o outro)
    while(leftPointer < rightPointer)
    {
        // Se o pointer Left for letra ou dígito
        if (Char.IsLetterOrDigit(chars[leftPointer]))
        {
            // Se o pointer Right for letra ou dígito
            if (Char.IsLetterOrDigit(chars[rightPointer]))
            {
                // Então instancia a variável local do tipo CHAR - temp e passo os caracteres do pointer Left
                char temp = chars[leftPointer];
                
                // Passo os valores (se letra ou dígito) do pointer Right para o pointer Left
                chars[leftPointer] = chars[rightPointer];

                // Passo os valores da variável local temp para o pointer Right
                chars[rightPointer] = temp;

                // Avanço +1 da posição atual do Left Pointer e -1 da posição atual do Right Pointer
                leftPointer++;
                rightPointer--;
            }
            else
            {
                // Se o pointer Right não for letra ou dígito, avança -1 da posição atual
                rightPointer--;
            }
        }
        else
        {
            // Se o pointer Left não for letra ou dígito, avança +1 da posição atual
            leftPointer++;
        }
    }
    // Retorno os valores revertidos do array CHARS criado neste método
    return new string(chars);
}