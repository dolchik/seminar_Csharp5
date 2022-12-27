// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();

int SIZE = 10;
int LEFT_RANGE = -9;
int RIGHT_RANGE = 9;

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

int EntryDigit(string str) //Метод для запроса числа от пользователя
{
    Console.Write(str);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}

bool FindDigitInArray(int[] arr, int numb) //Метод сравнивает число пользователя с массивом
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(numb == array[i])
        {
            result = true;
            break;
        }
    }
    return result;
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int numb = EntryDigit("Введите число: ");
// Console.WriteLine(numb);
bool result = FindDigitInArray(array, numb);
Console.WriteLine(result);

