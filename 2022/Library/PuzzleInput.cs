namespace AOC.Library
{
    public class PuzzleInput
    {
        public static string AsString()
        {
            // This retrieves the input.txt from the 
            var path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\input.txt");

            if (File.Exists(path))
            {
                var input = File.ReadAllText(path);

                if (input.EndsWith("\n"))
                {
                    input = input.Substring(0, input.Length - 1);
                }

                return input;
            }

            return "";
        }
    }
}