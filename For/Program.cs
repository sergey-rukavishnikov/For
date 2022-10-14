namespace For // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int i = 0;
            string line;
            Console.WriteLine("Введите 10 чисел, разделённых пробелами:");
            line = Console.ReadLine();
            string[] subs = line.Split(' ');
            foreach (var sub in subs)
            {
                int.TryParse(sub, out numbers[i++]);
            }
            Array.Sort(numbers);
            Console.Write(numbers[9]);
        }
    }
}