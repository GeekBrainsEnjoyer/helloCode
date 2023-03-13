double findFactorial(int n)
{
    if(n == 1) return 1;
    else return n * findFactorial(n - 1);
}

System.Console.WriteLine(findFactorial(51));