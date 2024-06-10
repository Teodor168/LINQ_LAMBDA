namespace SortiraneNaKratkiDumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "In SoftUni you can study Java, C#, PHP and JavaScript. " +
                     "JAVA and c# developers graduate in 2-3 years. Go in!";
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            var shortWords = text
                .Split(separators)
                .Select(word => word.ToLower())
                .Where(word => word.Length < 5)
                .Distinct()
                .OrderBy(word => word);

            Console.WriteLine(string.Join(" , ",shortWords));
            //foreach (var word in shortWords)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }
}
