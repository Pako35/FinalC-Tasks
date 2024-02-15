class Program
{
    static void Main()
    {
        // Initialize M and N
        int m = 3;
        int n = 6;

        // Print all natural numbers from M to N using recursion
        PrintNumbers(m, n);
    }

    static void PrintNumbers(int m, int n)
    {
        // Base case: if M is greater than N, do nothing
        if (m > n)
        {
            return;
        }

        // Print M
        Console.WriteLine(m);

        // Recursive case: increment M and call PrintNumbers
        PrintNumbers(m + 1, n);
    }
}