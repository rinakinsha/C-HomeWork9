int NumberOfDigits(int N)
{
    if (N / 10 != 0)
        return 1 + NumberOfDigits(N / 10);

    else return 1;
}

Console.Write("Пожалуйста, введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Количетсво цифр в указанном числе: " + NumberOfDigits(m));
