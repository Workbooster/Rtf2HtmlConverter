using RtfDomParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rtf2HtmlConverter
{
    public class RTFDom2HTMLConverter
    {
        private RTFDomDocument Document { get; set; }

        /// <summary>
        /// Creates HTML code from the given RTFDomDocument
        /// </summary>
        /// <param name="doc"></param>
        public RTFDom2HTMLConverter(RTFDomDocument doc)
        {
            Document = doc;
        }

        public void Convert(StreamWriter writer)
        {
            ConvertDomElement(writer, Document.Elements);
        }

        public void Convert(Stream stream)
        {
            using (StreamWriter writer = new StreamWriter(stream))
            {
                ConvertDomElement(writer, Document.Elements);
            }
        }

        private void ConvertDomElement(StreamWriter writer, RTFDomElement domElement)
        {
            if (domElement is RTFDomField)
                ConvertDomElement(writer, (RTFDomField)domElement);
            else if (domElement is RTFDomField)
                ConvertDomElement(writer, (RTFDomField)domElement);
            else if (domElement is RTFDomParagraph)
                ConvertDomElement(writer, (RTFDomParagraph)domElement);
            else if (domElement is RTFDomText)
                ConvertDomElement(writer, (RTFDomText)domElement);
            else if (domElement is RTFDomField)
                ConvertDomElement(writer, (RTFDomField)domElement);
            else if (domElement is RTFDomElementContainer)
                ConvertDomElement(writer, (RTFDomElementContainer)domElement);
        }

        private void ConvertDomElement(StreamWriter writer, RTFDomElementList domElement)
        {
            if (domElement != null && domElement.Count > 0)
            {
                foreach (RTFDomElement item in domElement)
                {
                    ConvertDomElement(writer, item);
                }
            }
        }

        private void ConvertDomElement(StreamWriter writer, RTFDomElementContainer domElement)
        {
            // do not handle instruction containers
            if (domElement.Name == "fldinst")
                return;

            ConvertDomElement(writer, domElement.Elements);
        }

        private void ConvertDomElement(StreamWriter writer, RTFDomField domElement)
        {
            string url = null;

            if (domElement.Instructions != null)
            {
                var urlRegex = Regex.Match(domElement.Instructions, "HYPERLINK\\s\"([^\"]*)\"");

                if (urlRegex.Groups.Count > 1)
                {
                    url = urlRegex.Groups[1].Value;
                }
            }

            if (url != null)
            {
                // it's a hyperlink

                writer.WriteLine(String.Format(@"<a href=""{0}"">", url));
                ConvertDomElement(writer, domElement.Elements);
                writer.WriteLine("</a>");
            }
            else
            {
                ConvertDomElement(writer, domElement.Elements);
            }
        }

        private void ConvertDomElement(StreamWriter writer, RTFDomParagraph domElement)
        {
            string startStyles = GetParagraphStyles(domElement);

            string startContent;
            if (startStyles == "")
            {
                startContent = "<div>";
            }
            else
            {
                startContent = String.Format(@"<div style=""{0}"">", startStyles);
            }

            writer.WriteLine(startContent);
            ConvertDomElement(writer, domElement.Elements);
            writer.WriteLine("</div>");
        }

        private void ConvertDomElement(StreamWriter writer, RTFDomText domElement)
        {
            string styles = GetTextStyles(domElement);
            string content;
            if (styles == "")
            {
                content = domElement.Text;

            }
            else
            {
                content = String.Format(@"<span style=""{0}"">{1}</span>"
                    , styles
                    , domElement.Text);
            }

            writer.WriteLine(content);
            ConvertDomElement(writer, domElement.Elements);
        }

        private string GetParagraphStyles(RTFDomParagraph domElement)
        {
            string styles = "";

            // only apply style attributes if there are any value different than default
            if (domElement.Format.SpacingBefore != 0
                || domElement.Format.LeftIndent != 0
                || domElement.Format.SpacingAfter != 0)
            {
                styles += String.Format("padding:{0}px {1}px {2}px {3}px;"
                    , domElement.Format.SpacingBefore / 10
                    , domElement.Format.LeftIndent / 10
                    , domElement.Format.SpacingAfter / 10
                    , 0);
            }

            return styles;
        }

        private string GetTextStyles(RTFDomText domElement)
        {
            string styles = "";

            if (domElement.Format.FontSize != 12)
            {
                styles += String.Format("font-size:{0}px;", domElement.Format.FontSize);
            }

            if (domElement.Format.TextColor.ToArgb() != -16777216)
            {
                styles += String.Format("color:rgb({0},{1},{2});"
                    , domElement.Format.TextColor.R.ToString()
                    , domElement.Format.TextColor.G.ToString()
                    , domElement.Format.TextColor.B.ToString());
            }

            if (domElement.Format.Bold)
                styles += "font-weight:bold;";
            if (domElement.Format.Italic)
                styles += "font-style:italic;";
            if (domElement.Format.Underline)
                styles += "text-decoration:underline;";

            return styles;
        }
    }
}
