using System;
using System.Linq;
using System.Reflection;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new int[] { 2, 4, 1, 10, 3, 7 };

            var evens = ints.Where(n => n % 2 == 0)
                .ToArray();

            var evenIndex = Enumerable.Range(0, ints.Length)
                .Where(i => i % 2 == 0)
                .Select(i => ints[i])
                .ToArray();
            
            
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ToStringAttribute : Attribute
    {
    }

    static class Extention
    {
        public static T ParseTo<T>(this string text)
        {
            MethodInfo? parseMethod = typeof(T).GetMethods()
                .Where(m => m.Name == "Parse")
                .Select(m => new
                {
                    MethodInfo = m,
                    Parameters = m.GetParameters().ToArray()
                })
                .Where(mi =>
                    mi.Parameters.Length == 1
                    && mi.Parameters[0].ParameterType == typeof(string))
                .Select(mi => mi.MethodInfo)
                .SingleOrDefault();

            return (T)parseMethod?.Invoke(null, new object[] { text });
        }

        public static string ToStringEx(this object obj) => obj.GetType()
            .GetMembers()
            .Where(m
                => m is (FieldInfo or PropertyInfo)
                   && m.GetCustomAttributes(typeof(ToStringAttribute)) != null)
            .Select(m =>
                m is FieldInfo fi ? fi.GetValue(obj)?.ToString() :
                m is PropertyInfo pi ? pi.GetValue(obj)?.ToString() :
                null)
            .Aggregate((f, s) => $"{f}; {s}");
    }

    class MyList<T>
    {
        private T[] _array;

        private int _lastIndex = 0;

        public MyList()
        {
            _array = new T[1];
        }

        public MyList(int lenght)
        {
            _array = new T[lenght];
        }

        public void Add(T element)
        {
            if (_array.Length <= _lastIndex)
            {
                T[] newArray = new T[_array.Length * 2];
                Array.Copy(_array, newArray, _array.Length);
                _array = newArray;
            }

            _array[_lastIndex++] = element;
        }
    }
}