int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезки [10,99] -> {number}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit (number);
Console.WriteLine($"Наиьольшая цифра число: -> {maxDigit}");
