using System;
using System.Collections.Generic;
using System.Text;

namespace MiCo.Tool.ExtendsionMethod
{
    public static class DictionaryExtendsion
    {

        /// <summary>
        /// 尝试将键和值添加到字典中
        /// 如果不存在key，则添加；key存在，不添加也不抛导常。
        /// </summary>
        /// <typeparam name="TKey">key的泛型类型</typeparam>
        /// <typeparam name="TValue">value的泛型类型</typeparam>
        /// <param name="dic">操作字典</param>
        /// <param name="key">待添加key</param>
        /// <param name="value">待添加value</param>
        /// <returns>如果添加成功返回true，添加失败返回false。</returns>
        public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey key, TValue value)
        {
            try
            {
                if (dic == null || key == null || dic.ContainsKey(key))
                    return false;
                dic.Add(key, value);
                return true;
            }
            catch (Exception e)
            {
                //不做操作
                return false;
            }
        }

        /// <summary>
        /// 尝试将键和值添加或替换到字典中
        /// 如果不存在key，则添加；key存在，替换values。
        /// </summary>
        /// <typeparam name="TKey">key的泛型类型</typeparam>
        /// <typeparam name="TValue">value的泛型类型</typeparam>
        /// <param name="dic">操作字典</param>
        /// <param name="key">待添加key</param>
        /// <param name="value">待添加value</param>
        /// <returns>如果添加/替换成功返回true，添加失败返回false。</returns>
        public static bool AddOrReplace<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey key, TValue value)
        {
            try
            {
                if (dic == null || key == null)
                    return false;
                if (dic.ContainsKey(key))
                    dic[key] = value;
                else
                    dic.Add(key, value);
                return true;
            }
            catch (Exception e)
            {
                //不做操作
                return false;
            }
        }

        /// <summary>
        /// 字典中是否存在该key，不抛异常。
        /// </summary>
        /// <typeparam name="TKey">key的泛型类型</typeparam>
        /// <typeparam name="TValue">value的泛型类型</typeparam>
        /// <param name="dic">操作字典</param>
        /// <param name="key">待查询key</param>
        /// <returns>只有当字典中存在该key，才会返回false。否则返回true</returns>
        public static bool ContainsKeyNoException<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey key)
        {
            try
            {
                if (dic == null || key == null)
                    return false;
                return dic.ContainsKey(key);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// 通过key尝试获取字典中的值。
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TValue TryGetValue<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey key)
        {
            try
            {
                if (dic == null || key == null)
                    return default(TValue);
                return dic.ContainsKey(key) ? dic[key] : default(TValue);
            }
            catch (Exception e)
            {
                return default(TValue);
            }
        }

    }
}
