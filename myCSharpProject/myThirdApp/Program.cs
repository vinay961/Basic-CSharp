class BankAccount{
    private decimal balance;

    public BankAccount(decimal initialBalance){
        balance = initialBalance;
    }

    // Method to deposite money into account
    public void Deposite(decimal amount){
        if(amount > 0){
            balance += amount;
            System.Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            System.Console.WriteLine("Amount must be greater than zero!");
        }
    }

    // Method to withdraw money from bankaccount
    public void withdraw(decimal amount){
        if(amount > 0){
            balance -= amount;
            System.Console.WriteLine($"{amount} withdraw!!");
        }
        else{
            System.Console.WriteLine("Amount to withdraw must be greater than greater than 0.");
        }
    }

    // method to check current Balance
    public void getBalance(){
        System.Console.WriteLine("...Account...");
        System.Console.WriteLine($"..Balance: {balance}..");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount bank = new BankAccount(1000);
        bank.getBalance();
        bank.Deposite(250);
        bank.withdraw(600);
        bank.getBalance();
    }
}