namespace Sum_Min_Max_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko chisla iskash: ");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Dai chislo {i + 1}: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("Average = {0}", nums.Average());
        }
    }
}
