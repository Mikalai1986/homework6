//Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь
int Inputnum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int M = Inputnum("Введите число М: ");
int ind = 0;
for (int i = 0; i < M; i++)
    {
    int N = int.Parse(Console.ReadLine()!);
    if (N > 0) ind++;

    }

Console.WriteLine($"Количество положительных введенных = {ind}");