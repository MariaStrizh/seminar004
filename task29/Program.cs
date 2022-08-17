// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран. Вводим массив через консоль


int[] arr = new int[8];

for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите число {i}:");
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine( string.Join (", ", arr ));