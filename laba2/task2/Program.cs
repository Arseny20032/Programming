int x, y;
int number;
bool task = true;

while (task)
{
    Console.WriteLine("Введите 1, если желаете продолжить... Введите 2, если желаете завершить выполнение программы: ");
    number = Result.input();

    switch (number)
    {
        case 1:
            Console.WriteLine("Введите координаты по x и y:");
            x = Result.input();
            y = Result.input();
            int result = Result.task(x, y);
            break;

        case 2:
            task = false;
            break;

        default:
            Console.WriteLine("Ошибка! Вы ввели некорректное число. Попробуйте еще раз.");
            break;
    }
}

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