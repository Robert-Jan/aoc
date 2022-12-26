using AOC.Library;
using System.Linq;

namespace AOC.Day03
{
    class Program : Runner
    {
        static void Main() => new Program();

        public override void PartOne(string input)
        {
            var result = input.Split("\r\n")
                .Select(bag => bag.Chunk(bag.Length / 2))
                .Select(GetCommonItemPriority)
                .Sum();

            Console.WriteLine(result);
        }

        public override void PartTwo(string input)
        {
            var result = input.Split("\r\n")
                .Chunk(3)
                .Select(GetCommonItemPriority)
                .Sum();

            Console.WriteLine(result);
        }

        private int GetCommonItemPriority(IEnumerable<IEnumerable<char>> bags) => (
            from item in bags.First()
            where bags.All(bag => bag.Contains(item))
            select item < 'a' ? item - 'A' + 27 : item - 'a' + 1
        ).First();
    }
}