// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int MaxDigit(int num) 
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int number = new Random().Next(10, 100); // max = 99 + 1
Console.WriteLine($"Cлучайное число из отрезка [10, 99] -> {number}");

// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // Тернарный оператор
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit1 = MaxDigit(23);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");

int maxDigit2 = MaxDigit(67);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");

int maxDigit3 = MaxDigit(89);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit3}");