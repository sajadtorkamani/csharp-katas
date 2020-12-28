namespace Katas
{
    public class GetAges
    {
        public static double[] Calculate(int sum, int difference)
        {
            if (sum < 0 || difference < 0)
            {
                return null;
            }

            double older = difference + ((sum - difference) / 2d);
            double younger = sum - older;

            if (older < 0 || younger < 0)
            {
                return null;
            }

            return new[] {older, younger};
        }
    }
}
