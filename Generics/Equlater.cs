namespace Generics
{
    internal class Equlater
    {
        internal static bool AreEqual(int v1, int v2)
        {
            return v1.Equals(v2);
        }

        internal static bool AreEqual(double v1, double v2)
        {
            return v1.Equals(v2);
        }

        internal static bool AreEqual(string v1, string v2)
        {
            return v1.Equals(v2);
        }
    }
}