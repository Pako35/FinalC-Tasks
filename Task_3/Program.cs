class Program
{
    static void Main()
    {
        // Initialize an array
        int[] array = { 1, 2, 3, 4, 5 };

        // Print the elements of the array in reverse order using recursion
        PrintArrayInReverse(array, array.Length);
    }

    static void PrintArrayInReverse(int[] array, int length)
    {
        // Base case: if the length is 0, do nothing
        if (length == 0)
        {
            return;
        }

        // Print the last element of the array
        Console.WriteLine(array[length - 1]);

        // Recursive case: decrement the length and call PrintArrayInReverse
        PrintArrayInReverse(array, length - 1);
    }
}