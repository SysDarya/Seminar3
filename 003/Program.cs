// Определить, присутствует ли в заданном массиве, некоторое число



void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10,10);
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

Console.WriteLine ("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");

int [] array = new int [size];
FillArray (array);
PrintArray (array);



int ind = 0;
while (ind < array.Length)
{
    if (array[ind] == n)
    {
        Console.WriteLine ($"Число {n} присутствует в массиве.");
        
    }
    ind++;
}
