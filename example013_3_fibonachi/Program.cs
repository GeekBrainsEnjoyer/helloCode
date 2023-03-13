double findFibonachi(int n)
{
    if(n == 1 || n == 2) return 1;
    else return findFibonachi(n - 1) + findFibonachi(n - 2);
}

for (int i = 1; i < 50; i++)
{
    System.Console.WriteLine($"f({i}) = {findFibonachi(i)}");
}