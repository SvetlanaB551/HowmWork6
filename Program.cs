// Урок 6. Двумерные массивы и рекурсия


// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Ex41()
{
Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Чисел больше 0 = {sum}");

int[] StringToNum(string a)
{
    int count = 1;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < a.Length; i++)
    {
        string temp = "";

        while (a [i] != ',')
        {
        if(i != a.Length - 1)
        {
            temp += a[i].ToString();
            i++;
        }
        else
        {
            temp += a[i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
}
Ex41();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
//прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; з
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Ex43()
{
double X;
double Y;

//Console.Write("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите точки b1, k1, b2 и k2: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr [1];
int b = arr [3];
int c = arr [0];
int d = arr [2];

if (a == b)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    X = (double) (d-c)/(a-b);
    Y = (double) a*(d-c)/(a-b) + c;
    Console.WriteLine("Точка пересечения двух прямых:");
    Console.WriteLine($"Х: {X:0.00}");
    Console.WriteLine($"Y: {Y:0.00}");
}
}
Ex43();