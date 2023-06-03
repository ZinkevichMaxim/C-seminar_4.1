Console.Clear();

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int Prompt(string msg)       // Работает
{
Console.WriteLine (msg);
int digit = int.Parse(Console.ReadLine());
return digit;
}

// int nomber = Prompt("Введите целое число");
// Console.WriteLine($"Вы ввели число {nomber}");    // Работает
int n = Prompt("Введите длину массива");
int[] array = new int [n];
Console.WriteLine($"{array[1]}");            //  Работает
Console.WriteLine(array.Length);        //   Работает

int nomber = 0;
int index = 0;
// int Lenght = n;
while (index < n)
{
    nomber = Prompt("Введите число");
    array[index] = nomber;
    index++;
}
Console.Write($"{array[1]} {array[3]}");



