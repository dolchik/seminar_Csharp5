// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
Console.Clear();

int SIZE = 10;
int LEFT_RANGE = 0;
int RIGHT_RANGE = 100;

int[] array = new int[SIZE];//Создали массив 
array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int[] NewArray = new int[SIZE / 2 + SIZE % 2];//Новый массив


for (int i = 0; i < SIZE/2; i++)
{
    NewArray[i] = array[i] * array[SIZE - 1 - i];
}
if(SIZE % 2 != 0)
{
    NewArray[NewArray.Length - 1] = array[SIZE / 2];
}
Console.WriteLine("[" + string.Join(", ", NewArray) + "]");

