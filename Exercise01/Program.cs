Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

// void Danger(int number)
// {
//     if (number >= 100000)
//     {
//         Console.WriteLine("Это число не пятизначное, оно больше");
//     }
//     else if (number < 10000)
//     {
//         Console.WriteLine("Это число не пятизначное, оно меньше.");
//     }
// }
// Console.WriteLine((number / 10000));
// Console.WriteLine((number % 10));
// Console.WriteLine((number / 1000)%10);
// Console.WriteLine((number / 10)%10);
void Palindrome(int number)
{
    if (number >= 100000)
    {
        Console.WriteLine("Это число не пятизначное, оно больше");
    }
    else if (number < 10000)
    {
        Console.WriteLine("Это число не пятизначное, оно меньше.");
    }
    if (((number / 10000) == (number % 10)) && ((number / 1000) % 10 == (number / 10) % 10))
    {
        Console.WriteLine("Число " + number + " полиндром.");
    }

    else
    {
        Console.WriteLine("Число " + number + " не полиндром.");
    }

}

// Danger(number);
Palindrome(number);