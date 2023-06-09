//Напишите программу, которая на вход принимает число и выдает его квадрат

Console.Write("Введите число =>"); //Вывод приглашения на экран
string imputedString = Console.ReadLine(); // Ввод пользователя (строка)
int number = Convert.ToInt32(imputedString); // Преобразование строки в число
Console.WriteLine("Вы ввели число " + number + "!"); // Вывод введенного значения
Console.WriteLine($"Вы ввели число {number}!"); // Вывод введенного значения (другой вариант)

int square = number * number; // Вычисление квадрата (логига программы)
Console.WriteLine($"Квадрат числа {number} равен {square}");// Вывод результата


