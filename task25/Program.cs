// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine ("Введите А");
int A=Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите B");
int B=Convert.ToInt32(Console.ReadLine());

int rez=1;

for (int i = 1; i <= B; i++)
{
    rez=rez*A;
}
Console.WriteLine(rez);