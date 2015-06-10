namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            T sumResult = default(T);

            foreach (var item in collection)
            {
                sumResult += (dynamic)item;
            }
            return sumResult;
        }
        public static T Product<T>(this IEnumerable<T> collection)
        {
            T product = default(T) + (dynamic)1;

            try
            {
                foreach (var item in collection)
                {
                    product *= (dynamic)item;
                }
            }
            catch (Exception)
            {
                Console.Write("{0} does not have product value", collection.GetType().Name);
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            T min = collection.FirstOrDefault();

            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            T max = collection.FirstOrDefault();

            foreach (var item in collection)
            {
                if (item.CompareTo(max) >= 0)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Avrg<T>(this IEnumerable<T> collection)
        {
            T avrg = default(T);
            try
            {
                avrg = collection.Sum() / (dynamic)collection.Count();
            }
            catch (Exception)
            {
                Console.Write("{0} does not have average value", collection.GetType().Name);
            }

            return avrg;
        }
    }
}
