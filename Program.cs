internal class Program
{
    private static void Main(string[] args)
    {
        int termo = 10; 
        int resultado = FibonacciRecursivo(termo);

        Console.WriteLine($"O {termo}-ésimo termo da sequência de Fibonacci é: {resultado}");
    }

    static int FibonacciRecursivo(int n)
    {
        if (n <= 1)
            return n;
        else
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
    }
}