void FullArray(int[] collection)
{
    int size = collection.Length;
    int index = 0;

    while (index < size)
    {
        collection[index] = new Random().Next(1, 5);
        index++;
    }

}

void PrintArray(int[] collection)
{
    int lenght = collection.Length;
    int pozitione = 0;

    while (pozitione < lenght)
    {
        Console.WriteLine(collection[pozitione]);
        pozitione++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
      index++;
    }
    return position;      
}

int[] array = new int[10];

FullArray(array);
PrintArray(array);

int pos = IndexOf(array, 4);
Console.Write("First pozition four " + pos);