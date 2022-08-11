// Дан массив из 10 целых чисел в диапозоне от [-99,60] заменить в этом массиве отрицательные числа на 0

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-99,60);
        index++;
    }
}

void PrintArray (int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (collection[position]);
        position++;
    }
}

void ChangeNegatives (int[] collection)
{
    int position = 0;
    int length = collection.Length;

    while (position < length)
    {
        if (collection[position] < 0)
        {
            collection[position] = 0;            
        }
    position++;
    }
}

int [] array = new int [10];
FillArray (array);
PrintArray (array);
Console.WriteLine(" ");
ChangeNegatives (array);
PrintArray (array);