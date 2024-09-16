namespace IntroToCSharp.GD3B.Utilities
{
    public class MathUtility
    {
        public static readonly double FLOAT_COMPARE_TOLERANCE = 10E-6;

        public static bool AreEqualWithin(double a, double b)
        {
            return Math.Abs(a - b) < FLOAT_COMPARE_TOLERANCE;
        }

        public static bool AreEqualWithin(double a, double b,
                 double epsilon) //0.000001f
        {
            return Math.Abs(a - b) < epsilon;
        }
    }
}