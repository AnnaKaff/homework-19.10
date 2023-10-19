// // Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // -1, -7, 567, 89, 223-> 3
// Console.Clear();
// Console.WriteLine("Введите числа: ");
// string numb = Console.ReadLine();
// string [] newNumbers = new string [numb.Length];
// int k = 0;
//     for (int i = 0; i < newNumbers.Length; i++)
// {
//   if (numb[i] == ',')
//   {
//     k++;
//   }
//   else
//   {
//  newNumbers[k] = newNumbers[k]+$"{numb[i]}";
//   }
// }
// k++;
// int [] resultNumbers = new int[k];
// PrintArray (resultNumbers, newNumbers);
// int sum = 0;
// for (int i = 0; i < k; i++)
// {
//   if (resultNumbers[i]>0)
//   {
//     sum++;
//   }
// }
// Console.WriteLine ("Количество чисел больше 0: "+sum);

// void PrintArray (int [] array, string [] string1)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//   array[i] = Convert.ToInt32(string1[i]);
//   Console.Write (array[i]+"  ");
//   }
// Console.WriteLine();
// }
// __________________________________________________________
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.Clear();
// double pointX;
// double pointY;
// Console.WriteLine("Введите координаты через пробел: ");
// int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
// int a = arr [1];
// int b = arr [3];
// int c = arr [0];
// int d = arr [2];

// if (a == b)
// {
//  Console.WriteLine("Прямые паралельны");
// }
// else
// {
//  pointX = (double) (d-c)/(a-b);
//  pointY = (double) a*(d-c)/(a-b) + c;
//  Console.WriteLine("Координаты точки пересечения двух прямых:");
//  Console.WriteLine($"Х: {pointX:0.00}");
//     Console.WriteLine($"Y: {pointY:0.00}");
// }