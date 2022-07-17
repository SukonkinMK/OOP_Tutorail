using Homework7;

var a = new ACoder();
var b = new BCoder();
string s = "A B C a b c Z z А а Б б Алфавит Alphabet Я я";
string s_encode1 = a.Encode(s);
Console.WriteLine(s_encode1);
string s_decode1 = a.Decode(s_encode1);
Console.WriteLine(s_decode1);

string s_encode2 = b.Encode(s);
Console.WriteLine(s_encode2);
string s_decode2 = b.Decode(s_encode2);
Console.WriteLine(s_decode2);
Console.ReadLine();