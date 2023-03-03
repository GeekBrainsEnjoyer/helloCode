int num11 = 342;
int num12 = 234;
int num13 = 456;
int num21 = 2356;
int num22 = 2657;
int num23 = 567;
int num31 = 236;
int num32 = 46787;
int num33 = 678;

int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int max1 = Max(num11, num12, num13);
int max2 = Max(num21, num22, num23);
int max3 = Max(num31, num32, num33);
int max = Max(max1, max2, max3);

Console.WriteLine(max);
