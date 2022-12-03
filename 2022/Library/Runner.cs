namespace AOC.Library
{
    public abstract class Runner
    {
        public Runner()
        {
            var input = PuzzleInput.AsString();

            Console.WriteLine("Part One:");
            PartOne(input);

            Console.WriteLine("\n------------\n");

            Console.WriteLine("Part Two:");
            PartTwo(input);
        }

        public abstract void PartOne(string input);

        public abstract void PartTwo(string input);
    }
}
