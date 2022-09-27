Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

void PowN(int N)
{
    int i = 1;
    while (i <= N)
    {
        Console.Write(" " + Math.Pow(i, 3) + " ");
        i++;
    }
}

PowN(N);