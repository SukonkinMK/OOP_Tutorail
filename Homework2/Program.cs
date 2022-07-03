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

Console.ReadLine();