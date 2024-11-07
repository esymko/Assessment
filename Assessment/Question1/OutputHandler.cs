namespace Assessment
{
    public static class OutputHandler
    {
        public static void PrintEvenNumbers(int a, int b)
        {
            Console.WriteLine("");
            var sortedList = new List<int>();
            sortedList.Add(a);
            sortedList.Add(b);
            sortedList.Sort();

            for (var i = 2; i <= sortedList.Last(); i++)
            {
                if (i % sortedList.First() == 0 && i % 2 == 0)
                {
                    Console.WriteLine(i);
                };
            }
        }
    }
}