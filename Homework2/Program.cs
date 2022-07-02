using Homework2;

BankAccount bankAccount = new BankAccount();
bankAccount.Id = 1;
bankAccount.Balance = 10.50M;
bankAccount.AccountType = Account_Type.Platinum;
Console.WriteLine(bankAccount);

Console.ReadLine();