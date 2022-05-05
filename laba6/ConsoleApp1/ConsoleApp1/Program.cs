using System;

namespace laba6_proga
{
    public abstract class Technics
    {
        protected string Name;
        protected int Price;
        public Technics()
        {
            Name = "Техника";
            Price = 0;
            Console.WriteLine("Вызов конструктора родительского класса");
        }
        public Technics(string name, int price)
        {
            Name = name;
            Price = price;
            Console.WriteLine("Вызов перегруженного конструктора родительского класса");
        }
        public abstract void Tech(); // абстрактный метод
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Diff(int a, int b)
        {
            return a - b;
        }
        public int GetPrice() //этот метод мы перегружаем в наследнике 
        {
            return Price;
        }
        public string GetName()
        {
            return Name;
        }
        public void ChageInfo(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public void Shutdown()
        {
            Console.WriteLine("Устройство выключено(баз.класс)");

        }
        public void Update()
        {
            Console.WriteLine("Загрузка обновление(баз.класс)");
        }
        public virtual void GetInfo() // виртульный 
        {
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Стоимость: " + Price);
        }
    }

    public class Computer : Technics
    {
        private string Keyboard;
        private string Monitor;
        public Computer(string name, int price, string Keyboard, string Monitor) : base(name, price) 
        {
            this.Keyboard = Keyboard;
            this.Monitor = Monitor;
        }
        public override void Tech()
        {
            Console.WriteLine("Компьютер ");
        }
        public int GetPrice(int N) // перегруженный метод
        {
            return Price * N;
        }
        public new void Update() // скрываем метод 
        {
            base.Update(); // вызываем метод родительского класса
            Console.WriteLine("Не выключайте компьютер");
        }
        public void ChageInfo(string name, int price, string key, string mon) // перегрузка
        {
            ChageInfo(name, price);
            Keyboard = key;
            Monitor = mon;
        }

        public override void GetInfo() // переопределение виртуального метода род.класса 
        {
            base.GetInfo();
            Console.WriteLine("Клавиатура: " + Keyboard);
            Console.WriteLine("Монитор: " + Monitor);
        }
    }

    public sealed class Tablet : Technics // класс, закрытый для наследования.
    {
        public Tablet(string name, int price) : base(name, price) { }
        public override void Tech()
        {
            Console.WriteLine("Планшет ");
        }
        public void Recharge()
        {
            Console.WriteLine("Идет зарядка...");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Computer Computer = new Computer("Комп", 2500, "Razer", "LG");
            Console.WriteLine(Computer.GetPrice(56));
            Console.WriteLine(Computer.GetPrice());
            Console.WriteLine(Computer.GetName());
            Console.WriteLine(Computer.Diff(8, 6));
            Console.WriteLine(Computer.Sum(568, 65));
            Computer.Update();
            Computer.Tech();
            Computer.Shutdown();
            Computer.ChageInfo("ASUS", 3200);
            Computer.GetInfo();
            Tablet tab = new Tablet("Bombom", 5646854);
            tab.ChageInfo("Samsung", 2100);
            tab.GetInfo();
            tab.Shutdown();
            tab.Update();
            tab.Tech();
        }
    }
}
