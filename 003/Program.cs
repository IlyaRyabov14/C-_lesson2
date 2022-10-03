int [] array = {18,27,36,45,54,63,72,81,45};

int n = array.Length;
int find  = 45;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}