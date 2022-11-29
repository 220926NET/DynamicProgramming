

//Standard Fibonacci function
uint fib(uint n, ref int steps)
{
    steps++;
    if (n == 0 || n == 1) return n;
    return fib(n - 1, ref steps) + fib(n - 2, ref steps);
}

//Top-down
uint fibMemo(uint n, ref Dictionary<uint, uint> fibs, ref int steps)
{
    steps++;
    if (n == 0 || n == 1) return n;
    if (fibs.ContainsKey(n)) return fibs[n];
    fibs[n] = fibMemo(n - 1, ref fibs, ref steps) + fibMemo(n - 2, ref fibs, ref steps);
    return fibs[n];
}

//Bottom-up
uint fibTab(uint n, ref int steps)
{
    uint[] fibs = new uint[n + 1];
    fibs[0] = 0;
    fibs[1] = 1;
    for (int i = 2; i < fibs.Length; i++)
    {
        steps++;
        fibs[i] = fibs[i - 1] + fibs[i - 2];
    }
    return fibs[n];
}

int steps = 0;
uint n = 30;
System.Console.WriteLine("Fibonacci w/ Tabulation");
System.Console.WriteLine("Answer: " + fibTab(n, ref steps));
System.Console.WriteLine("Steps taken: " + steps);


steps = 0;
Dictionary<uint, uint> fibs = new();
System.Console.WriteLine("Fibonacci w/ Memoization");
System.Console.WriteLine("Answer: " + fibMemo(n, ref fibs, ref steps));
System.Console.WriteLine("Steps taken: " + steps);


steps = 0;
System.Console.WriteLine("Standard Fibonacci");
System.Console.WriteLine("Answer: " + fib(n, ref steps));
System.Console.WriteLine("Steps taken: " + steps);



