using System;
using System.Collections.Generic;
using System.Text;

namespace MiCo.Tool.ExtendsionMethod
{
    /// <summary>
    /// DateTime扩展方法
    /// 一.什么是时间戳？
    /// 1.JavaScript时间戳
    ///     ：是指格林威治时间1970年01月01日00时00分00秒(北京时间1970年01月01日08时00分00秒)起至现在的总“毫秒数”。
    /// 2.Unix时间戳：
    ///     是指格林威治时间1970年01月01日00时00分00秒(北京时间1970年01月01日08时00分00秒)起至现在的总“秒数”。   
    /// 区别：JavaScript时间戳总毫秒数，Unix时间戳是总秒数。
    /// 
    /// 
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// 本地时间 1970-01-01
        /// </summary>
        private static readonly DateTime _startTime = new DateTime(1970, 1, 1);

        /// <summary>
        /// DateTime 转换为 JS时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long ToJSTimeStamp(this DateTime time)
            => (long)(_startTime - time).TotalMilliseconds;


        /// <summary>
        /// DateTime? 转换为 JS时间戳(long)
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long? ToJSTimeStamp(this DateTime? time)
            => time.HasValue ? (long)(_startTime - time.Value).TotalMilliseconds : default(long?);

        /// <summary>
        /// JS时间戳 转换为 DateTime  
        /// </summary>
        /// <param name="timestmp"></param>
        /// <returns></returns>
        public static DateTime JSTimeStamp2DateTime(this long timestmp)
            => _startTime.AddMilliseconds(timestmp);

        /// <summary>
        /// JS时间戳(long?) 转换为 DateTime?  
        /// </summary>
        /// <param name="timestmp"></param>
        /// <returns></returns>
        public static DateTime? JSTimeStamp2DateTime(this long? timestmp)
            => timestmp.HasValue ? _startTime.AddMilliseconds(timestmp.Value) : default(DateTime?);


        /// <summary>
        /// DateTime 转换为 Unix时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long ToUnixTimeStamp(this DateTime time)
            => (long)(_startTime - time).TotalSeconds;


        /// <summary>
        /// DateTime? 转换为 Unix时间戳(long)
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long? ToUnixTimeStamp(this DateTime? time)
            => time.HasValue ? (long)(_startTime - time.Value).TotalSeconds : default(long?);

        /// <summary>
        /// Unix时间戳 转换为 DateTime  
        /// </summary>
        /// <param name="timestmp"></param>
        /// <returns></returns>
        public static DateTime UnixTimeStamp2DateTime(this long timestmp)
            => _startTime.AddSeconds(timestmp);

        /// <summary>
        /// Unix时间戳(long?) 转换为 DateTime?  
        /// </summary>
        /// <param name="timestmp"></param>
        /// <returns></returns>
        public static DateTime? UnixTimeStamp2DateTime(this long? timestmp)
            => timestmp.HasValue ? _startTime.AddSeconds(timestmp.Value) : default(DateTime?);



        /// <summary>
        /// DateTime转时间戳
        /// </summary>
        /// <param name="time">当前时间是北京时间（东八区）</param>
        /// <returns></returns>
        public static long ConvertToTimeStamp(this DateTime time)
        {


            DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);


            return (long)(time.AddHours(-8) - Jan1st1970).TotalMilliseconds;
        }


        /// <summary>
        /// 时间戳转Datetime
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime ConvertToDateTime(this long timeStamp)
        {
            try
            {
                var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                return start.AddMilliseconds(timeStamp);//.AddHours(-8);
            }
            catch
            {
                return new DateTime(1910, 1, 1, 0, 0, 0);
            }
        }


        /// <summary>
        /// 时间戳转Datetime
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime? ConvertToDateTime(this long? timeStamp)
        {
            try
            {
                if (timeStamp.HasValue)
                {
                    var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    return start.AddMilliseconds(timeStamp.Value);//.AddHours(-8);
                }
                else
                    return null;

            }
            catch
            {
                return new DateTime(1910, 1, 1, 0, 0, 0);
            }
        }
    }
}
