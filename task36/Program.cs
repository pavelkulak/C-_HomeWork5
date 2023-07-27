// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int sizeArray = GetNum("Введите длинну массива: ");
int[] array = GetArray(sizeArray);
PrtintArray(array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма четных элементов - " + sum);

int GetNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 101);
    }
    return result;
}
void PrtintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}