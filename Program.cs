namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            long a = Convert.ToInt64(numbers[0]);
            long b = Convert.ToInt64(numbers[1]);

            Program P = new Program();
            Console.WriteLine(P.EuclidGCD(a, b));
        }

        public long EuclidGCD(long a, long b)
        {
            long c = 0;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
    }
}