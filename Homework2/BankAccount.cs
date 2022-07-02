namespace Homework2;

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
    }
    public decimal Balance
    {
        get { return balance; }
    }
    public Account_Type AccountType
    {
        get { return accountType; }
    }
    public override string ToString()
    {
        return $"Account № {Id}; balance: {Balance}$; type: {AccountType}";
    }

    public BankAccount() : this(0M, Account_Type.Base)
    {
    }
    public BankAccount(decimal balance): this(balance, Account_Type.Base)
    {
    }
    public BankAccount(Account_Type type): this(0M, type)
    {
    }
    public BankAccount(decimal balance, Account_Type type)
    {
        id = CreateAccountId();
        this.balance = balance;
        this.accountType = type;
    }
}
