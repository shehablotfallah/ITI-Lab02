namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4, num2 = 6;

            Swap(ref num1, ref num2);

            Console.WriteLine(value: num1);
            Console.WriteLine(value: num2);
        }

        // Ex ----> Pass by Ref For Ref Type 

        private static void Swap(ref int x, ref int y) => (y, x) = (x, y);
    }
}