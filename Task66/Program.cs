int SumOfNaturalElem(int M, int N)
{
    if (M < N)
    {
        while (M != N)
            return M + SumOfNaturalElem(M + 1, N);
    }

    if (M > N)
    {
        while (M != N)
            return M + SumOfNaturalElem(M - 1, N);
    }

    return M;
}

Console.Write("Введите 1 число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма натуральных элементов в указанном промежутке: " + SumOfNaturalElem(m, n));