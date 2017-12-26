using System;
using System.Collections.Generic;

namespace SQLite
{
    public static class IntExtension
    {
        public static IEnumerable<TResult> Create<TResult>(this int value, Func<TResult> func)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            var res = new List<TResult>();
            for (int i = 0; i < value; i++)
                res.Add(func());
            return res;
        }
    }
}
