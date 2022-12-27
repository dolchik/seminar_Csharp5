// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();

int SIZE = 123;
int LEFT_RANGE = 0;
int RIGHT_RANGE = 1000;

int[] array = new int[SIZE]; //Создали массив 
// наполняем массив случайными числами в заданном диапазоне
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange+1);
    }
    return arr;
}

int FindCountDigits(int[] arr) //Метод подсчитывает кол-во значений между [10, 99]
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(10 <= array[i] & array[i] <= 99)
        {
           count++;
        }
    }
    return count;
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int count = FindCountDigits(array);
Console.WriteLine($"Кол-во значений между [10, 99]: {count}");