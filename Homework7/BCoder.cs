namespace Homework7;

public class BCoder : IСoder
{
    public string Decode(string s)
    {
       return Encode(s);
    }

    public string Encode(string s)
    {
        if (s is null)
        {
            return null!;
        }
        var chars = s.ToCharArray();
        CodeArray(chars);
        return new(chars);
    }
    private char ShiftLetter(char endAlphabetSymbol, char startAlphabetSymbol, char shiftingLetter)
    {
        return (char)(endAlphabetSymbol - (shiftingLetter - startAlphabetSymbol));
    }

    private void CodeArray (char[] chars)
    {
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] >= 'A' && chars[i] <= 'Z')
            {
                chars[i] = ShiftLetter('Z', 'A', chars[i]);
            }
            else if (chars[i] >= 'a' && chars[i] <= 'z')
            {
                chars[i] = ShiftLetter('z', 'a', chars[i]);
            }
            else if (chars[i] >= 'А' && chars[i] <= 'Я')
            {
                chars[i] = ShiftLetter('Я', 'А', chars[i]);
            }
            else if (chars[i] >= 'a' && chars[i] <= 'я')
            {
                chars[i] = ShiftLetter('я', 'а', chars[i]);
            }
        }
    }
}
