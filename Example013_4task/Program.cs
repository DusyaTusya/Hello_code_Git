// Написать программу, которая на выход принимает одно число (N), а на выходе показывает все
// целые числа в промежутке от -N до N

Console.Write("Напишите целое положительное число "); //Вывод приглашения на экран

string imputedString = Console.ReadLine(); // Ввод пользователя (строка)
int number = Convert.ToInt32(imputedString); // Преобразование строки в число
int number_2 = - number;

while (number_2 <= number)
    {
    Console.Write($"{number_2}, ");
    number_2++;
    }



