namespace StaticMethods
{
    internal class Program
    {
        public static int DoubleValue(int number = 10)
        {
            // TODO: Implement the method to double the value
            return number * 2;
        }

        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Console.WriteLine(DoubleValue());
        }
    }
}
