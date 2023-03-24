/* Checking the string is null or not */
namespace CustomExtensions {
    public static class StringExtensions {
        public static string CheckingThePathIsNull(string? text) 
        {
            if(text is null)
            {
                throw new ArgumentException(text);
            }
            return text;
        }
    }
}