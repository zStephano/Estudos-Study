using System.Net.Http.Headers;

string inputOne = "###$$$1234*";
string inputTwo = "abc@12#ef$";
Console.WriteLine(ReverseString(inputOne));
Console.WriteLine(ReverseString(inputTwo));

static string ReverseString(string data)
{
    char [] chars = data.ToCharArray();
    int leftPointer = 0, rightPointer = data.Length - 1;
    while(leftPointer < rightPointer)
    {
        if (Char.IsLetterOrDigit(chars[leftPointer]))
        {
            if (Char.IsLetterOrDigit(chars[rightPointer]))
            {
                char temp = chars[leftPointer];
                chars[leftPointer] = chars[rightPointer];
                chars[rightPointer] = temp;
                leftPointer++;
                rightPointer--;
            }
            else
            {
                rightPointer--;
            }
        }
        else
        {
            leftPointer++;
        }
    }
    return new string(chars);
}