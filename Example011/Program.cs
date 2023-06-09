// Напишите программу,которая будет выдавать название для недели по заданному номеру
// 3-> среда
//5 -> пятница
string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"}; // 

Console.Write("Введите номер дня недели: "); //Вывод приглашения на экран

string weekday = Console.ReadLine(); // Ввод пользователя (строка)
int day_number = Convert.ToInt32(weekday); // Преобразование строки в число

if (day_number < 0 || day_number > 6)
{
Console.WriteLine("Нет такого дня недели");
}
else
{
Console.WriteLine(week[day_number - 1]);
}
