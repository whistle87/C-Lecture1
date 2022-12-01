﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int posit = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            posit = index;
            break;
        }
        index++;
    }
    return posit;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

int pos = IndexOf(array, 4);
Console.WriteLine("Pisition "+pos);