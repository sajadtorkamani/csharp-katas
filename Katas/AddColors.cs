namespace Katas
{
    public class AddColors
    {
        public static string AdditiveColors(string input)
        {
            if (input.Contains("Red") && input.Contains("Green") && input.Contains("Blue"))
            {
                return "White";
            }
            else if (input.Contains("Red") && input.Contains("Green"))
            {
                return "Yellow";
            }
            else if (input.Contains("Red") && input.Contains("Blue"))
            {
                return "Magenta";
            }
            else if (input.Contains("Blue") && input.Contains("Green"))
            {
                return "Cyan";
            }
            else
            {
                return input;
            }
        }
    }
}