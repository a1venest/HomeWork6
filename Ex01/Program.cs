int ArrayLength()
{
    Console.WriteLine("Сколько чисел вы хотите ввести?");
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите число: {i + 1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int PositiveNumberCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int[] array = new int[ArrayLength()];
FillArray(array);
Console.WriteLine($"Количество положительных чисел равно: {PositiveNumberCount(array)}");