namespace DiscordBotDebugger.Web.Helpers
{
    public static class StringExtensions
    {
        public static string ToProperCase(this string input)
        {
            // If there are 0 or 1 characters, just return the string.
            if (input == null)
                return input;
            if (input.Length < 2)
                return input.ToUpper();

            // Start with the first character.
            var result = input.Substring(0, 1).ToUpper();

            // Add the remaining characters.
            for (var i = 1; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                    result += " ";
                result += input[i];
            }

            return result;
        }
    }
}