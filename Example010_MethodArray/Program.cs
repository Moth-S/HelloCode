int[] array = { 1, 2, 55, 48, 35, 61, 75, 48, 55};

int n = array.Length;
int find = 55;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}