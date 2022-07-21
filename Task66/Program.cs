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

Console.Write(SumOfNaturalElem(8, 4));