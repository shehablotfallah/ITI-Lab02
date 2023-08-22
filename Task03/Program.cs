namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a 2D array of integers

            int[,] array = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            var rows = array.GetLength(0);
            var cols = array.GetLength(1);

            for (int i = 0; i < rows * cols; i++)
            {
                int row = i / cols;
                int col = i % cols;

                Console.WriteLine($"Item at row and column [{row},{col}] is {array[row, col]}");
            }
        }
    }
}