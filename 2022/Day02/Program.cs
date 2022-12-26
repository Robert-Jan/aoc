using AOC.Library;
using System.Diagnostics.Metrics;
using System.Linq;

namespace AOC.Day02
{
    class Program : Runner
    {
        static void Main() => new Program();

        private Dictionary<string, int> points = new Dictionary<string, int> {
            { "A", 1 }, { "B", 2 }, { "C", 3 },
            { "X", 1 }, { "Y", 2 }, { "Z", 3 }
        };

        public override void PartOne(string input)
        {
            var defeats = new Dictionary<string, string> {
                { "X", "C" }, { "Y", "A" }, { "Z", "B" }
            };

            var result = input.Split("\r\n").ToList().Select(round =>
            {
                var parts = round.Split(" ").ToArray();

                var score = 0; // Lose
                if (defeats[parts[1]] == parts[0]) score = 6; // Win
                else if (points[parts[0]] == points[parts[1]]) score = 3; // Draw

                // Cast worth + battle score
                return points[parts[1]] + score;
            });

            Console.WriteLine(result.Sum());
        }

        public override void PartTwo(string input)
        {
            var result = input.Split("\r\n").ToList().Select(round =>
            {
                var parts = round.Split(" ").ToArray();
                int cast = 0, score = 0;

                var wins = new Dictionary<string, string> {
                    { "A", "B" }, { "B", "C" }, { "C", "A" }
                };

                var loses = new Dictionary<string, string> {
                    { "A", "C" }, { "B", "A" }, { "C", "B" }
                };

                switch (parts[1])
                {
                    case "X": // Lose
                        score = 0;
                        cast = points[loses[parts[0]]];
                        break;
                    case "Y": // Draw
                        score = 3;
                        // Cast the same as oponent
                        cast = points[parts[0]]; 
                        break;
                    case "Z": // Win
                        score = 6;
                        cast = points[wins[parts[0]]];
                        break;
                }

                return cast + score;
            });

            Console.WriteLine(result.Sum());
        }
    }
}