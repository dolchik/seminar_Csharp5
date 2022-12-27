// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int SIZE = 10;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

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

int[] MinusArray(int[] arr) // метод умножает каждый элемент массива на -1
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = - arr[i];
    }
    return arr;
}
array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine("[" + string.Join(", ", array) + "]");
MinusArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");