using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Aula15();
        }

        static void StringInterpolation() // Formas de Interpolação de Strings
        {
            var texto = "Testando " + " ";
            var texto2 = $"Testando {texto}";
            var texto3 = $"Testando {1 + 1}";
            var texto4 = @"\Testando \\";
            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.WriteLine(texto3);
            Console.WriteLine(texto4);
        }

        static void CompareStrings() // Formas de comparar a relatividade das strings, ou seja, ordenação dos objetos - retorna um INT
        {
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando")); // Retorna 1 - Verdadeiro
            Console.WriteLine(texto.CompareTo("testando")); // Retorna 0 - Falso
            Console.WriteLine(texto.CompareTo("")); // Retorna 0 - Falso
            Console.WriteLine(texto.CompareTo(null)); // Retorna 0 - Falso
        }

        static void ContainInString() // Formas de verificar se uma string possui tal dado
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Contains("teste")); // true
            Console.WriteLine(texto.Contains("Teste")); // false
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // true - ignorando case sensitive
            // Console.WriteLine(texto.Contains(null)); // ERRO
        }

        static void StartsAndEndsWithString() // Formas de verificar se um texto começa e/ou termina com
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.StartsWith("Este")); // true
            Console.WriteLine(texto.StartsWith("este")); // false
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // true

            Console.WriteLine(texto.EndsWith("Teste")); // false
            Console.WriteLine(texto.EndsWith("teste")); // true
            Console.WriteLine(texto.EndsWith("teste", StringComparison.OrdinalIgnoreCase)); // true
        }

        static void EqualsString() // Verifica a igualdade das strings, ou seja, comparação de igualdade de valores - retorna um BOOLEANO
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Equals("Este é um texto de teste")); // true
            Console.WriteLine(texto.Equals("este é um texto de teste")); // false
            Console.WriteLine(texto.Equals("este é um texto de teste", StringComparison.OrdinalIgnoreCase)); // true
        }

        static void IndexOfString() // Verifica a posição de um determinado elemento da string
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }

        static void ConvertStringToUpperOrLower() // Conversão de string para maiúsculo ou minúsculo
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
        }

        static void InsertIntoString() // Adiciona mais dados a string de acordo com a posição selecionada
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Insert(5, "AQUI "));
        }

        static void LenghtOfString() // Verifica o tamanho da string - quantidade de caracteres
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Length);
        }

        static void RemoveFromString() // Remove dados da string de acordo com a posição selecionada
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Remove(0, 5));
        }

        static void ReplaceString() // Troca a posição de determinados textos
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Replace("Este", "Isto"));
            Console.WriteLine(texto.Replace("texto", "exemplo"));
        }

        static void SplitString() // Corta/divide a string a partir de um parâmetro
        {
            var texto = "Este é um texto, de teste";
            var divisao = texto.Split(',');
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            // Console.WriteLine(divisao[2]); // ERRO
        }

        static void SubstringUsecase() // Pega uma quantidade X de caracteres dentro de uma string a partir de um range
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Substring(0, 5));
            Console.WriteLine(texto.Substring(texto.LastIndexOf(" ") + 1, 5));
        }

        static void TrimString() // Remove espaços em branco desnecessários na string
        {
            var texto = "Este é           um texto de teste";
            Console.WriteLine(texto.Trim());

            texto = "       Este é um texto de teste             ";
            Console.WriteLine(texto.Trim());
        }

        static void StringBuilderUsecase() // Faz adição das strings uma com a outra de forma dinâmica de forma mais performática
        {
            var texto = new StringBuilder();
            texto.Append("Este");
            texto.Append("é");
            texto.Append("um");
            texto.Append(Environment.NewLine);
            texto.Append("texto");
            Console.WriteLine(texto.ToString());
        }

        static void RegexForString() // Utilização de Regex
        {
            // https://regexr.com/
            var regex = new Regex(@"([0-9])\w+");
            Console.WriteLine(regex.IsMatch("Este é um texto de teste"));
            Console.WriteLine(regex.IsMatch("Este 25 um texto de teste"));
        }

        static void ComparingStrings()
        {
            Console.WriteLine(
                string.Compare(
                    "texto",
                    "texto"));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "Isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreNonSpace));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreNonSpace));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreSymbols));
        }
    }
}