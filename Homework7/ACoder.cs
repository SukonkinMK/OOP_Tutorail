namespace Homework7;

public class ACoder : IСoder
{
    private readonly char[] alphabetSymbolEndings = { 'Z', 'z', 'я', 'Я' };
    private readonly char[] alphabetSymbolStartings = { 'А', 'а', 'A', 'a' };
    public string Decode(string s)
    {
        if (s is null)
        {
            return null!;
        }
        var chars = s.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (alphabetSymbolStartings.Contains(chars[i]) == false)
            {
                chars[i]--;
            }
            else
            {
                switch (chars[i])
                {
                    case 'A':
                        chars[i] = 'Z';
                        break;
                    case 'a':
                        chars[i] = 'z';
                        break;
                    case 'А':
                        chars[i] = 'Я';
                        break;
                    case 'а':
                        chars[i] = 'я';
                        break;
                }
            }
        }
        return new(chars);
    }

    public string Encode(string s)
    {
        if(s is null)
        {
            return null!;
        }
        var chars = s.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (alphabetSymbolEndings.Contains(chars[i]) == false)
            {
                chars[i]++;
            }
            else
            {
                switch (chars[i])
                {
                    case 'Z':
                        chars[i] = 'A';
                        break;
                    case 'z':
                        chars[i] = 'a';
                        break;
                    case 'Я':
                        chars[i] = 'А';
                        break;
                    case 'я':
                        chars[i] = 'а';
                        break;
                }
            }
        }
       return new(chars);
    }
}
