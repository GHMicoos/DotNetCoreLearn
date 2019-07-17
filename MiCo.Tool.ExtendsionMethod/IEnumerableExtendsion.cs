using System;
using System.Collections.Generic;
using System.Text;

namespace MiCo.Tool.ExtendsionMethod
{
    /// <summary>
    /// 
    /// </summary>
    public static class IEnumerableExtendsion
    {
        /// <summary>
        /// 根据传入的keySelector，去重IEnumerable
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source">待处理序列</param>
        /// <param name="keySelector">key选择器</param>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

    }
}
