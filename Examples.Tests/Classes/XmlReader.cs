using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Examples.Tests.Classes
{
    public static class XmlReader
    {
        public static string ToXml(this object obj)
        {
            var s = new XmlSerializer(obj.GetType());
            using (var writer = new StringWriter())
            {
                s.Serialize(writer, obj);
                return writer.ToString();
            }
        }

        public static T FromXml<T>(this string data)
        {
            var s = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(data))
            {
                object obj = s.Deserialize(reader);
                return (T)obj;
            }
        } 
    }
}
