namespace IntroToCSharp.GD3B.Utilities
{
    public class MathUtility
    {
        public static bool AreEqualWithin(float a, float b,
                 float epsilon) //0.000001f
        {
            return Math.Abs(a - b) < epsilon;
        }
    }
}