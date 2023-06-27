/*Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь
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
Напишите программу, которая найдет точку персечения двух прямых, заданных уравнениями 
y=k1*x+b1, y=k2*x+b2; значения b1, k1, b2 и k2 задаются пользователем.
*/
double Input(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine()!);
}
double coordXY(double b1, double k1, double b2, double k2)
{
double x = (b2 - b1)/(k1 - k2);

return x;
}
double b1 = Input("Введите число b1: ");
double k1 = Input("Введите число k1: ");
double b2 = Input("Введите число b2: ");
double k2 = Input("Введите число k2: ");
if (k1 == k2 && b1!=b2)
    {
        Console.WriteLine("Прямые  - параллельны");
        return;
    }
else if (k1 == k2 && b1 == b2)
        {
        Console.WriteLine("Прямые  совпадают");
        return;
    }
double Xcor = coordXY(b1, k1,b2,k2);
double y = k1*Xcor + b1;
Console.WriteLine($"Координаты точки пересечения: Х={Xcor}, Y={y}");