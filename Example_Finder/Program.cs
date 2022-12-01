int[] array = {1, 2, 3, 4, 5, 6, 23, 23 ,45, 34 };

int n = array.Length;
int find = 23;

int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}