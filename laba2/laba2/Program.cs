int number;
bool tt = true;

while (tt)
{
    Console.WriteLine("Введите 1, если хотите продолжить... Введите 2, если хотите завершить программу: ");

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Oшибка ввода... Введите число ");
    }

    switch (number)
    {
        case 1:
            Console.WriteLine("Введите двузначное число: ");

            while (!int.TryParse(Console.ReadLine(), out number) || number < 10 || number > 99)
            {
                Console.WriteLine("Oшибка ввода... Введите двузначное число ");
            }

            int dozens = number / 10;
            int units = number % 10;

            int sum = dozens + units;

            if (sum % 2 == 0)
            {
                Console.WriteLine("Сумма цифр двузначного числа является чётной");
            }
            else
            {
                Console.WriteLine("Сумма цифр двузначного числа является нечётной");
            }

            break;

        case 2:
            tt = false;
            break;

        default:
            Console.WriteLine("Ошибка!!! Вы ввели некорректное число... Попробуйте еще раз. ");
            break;
    }
}