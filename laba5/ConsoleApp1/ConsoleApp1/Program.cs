using System;

namespace task
{
    public enum cliient
    {
        rich,
        poor
    }

    public class Bank
    {
        private string name;
        private static Bank bank;
        private Bank_Contribution contribution;
        private Bank(string name_1, int size_1, int amount_1, double bet_1)
        {
            contribution = new Bank_Contribution(size_1, amount_1, bet_1);
            name = name_1;
        }

        public static Bank GetNewBank(string name = "ddddddd", int size = 0, int amount = 0, double bet = 0)
        {
            if (bank == null)
            {
                return bank = new Bank(name, size, amount, bet);
            }
            else
                return bank;

        }
        public double Payment()
        {
            double result = contribution.GetBet() / 100 * contribution.GetAmount();
            return result;
        }
        public void IncreaseSize(int value = 1)
        {
            contribution.IncreaseSize(value);
        }
        public void DecreaseSize(int value = 1)
        {
            contribution.DecreaseSize(value);
        }
        public void IncreaseAmount(int value = 1)
        {
            contribution.IncreaseAmount(value);
        }
        public void DecreaseAmount(int value = 1)
        {
            contribution.DecreaseAmount(value);
        }
        public void IncreaseBet(double value = 1)
        {
            contribution.IncreaseBet(value);
        }
        public void DecreaseBet(double value = 1)
        {
            contribution.DecreaseBet(value);
        }
        public void ChangeName(string NewName)
        {
            name = NewName;
        }
        public string GetName()
        {
            return name;
        }
        public int GetSize()
        {
            return contribution.GetSize();
        }
        public int GetAmount()
        {
            return contribution.GetAmount();
        }
        public double GetBet()
        {
            return contribution.GetBet();
        }
    }

    public class client_Contribution
    {
        private string name;
        private int amount;
        private double bet;
        private cliient cl;
        public static client_Contribution client;
        public client_Contribution(cliient cl_1, string name_1, int amount_1, double bet_1)
        {
            name = name_1;
            amount = amount_1;
            bet = bet_1;
            cl = cl_1;
        }
        public static client_Contribution GetNewClient(cliient cl, string name = "name", int amount = 0, double bet = 0)
        {
             client = new client_Contribution (cl, name, amount, bet);
            return client;
        }
        

        public string GetName()
        {
            return name;
        }

        public int GetAmount()
        {
            return amount;
        }
        public double GetBet()
        {
            return bet;
        }

        public void IncreaseAmount(int value = 1)
        {
            amount += value;
        }
        public void DecreaseAmount(int value = 1)
        {
            if (amount < value)
            {
                amount = 0;
            }
            else
                amount -= value;
        }
        public void IncreaseBet(double value = 1)
        {
            bet += value;
        }
        public void DecreaseBet(double value = 1)
        {
            if (bet < value)
            {
                bet = 0;
            }
            else
                bet -= value;
        }

        public double Payment()
        {
            double result = GetBet() / 100 * GetAmount();
            return result;
        }
    }

    public class Bank_Contribution
    {
        private int size;
        private int amount;
        private double bet;

        public Bank_Contribution(int size_1, int amount_1, double bet_1)
        {
            size = size_1;
            if (size != 0)
            {
                amount = amount_1;
            }
            else
                amount = 0;
            bet = bet_1;
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

        public void IncreaseSize(int value = 1)
        {
            size += value;
        }

        public void DecreaseSize(int value = 1)
        {
            if (size < value)
            {
                size = 0;
            }
            else
                size -= value;
        }
        public void IncreaseAmount(int value = 1)
        {
            amount += value;
        }
        public void DecreaseAmount(int value = 1)
        {
            if (amount < value)
            {
                amount = 0;
            }
            else
                amount -= value;
        }
        public void IncreaseBet(double value = 1)
        {
            bet += value;
        }
        public void DecreaseBet(double value = 1)
        {
            if (bet < value)
            {
                bet = 0;
            }
            else
                bet -= value;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = Bank.GetNewBank("BnbBank", 1000, 500, 5.5);
            Console.WriteLine(bank.GetName());
            Console.WriteLine(bank.GetSize());          //число вкладов 
            Console.WriteLine(bank.GetAmount());        //размер ставки
            Console.WriteLine(bank.GetBet());           //ставка
            Console.WriteLine();
            cliient cl = cliient.poor;
            client_Contribution a = client_Contribution.GetNewClient (cl, "Artem Bobrov", 200, 2);

            Console.WriteLine(a.GetName());
            Console.WriteLine(a.GetAmount());
            Console.WriteLine(a.GetBet());
            Console.WriteLine(a.Payment() + " %");
            Console.WriteLine(" ");
            cliient cl_1 = cliient.rich;
            client_Contribution b = client_Contribution.GetNewClient(cl_1, "Evgeniu Kyznetsov", 500, 6);

            Console.WriteLine(b.GetName());
            Console.WriteLine(b.GetAmount());
            Console.WriteLine(b.GetBet());
            Console.WriteLine(b.Payment() + " %");
        }
    }
}