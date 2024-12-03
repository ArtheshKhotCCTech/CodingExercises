namespace CatsAndFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NotHungryCats("F O~ O~ ~O O~"));
        }
        public static int NotHungryCats(string kitchen)
        {
            string[] cats = kitchen.Replace(" ", "").Split('F');

            int leftCount = cats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
            int rightCount = cats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');

            return leftCount + rightCount;
        }
    }
}
