// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
int count;
int num=0;
int rez=0;

for (count = 0; number > 0; count++)
{
    num=number%10;
    number/=10;
    rez=rez+num;
}
Console.WriteLine(rez);