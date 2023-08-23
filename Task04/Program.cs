namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int size);

            if (isValid)
            {
                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter item {i + 1}: ");

                    bool isNumber = int.TryParse(Console.ReadLine(), out array[i]);
                    if (!isNumber)
                    {
                        Console.WriteLine("Please enter a valid number!");
                        return;
                    }
                }

                Console.WriteLine($"\n The longest distance between any two equal cells is {LongestDistanceBetweenAnyTwoEqualCells(array)}");
            }
            else
            {
                Console.WriteLine("Please enter a valid size!");
            }
        }


        
        private static int LongestDistanceBetweenAnyTwoEqualCells(int[] array)
        {
            Dictionary<int, int> firstIndex = new();

            int longestDistance = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int cell = array[i];
                // Check if the dictionary contains the cell value
                if (firstIndex.ContainsKey(cell))
                {
                    // Calculate the distance between the current index and the first index of the cell value
                    int distance = i - firstIndex[cell];
                    longestDistance = Math.Max(longestDistance, distance);
                }
                else
                {
                    // Add the cell value and its first index to the dictionary
                    firstIndex[cell] = i;
                }
            }
            return longestDistance;
        }
    }
}