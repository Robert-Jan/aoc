using AOC.Library;

namespace AOC.Day01
{
    class Program : Runner
    {
        static void Main() => new Program();

        public override void PartOne(string input)
        {
            var MostCalories = CountedCalories(input)
                .OrderByDescending(i => i)
                .First();

            Console.WriteLine(MostCalories);
        }

        public override void PartTwo(string input)
        {
            var TopThreeMostCalories = CountedCalories(input)
                .OrderByDescending(i => i)
                .Take(3)
                .Sum();

            Console.WriteLine(TopThreeMostCalories);
        }

        private static List<int> CountedCalories(string input) => input.Split("\r\n\r\n")
            .Select(elf => elf.Split("\r\n").Select(int.Parse).Sum())
            .ToList();
    }
}