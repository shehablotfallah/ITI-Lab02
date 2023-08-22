namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");

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
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Item {i + 1} is {array[i]}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid size!");
            }
        }
    }
}