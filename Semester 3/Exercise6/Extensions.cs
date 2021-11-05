using System.Collections.Generic;

namespace Exercise6
{
    public delegate bool WherePredicate<T>(T rectangle);

    public static class Extensions
    {
        public static List<T> Where<T>(this List<T> rectangles, WherePredicate<T> wherePredicate)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < rectangles.Count; i++)
            {
                if (wherePredicate(rectangles[i]))
                {
                    result.Add(rectangles[i]);
                }
            }

            return result;
        }
    }
}