int[] array = {1, 12, 14, 17, 26, 54, 753, 51, 77, 96, 17, 55, 17, 1551};
int n = array.Length;
int find = 17;
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