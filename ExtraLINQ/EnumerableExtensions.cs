﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtraLINQ
{
    public static class EnumerableExtensions
    {
        public static bool None(this IEnumerable source)
        {
            throw new NotImplementedException();
        }

        public static bool None<TSource>(this IEnumerable source, Func<TSource, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
