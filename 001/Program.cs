int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 >result) result = arg3;
    return result;
}

int a1 = 13;
int a2 = 15;
int a3 = 17;
int b1 = 19;
int b2 = 2331;
int b3 = 32;
int c1 = 35;
int c2 = 38;
int c3 = 44;

int max  = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);