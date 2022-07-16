namespace Homework2;

public enum Account_Type { 
    Base,
    Silver,
    Gold,
    Platinum
}

public class BankAccount
{
    private static int CurrentAmountOfAccouts = 1;
    private static int CreateAccountId()
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

    /// <summary>
    /// Пополнение баланса банковского счета
    /// </summary>
    /// <param name="sum">сумма пополнения</param>
    public void AddMoney(decimal sum)
    {
        balance += sum;
    }

    /// <summary>
    /// Снятие с банковского счета
    /// </summary>
    /// <param name="sum">запрашиваемая сумма</param>
    public bool PullOfMoney(decimal sum)
    {
        if(sum <= balance)
        {
            balance -= sum;
            return true;
        }
        return false;
    }
    public bool Transfer(BankAccount account, decimal sum)
    {
        if(account.Balance < sum)
        {
            return false;
        }
        else
        {
            account.PullOfMoney(sum);
            this.AddMoney(sum);
            return true;
        }
    }

    public static bool operator ==(BankAccount lhs, BankAccount rhs)
    {
        return lhs.Balance == rhs.Balance && lhs.AccountType == rhs.AccountType;
    }

    public static bool operator !=(BankAccount lhs, BankAccount rhs)
    {
        return !(lhs == rhs);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;
        if(obj.GetType() != typeof(BankAccount))
            return false;
        BankAccount other = (BankAccount)obj;
        return other.Balance == this.Balance && other.AccountType == this.AccountType;
    }
    public override int GetHashCode()
    {
        var hash = 0x18d;

        unchecked
        {
            hash = (hash * 0x18d) ^ Balance.GetHashCode();
            hash = (hash * 0x18d) ^ AccountType.GetHashCode();
        }
        
        return hash;
    }
}
