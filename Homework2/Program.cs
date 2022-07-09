using Homework2;

BankAccount bankAccount1 = new BankAccount();
BankAccount bankAccount2 = new BankAccount(1M);
BankAccount bankAccount3 = new BankAccount(Account_Type.Platinum);
BankAccount bankAccount4 = new BankAccount(10.50M, Account_Type.Gold);
Console.WriteLine(bankAccount1);
Console.WriteLine(bankAccount2);
Console.WriteLine(bankAccount3);
Console.WriteLine(bankAccount4);

Console.WriteLine();
bankAccount4.AddMoney(20M);
//Console.WriteLine(bankAccount4);
//bankAccount4.PullOfMoney(50M);
//bankAccount4.PullOfMoney(30M);
//Console.WriteLine(bankAccount4);


bool result1 = bankAccount3.Transfer(bankAccount4, 20M);
bool result2 = bankAccount3.Transfer(bankAccount4, 20M);


string str1 = "Hello World!";
Console.WriteLine("Before: {0}, after {1}", str1, Reverse(str1));


string path = @"c:\Users\Михаил\source\repos\OOP_Tutorail\Homework2\";
string inputFile = "inputFile.txt";
string outputFile = "outputFile.txt";
string inputPath = Path.Combine(path, inputFile);
string outputPath = Path.Combine(path, outputFile);
if (File.Exists(inputPath))
{
    StreamReader stream = new StreamReader(inputPath);
    while (!stream.EndOfStream)
    {
        string inputLine = stream.ReadLine();
        string[] inputLines = inputLine.Split('&');
        for (int i = 1; i < inputLines.Length; i++)
        {
            SearchMail(ref inputLines[i]);
        }
        for (int i = 1; i < inputLines.Length; i++)
        {
            File.AppendAllText(outputPath, inputLines[i] + "\n");
        }

    }
}
else
{
    Console.WriteLine("Не удалось открыть файл {0}", inputPath);
}



Console.ReadLine();

/// <summary>
/// Переворот строки
/// </summary>
static string Reverse(string input)
{
    char[] chars = input.ToCharArray();
    for (int i = 0; i < chars.Length / 2; i++)
    {
        char tmp;
        tmp = chars[i];
        chars[i] = chars[chars.Length - 1 - i];
        chars[chars.Length - 1 - i] = tmp;
    }
    return new string(chars);
}

static void SearchMail(ref string s)
{
    s = s.Trim();
    string[] strArr = s.Split(' ');
    s = strArr[0];
}