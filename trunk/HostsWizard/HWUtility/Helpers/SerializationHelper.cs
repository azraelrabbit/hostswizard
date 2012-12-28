using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HWUtility.Helpers
{
    public class SerializationHelper
    {
        /// <summary>
        /// 序列化数据
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>二进制流</returns>
        public static byte[] GetBinaryFormatSerialize(object obj)
        {
            //创建支持存储区为内存的流
            MemoryStream Memory = new MemoryStream();
            //以二进制格式将整个连接对象图形序列化和反序列化
            BinaryFormatter formatter = new BinaryFormatter();
            //将对象序列化为附加所提供标题的给定流 
            formatter.Serialize(Memory, obj);
            byte[] buff = Memory.ToArray();
            Memory.Close();
            Memory.Dispose();
            return buff;
        }

        /// <summary>
        /// 反序列化对象
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="buff">二进制数据</param>
        /// <returns>反序列后结果</returns>
        public static T RetrieveDeserialize<T>(byte[] buff)
        {
            //创建支持存储区为内存的流
            MemoryStream Memory = new MemoryStream();
            //以二进制格式将整个连接对象图形序列化和反序列化。
            BinaryFormatter formatter = new BinaryFormatter();
            return (T)formatter.Deserialize(new MemoryStream(buff));
        }
    }
}
