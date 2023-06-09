// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли второе число квадратом первого
// a = 5; b = 25 -> да
// a = 2 b = 10 -> да
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да

Console.Write("Введите первое число =>"); //Вывод приглашения на экран
string imputedString_1 = Console.ReadLine(); // Ввод пользователя (строка)
Console.Write("Введите второе число =>"); //Вывод приглашения на экран
//string imputedString_1 = Console.ReadLine(); // Ввод пользователя (строка)
string imputedString_2 = Console.ReadLine(); // Ввод пользователя (строка)
int number_1 = Convert.ToInt32(imputedString_1); // Преобразование строки в число
int number_2 = Convert.ToInt32(imputedString_2); // Преобразование строки в число

int square = number_1 * number_1; // Вычисление квадрата (логига программы)
Console.WriteLine($"Квадрат числа {number_1} равен {square}"); // Вывод результата
//Console.Write("Введите второе число =>"); //Вывод приглашения на экран
if (square == number_2)
{
Console.WriteLine($"{number_2} является квадратом {number_1}");
}
else
{
Console.WriteLine($"{number_2} не является квадратом {number_1}");
}
