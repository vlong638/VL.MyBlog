using VL.MyBlog.Common.Cache;
using System.Collections.Generic;

namespace VL.MyBlog.Common
{
    /// <summary>
    /// 静态量,常量
    /// </summary>
    public class APIContraints
    {
        /// <summary>
        /// 数据库配置
        /// </summary>
        public static DBConfig DBConfig { set; get; }
        /// <summary>
        /// Redis
        /// </summary>
        public static RedisCache RedisCache { get; set; }
    }
}
