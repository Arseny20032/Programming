namespace ClassLibrary1
{
    public class Result
    {
        public static int input()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Oшибка ввода! Введите число");
            }
            return number;
        }

        public static int task(int x, int y)
        {
            if (x > -15 && x < 0 && y > -15 && y < 0)
            {
                Console.WriteLine("Нет");
                return -1;
            }
            else if ((x == 0 && y >= -15 && y <= 0) || (y == 0 && x >= -15 && x <= 0) || (x == -15 && y >= -15 && y <= 0) || (y == -15 && x >= -15 && x <= 0))
            {
                Console.WriteLine("На границе");
                return 0;
            }
            else Console.WriteLine("Да");
            {
                return 1;
            }
        }
    }
}