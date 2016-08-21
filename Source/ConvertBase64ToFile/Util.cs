using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertBase64ToFile
{
    internal class Util
    {
        internal enum ConvertTo { File, Base64 }
        internal enum OpenGeneratedFileType { Folder, File, None}

        internal string GetBase64String(string xmlString)
        {
            if (string.IsNullOrWhiteSpace(xmlString))
            {
                return xmlString;
            }
            
            const string regexReplaceTabSpaceCarageReturns = @"\t|\n|\r|\s+";
            xmlString = Regex.Replace(xmlString, regexReplaceTabSpaceCarageReturns, "");
                        
            string longestString = string.Empty;
            int longestStringLength = 0;

            const string regexMatchValueInXmlElements = @"(?<=\>)(.*?)(?=\<)";
            Regex rx = new Regex(regexMatchValueInXmlElements);

            foreach (Match match in rx.Matches(xmlString))
            {
                if (match.Value.Length > longestStringLength)
                {
                    longestString = match.Value;
                    longestStringLength = match.Value.Length;
                }
            }

            if (string.IsNullOrWhiteSpace(longestString))
            {
                //If we reach here then input sting is not xml and therefore returning input string
                longestString = xmlString;
            }

            longestString = RemoveCdata(longestString);

            return longestString;

        }

        internal string RemoveCdata(string input)
        {
            string output = string.Empty;

            try {
                const string regexMatchContentInCdata = @"(?<=<!\[CDATA\[)(.*\n?)(?=\]\]>)";
                output = Regex.Match(input, regexMatchContentInCdata).Groups[1].Value;
            }
            catch
            {
                //String is not in Cdata
            }

            if (string.IsNullOrWhiteSpace(output))
            {
                output = input;
            }

            return output;
        }

        internal void ConvertBase64ToFile(string filePath, string base64String)
        {
            File.WriteAllBytes(filePath, Convert.FromBase64String(base64String));
        }

        internal string ConvertFileToBase64(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            return Convert.ToBase64String(bytes);
        }
    }
}
