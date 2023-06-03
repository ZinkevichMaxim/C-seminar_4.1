Console.Clear();

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int Prompt(string msg)       // Работает
{
    Console.WriteLine(msg);
    int digit = int.Parse(Console.ReadLine());
    return digit;
}

// int nomber = Prompt("Введите целое число");        // Работает
// Console.WriteLine($"Вы ввели число {nomber}");    // Работает
int n = Prompt("Введите длину массива");             // Объявление массива
int[] array = new int[n];                           // Объявление массива
// Console.WriteLine($"{array[1]}");            //  Работает
// Console.WriteLine(array.Length);        //   Работает

void FillArray(int[] collection)
{
    int nomber = 0;
    int index = 0;
    while (index < n)
    {
        nomber = Prompt("Введите число");
        array[index] = nomber;
        index++;
    }
}
// Console.Write($"{array[1]} {array[3]}");   // работает

void PrintArray(int[] col)
{
    int count = n;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{array[position]}, ");
        position++;
    }
}

int[] NewArray = new int [n]; // Объявление массива
FillArray(NewArray);          // Наполнение массива
PrintArray(NewArray);         // Печать массива


