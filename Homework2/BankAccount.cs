﻿namespace Homework2;

public enum Account_Type { 
    Base,
    Silver,
    Gold,
    Platinum
}

public class BankAccount
{
    static int CurrentAmountOfAccouts = 1;
    static int CreateAccountId()
    {
        int id = CurrentAmountOfAccouts;
        CurrentAmountOfAccouts++;
        return id;
    }

    private int id;
    private decimal balance;
    private Account_Type accountType;

    public int Id
    {
        get { return id; }
        set 
        { 
            id = CreateAccountId();
        }
    }
    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }
    public Account_Type AccountType
    {
        get { return accountType; }
        set { accountType = value; }
    }
    public override string ToString()
    {
        return $"Account № {Id}; balance: {Balance}$; type: {AccountType}";
    }
}
