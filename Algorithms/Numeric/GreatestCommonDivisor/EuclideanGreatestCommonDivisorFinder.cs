namespace Algorithms.Numeric.GreatestCommonDivisor
{
    public class EuclideanGreatestCommonDivisorFinder : IGreatestCommonDivisorFinder
    {
        /// <summary>
        /// Finds greatest common divisor for numbers a and b
        /// using euclidean algorithm.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Greatest common divisor.</returns>
        public int Find(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                return int.MaxValue;
            }

            if (a == 0 || b == 0)
            {
                return a + b;
            }

            var aa = a;
            var bb = b;
            var cc = aa % bb;

            while (cc != 0)
            {
                aa = bb;
                bb = cc;
                cc = aa % bb;
            }

            return bb;
        }
    }
}
