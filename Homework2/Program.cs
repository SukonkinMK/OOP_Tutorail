using Homework2;

BankAccount bankAccount1 = new BankAccount();
BankAccount bankAccount2 = new BankAccount(1M);
BankAccount bankAccount3 = new BankAccount(Account_Type.Platinum);
BankAccount bankAccount4 = new BankAccount(10.50M, Account_Type.Gold);
Console.WriteLine(bankAccount1);
Console.WriteLine(bankAccount2);
Console.WriteLine(bankAccount3);
Console.WriteLine(bankAccount4);

Console.ReadLine();