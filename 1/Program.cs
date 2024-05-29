string[] input = Console.ReadLine().Split(", ").ToArray();
List<string> validNames = new List<string>();

for(int i = 0; i < input.Length; i++)
{
    if (Checker(input[i]))
    {
        validNames.Add(input[i]);
    }
}

static bool Checker(string m)
{
    foreach (char n in m)
    {
        if (char.IsLetterOrDigit(n) || n == '-' || n == '_')
        {
            if (m.Length < 15 && m.Length > 2)
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }

    }

    return true;
}

foreach (var name in validNames)
{
    Console.WriteLine(name);
}
