Console.Clear();

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = Prompt("Введите число А");
int b = Prompt("Введите число B");
AinB(a, b);


int Prompt(string msg)
{
Console.WriteLine(msg);
int nom = int.Parse(Console.ReadLine());
return nom;
} 


void AinB(int a, int b)
{
int ainb = 1;
while(b > 0)
{
    ainb = ainb * a;
    b = b - 1;
}
    
Console.WriteLine(ainb);
}


