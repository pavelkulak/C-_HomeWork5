// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int sizeArray = GetNum("Введите длинну массива: ");
double[] array = GetArray(sizeArray);
PrtintArray(array);
double min = array[0];
double max = array[0];
double dif = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    } 
    if (array[i] < min)
    {
        min = array[i];
    } 
}
dif = max - min;
Console.WriteLine();
Console.WriteLine($" Максимальный элемент массива - {max}");
Console.WriteLine($" Минимальный элемент массива - {min}");
Console.WriteLine($" Разница между минимальным и максимальным - {dif}");
int GetNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
double[] GetArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble();
    }
    return result;
}
void PrtintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}