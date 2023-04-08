// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.Clear();
// int[] CreateRandomArray(int size, int minValue, int maxValue) {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++) {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }    
//     return array;
// }

// void ShowArray(int[] array) {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int NumOfEven(int[] array) {
//     int amount = 0;
//     for(int i = 0; i < array.Length; i++) {
//         if(array[i]%2 == 0) amount++;
//     }
//     return amount;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int min = 100;
// int max = 999;

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// int numOfDigits = NumOfEven(newArray);
// Console.WriteLine($"Количество чётных чисел в массиве = {numOfDigits}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Clear();
// int[] CreateRandomArray(int size, int minValue, int maxValue) {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++) {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }    
//     return array;
// }

// void ShowArray(int[] array) {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int SumOfElements(int[] array) {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i=i+2) {
//         sum = sum + array[i];
//     }
//     return sum;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// Console.WriteLine($"Количество нечётных элементов массива = {SumOfElements(newArray)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.Clear();
// double[] CreateRandomArray(int size, int minValue, int maxValue) {
//     double[] array = new double[size];
//     for(int i = 0; i < size; i++) {
//         array[i] = Math.Round((new Random().Next(minValue, maxValue+1)) + (new Random().NextDouble()), 3);
//     }    
//     return array;
// }

// void ShowArray(double[] array) {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// double Difference(double[] array) {
//     double min = array[0];
//     double max = array[0];
//     for(int i = 0; i<array.Length; i++) {
//         if(array[i] < min) min = array[i];
//         if(array[i] > max) max = array[i];
//     }
//     Console.WriteLine($"Минимум = {min}");
//     Console.WriteLine($"Максимум = {max}");
//     double difference = max - min;
//     return difference;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// Console.Write($"Разница между максимумом и минимумом = {Difference(newArray)}");