using RtfDomParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rtf2HtmlConverter
{
    public class RTF2HTMLConverter
    {
        /// <summary>
        /// Simply converts the given RTF string into HTML using the specified encoding.
        /// </summary>
        /// <param name="inputRTF"></param>
        /// <param name="encoding"></param>
        /// <returns>HTML without body-tag</returns>
        public static string Convert(string inputRTF, Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.Default;

            using (MemoryStream ms = new MemoryStream())
            {
                RTF2HTMLConverter.Convert(inputRTF, ms);

                return encoding.GetString(ms.GetBuffer(), 0, ms.GetBuffer().Length);
            }
        }

        /// <summary>
        /// Simply converts the given RTF string into HTML and outputs it trough the given stream.
        /// </summary>
        /// <param name="inputRTF"></param>
        /// <param name="outputStream">Stream used for writing the HTML (doesn't contain a body-tag)</param>
        public static void Convert(string inputRTF, Stream outputStream)
        {
            using (StringReader sr = new StringReader(inputRTF))
            {
                RTFDomDocument doc = new RTFDomDocument();
                doc.Load(sr);

                string dom = doc.ToDomString();

                RTFDom2HTMLConverter converter = new RTFDom2HTMLConverter(doc);
                converter.Convert(outputStream);

            }
        }
    }
}
