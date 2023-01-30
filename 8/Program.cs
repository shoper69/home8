using System.Text;

bool Compare(string a, string b)
{
    if (a.Length == b.Length)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }

        return true;
    }

    return false;
}

void Analyze(string str, out int numOfAlpha, out int numOfDigits, out int numOfSpec)
{
    numOfAlpha = 0;
    numOfDigits = 0;
    numOfSpec = 0;
    foreach (var ch in str)
    {
        if (char.IsLetter(ch)) numOfAlpha++;
        else if (char.IsDigit(ch)) numOfDigits++;
        else numOfSpec++;
    }
}

string Sort(string str)
{
    StringBuilder result = new StringBuilder(str.ToLower());
    int n = result.Length;
    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (result[j] > result[j + 1])
            {
                (result[j], result[j + 1]) = (result[j + 1], result[j]);
            }

    return result.ToString();
}

char[] Duplicate(string str)
{
    str = str.ToLower();
    List<char> result = new List<char>();
    for (int i = 0; i < str.Length - 1; i++)
    {
        for (int j = i + 1; j < str.Length; j++)
        {
            if (str[i] == str[j])
            {
                result.Add(str[i]);
            }
        }
    }

    return result.ToArray();
}

Console.WriteLine(Compare("Denis", "Denis"));
Analyze("Denis123!+_", out int alpha, out int digits, out int spec);
Console.WriteLine("Alpha: "+ alpha +"digits: " + digits + "spec: " + spec);
Console.WriteLine(Sort("Hello"));
char[] arr = Duplicate("Hello and hi");
foreach (var ch in arr)
{
    Console.WriteLine(ch);
}