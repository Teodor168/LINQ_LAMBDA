namespace _3teNai_golemiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dai chisla (sus space): ");
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var sortedNums = nums.OrderByDescending(x => x);

            var largestNums = sortedNums.Take(3);

            Console.WriteLine(string.Join(" ", largestNums));
        }
    }
}
