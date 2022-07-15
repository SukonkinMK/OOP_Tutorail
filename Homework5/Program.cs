using Homework5;

var a = new SimpleFractions(2, 3);
var b = new SimpleFractions(-3, -2);
//var c = --a;
Console.WriteLine(a <= b);
Console.WriteLine(a >= b);
Console.WriteLine((int)a);
int h = (int)a;
Console.WriteLine((SimpleFractions)h);


var complex1 = new ComplexNumbers(2,2);
var complex2 = new ComplexNumbers(1,1);
Console.WriteLine($"Сумма {complex1} и {complex2} равна {complex1 + complex2}");
Console.WriteLine($"Разность {complex1} и {complex2} равна {complex1 - complex2}");
Console.WriteLine($"произведение {complex1} и {complex2} равно {complex1 * complex2}");

Console.ReadKey();