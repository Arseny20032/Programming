Bank bnk = Bank.GetBnk("Блаблабла", 34567, 7, 65.5);
Console.WriteLine(bnk.GetName());
Console.WriteLine(bnk.GetSize());
Console.WriteLine(bnk.GetAmount());
Console.WriteLine(bnk.GetBet());

public class Bank
{
    private string name;
    private Contribution contr;
    private static Bank bank;
    private Bank(string name_, int size_, int amount_, double bet_)
    {
        contr = new Contribution(size_, amount_, bet_);
        name = name_;
    }
    public static Bank GetBnk(string name_ = "Какой-то", int size_ = 0, int amount_ = 0, double bet_ = 0)
    {
        if (bank == null)
        {
            bank = new Bank(name_, size_, amount_, bet_);
        }
        return bank;
    }

    public double Payment()
    {
        double result = contr.GetBet() / 100 * contr.GetSize() * contr.GetAmount();
        return result;
    }

    public void DecreaseSize(int value = 1)
    {
        contr.DecreaseSize(value);
    }

    public void IncreaseSize(int value = 1)
    {
        contr.IncreaseSize(value);
    }

    public void IncreaseAmount(int value = 1)
    {
        contr.IncreaseAmount(value);
    }

    public void DecreaseAmount(int value = 1)
    {
        contr.DecreaseAmount(value);
    }

    public void IncreaseBet(double value = 1)
    {
        contr.IncreaseBet(value);
    }

    public void DecreaseBet(double value = 1)
    {
        contr.DecreaseBet(value);
    }

    public void ChangeName(string newname)
    {
        name = newname;
    }

    public int GetSize()
    {
        return contr.GetSize();
    }

    public int GetAmount()
    {
        return contr.GetAmount();
    }

    public double GetBet()
    {
        return contr.GetBet();
    }

    public string GetName()
    {
        return name;
    }
}

class Contribution
{
    private int size;
    private int amount;
    private double bet;

    public Contribution(int _size, int _amout, double _bet)
    {
        size = _size;
        if (size != 0)
            amount = _amout;
        else amount = 0;
        bet = _bet;
    }

    public int GetSize()
    {
        return size;
    }

    public int GetAmount()
    {
        return amount;
    }

    public double GetBet()
    {
        return bet;
    }

    public void DecreaseSize(int value = 1)
    {
        if (size < value)
            size = 0;
        else size -= value;
    }

    public void IncreaseSize(int value = 1)
    {
        size += value;
    }

    public void IncreaseAmount(int value = 1)
    {
        amount += value;
    }

    public void DecreaseAmount(int value = 1)
    {
        if (amount < value)
            amount = 0;
        else amount -= value;
    }

    public void IncreaseBet(double value = 1)
    {
        bet += value;
    }

    public void DecreaseBet(double value = 1)
    {
        if (bet < value)
            bet = 0;
        else bet -= value;
    }

}
