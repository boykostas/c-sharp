int Max(int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 45;
int b1 = 25;
int c1 = 15;

int a2 = 65;
int b2 = 745;
int c2 = 85;

int a3 = 95;
int b3 = 225;
int c3 = 155;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

// Console.WriteLine(max1);
// Console.WriteLine(max2);
// Console.WriteLine(max3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);