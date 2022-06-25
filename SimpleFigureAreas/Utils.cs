namespace SimpleFigureAreas;

internal static class Utils
{
    public static long Gcd(long a, long b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}