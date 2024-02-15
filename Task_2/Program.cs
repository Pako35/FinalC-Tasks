class Program
{
    static void Main()
    {
        // Initialize M and N
        int m = 3;
        int n = 4;

        // Calculate the Ackermann function using recursion
        int result = Ackermann(m, n);

        // Print the result
        Console.WriteLine("Result: " + result);
    }

    static int Ackermann(int m, int n)
    {
        // Base case: if M is 0, return N + 1
        if (m == 0)
        {
            return n + 1;
        }

        // Base case: if N is 0, return Ackermann(M - 1, 1)
        if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }

        // Recursive case: return Ackermann(M - 1, Ackermann(M, N - 1))
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}