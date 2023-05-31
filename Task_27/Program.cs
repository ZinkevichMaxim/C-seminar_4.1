// Console.Clear();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int nom = int.Parse(Console.ReadLine());
    return nom;
}

int a = Prompt("Введите число");

Console.WriteLine("Вы ввели " + a); 

int sumDigit = 0;
int suma = 0;
 while(a > 0)
{
      suma = a % 10; 
      sumDigit = sumDigit + suma;
      a = a / 10; 
}

 Console.WriteLine(sumDigit);

