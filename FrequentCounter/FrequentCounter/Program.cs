using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FrequentCounter
{
    class Program
    {
        static void Main1(string[] args)
        {
            //string StringFromTheInput = "https://www.314e.com";
            //HttpWebRequest request_;
            //System.IO.Stream data;
            //ServicePointManager.Expect100Continue = true;
            //ServicePointManager.DefaultConnectionLimit = 9999;
            //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            //request_ = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(StringFromTheInput);
            //System.Net.WebResponse response = request_.GetResponse();
            //data = response.GetResponseStream();
            //string content = String.Empty;

            //using (var client = new WebClient())
            //{
            //    content = client.DownloadString(StringFromTheInput);

            //}
            string content = ScanLinks();

            //Dictionary<string, int> abc = WordCount(content);
            //foreach (KeyValuePair<string, int> author in abc)
            //{
            //    Console.WriteLine("Word: {0}, count: {1}",
            //    author.Key, author.Value);
            //}

            // str = content;
            //str = content.Substring(content.IndexOf("<body "), content.IndexOf("</body>")- content.IndexOf("<body "));
            string str;
            // // regex which match tags
            string content0 = content;
            string Pat = "<(script|style|)\\b[^>]*?>.*?</\\1>";
            str= Regex.Replace(content, Pat, "", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);
            str = Regex.Replace(str, "<style>(.|\n)*?</style>", string.Empty);
            str = Regex.Replace(str, @"<xml>(.|\n)*?</xml>", string.Empty); // remove all <xml></xml> tags and anything inbetween.  
            str= Regex.Replace(str, @"<(.|\n)*?>", string.Empty); // remove any tags but not there content "<p>bob<span> johnson</span></p>" becomes "bob johnson"
            Console.WriteLine(str.TrimEnd().TrimStart());
            str  = str.Replace("\n","");
            str = str.Replace("\t", "");
            str = str.Replace("\r", "");

            string[] a = str.Split(' ');

            
            string content1 = string.Empty;
            string content2 = string.Empty;
            string content3 = string.Empty;
            string content4 = string.Empty;
            string content5 = string.Empty;
            int level = 0;
            MatchCollection mc1;
            MatchCollection mc2;
            MatchCollection mc3;
            MatchCollection mc4;
           
             //   string pattern = @"a href=""<link>.+?)""";
            string pattern ="(?:href|src)=[\"|']?(.*?)[\"|'|>]+";
            
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase| RegexOptions.Singleline | RegexOptions.CultureInvariant);
                MatchCollection mc = regex.Matches(content0);
                foreach (Match m in mc)
                {
                if (m.Groups["link"].Value.Contains("314e"))
                {
                    content1 = ScanLinks(m.Groups["link"].Value);
                    regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    mc1 = regex.Matches(content1);
                    foreach (Match m1 in mc)
                    {
                        if (m1.Groups["link"].Value.Contains("314e"))
                        {
                            content2 = ScanLinks(m1.Groups["link"].Value);
                            regex = new Regex(pattern, RegexOptions.IgnoreCase);
                            mc2 = regex.Matches(content2);
                            foreach (Match m2 in mc2)
                            {
                                if (m2.Groups["link"].Value.Contains("314e"))
                                {
                                    content3 = ScanLinks(m2.Groups["link"].Value);
                                    regex = new Regex(pattern, RegexOptions.IgnoreCase);
                                    mc3 = regex.Matches(content3);
                                    foreach (Match m3 in mc3)
                                    {
                                        if (m3.Groups["link"].Value.Contains("314e"))
                                        {
                                            content4 = ScanLinks(m3.Groups["link"].Value);
                                            regex = new Regex(pattern, RegexOptions.IgnoreCase);
                                            mc4 = regex.Matches(content4);
                                            foreach (Match m4 in mc4)
                                            {
                                                if (m4.Groups["link"].Value.Contains("314e"))
                                                {
                                                    content5 = ScanLinks(m4.Groups["link"].Value);
                                                    Pat = "<(script|style|)\\b[^>]*?>.*?</\\1>";
                                                    content5 = Regex.Replace(content5, Pat, "", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);
                                                    content5 = Regex.Replace(content5, "<style>(.|\n)*?</style>", string.Empty);
                                                    content5 = Regex.Replace(content5, @"<xml>(.|\n)*?</xml>", string.Empty); // remove all <xml></xml> tags and anything inbetween.  
                                                    content5 = Regex.Replace(content5, @"<(.|\n)*?>", string.Empty); // remove any tags but not there content "<p>bob<span> johnson</span></p>" becomes "bob johnson"

                                                    content5 = content5.Replace("\n", "");
                                                    content5 = content5.Replace("\t", "");
                                                    content5 = content5.Replace("\r", "");
                                                    str = str + content5;
                                                }

                                            }
                                            Pat = "<(script|style|)\\b[^>]*?>.*?</\\1>";
                                            content4 = Regex.Replace(content4, Pat, "", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);
                                            content4 = Regex.Replace(content4, "<style>(.|\n)*?</style>", string.Empty);
                                            content4 = Regex.Replace(content4, @"<xml>(.|\n)*?</xml>", string.Empty); // remove all <xml></xml> tags and anything inbetween.  
                                            content4 = Regex.Replace(content4, @"<(.|\n)*?>", string.Empty); // remove any tags but not there content "<p>bob<span> johnson</span></p>" becomes "bob johnson"

                                            content4 = content4.Replace("\n", "");
                                            content4 = content4.Replace("\t", "");
                                            content4 = content4.Replace("\r", "");
                                            str = str + content4;

                                        }


                                    }

                                    Pat = "<(script|style|)\\b[^>]*?>.*?</\\1>";
                                    content3 = Regex.Replace(content3, Pat, "", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);
                                    content3 = Regex.Replace(content3, "<style>(.|\n)*?</style>", string.Empty);
                                    content3 = Regex.Replace(content3, @"<xml>(.|\n)*?</xml>", string.Empty); // remove all <xml></xml> tags and anything inbetween.  
                                    content3 = Regex.Replace(content3, @"<(.|\n)*?>", string.Empty); // remove any tags but not there content "<p>bob<span> johnson</span></p>" becomes "bob johnson"

                                    content3 = content3.Replace("\n", "");
                                    content3 = content3.Replace("\t", "");
                                    content3 = content3.Replace("\r", "");
                                    str = str + content3;
                                }
                                Pat = "<(script|style|)\\b[^>]*?>.*?</\\1>";
                                content1 = Regex.Replace(content1, Pat, "", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);
                                content1 = Regex.Replace(content1, "<style>(.|\n)*?</style>", string.Empty);
                                content1 = Regex.Replace(content1, @"<xml>(.|\n)*?</xml>", string.Empty); // remove all <xml></xml> tags and anything inbetween.  
                                content1 = Regex.Replace(content1, @"<(.|\n)*?>", string.Empty); // remove any tags but not there content "<p>bob<span> johnson</span></p>" becomes "bob johnson"

                                content1 = content1.Replace("\n", "");
                                content1 = content1.Replace("\t", "");
                                content1 = content1.Replace("\r", "");
                                str = str + content1;
                            }



                            Pat = "<(script|style|)\\b[^>]*?>.*?</\\1>";
                            content2 = Regex.Replace(content2, Pat, "", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);
                            content2 = Regex.Replace(content2, "<style>(.|\n)*?</style>", string.Empty);
                            content2 = Regex.Replace(content2, @"<xml>(.|\n)*?</xml>", string.Empty); // remove all <xml></xml> tags and anything inbetween.  
                            content2 = Regex.Replace(content2, @"<(.|\n)*?>", string.Empty); // remove any tags but not there content "<p>bob<span> johnson</span></p>" becomes "bob johnson"

                            content2 = content2.Replace("\n", "");
                            content2 = content2.Replace("\t", "");
                            content2 = content2.Replace("\r", "");
                            str = str + content2;


                        }
                    }

                    content1 = Regex.Replace(content1, Pat, "", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);
                    content1 = Regex.Replace(content2, "<style>(.|\n)*?</style>", string.Empty);
                    content1 = Regex.Replace(content1, @"<xml>(.|\n)*?</xml>", string.Empty); // remove all <xml></xml> tags and anything inbetween.  
                    content1 = Regex.Replace(content1, @"<(.|\n)*?>", string.Empty); // remove any tags but not there content "<p>bob<span> johnson</span></p>" becomes "bob johnson"

                    content1 = content1.Replace("\n", "");
                    content1 = content1.Replace("\t", "");
                    content1 = content1.Replace("\r", "");
                    str = str + content1;
                }
                }
                    Console.WriteLine(str.TrimEnd().TrimStart());
                                Dictionary<string, int> abc = WordCount(str.TrimEnd(new char[] { ' ', ',', ':', '\t', '\"', '\r', '{', '}', '[', ']', '=', '/' }).TrimStart(new char[] { ' ', ',', ':', '\t', '\"', '\r', '{', '}', '[', ']', '=', '/' }).Trim(), 10);
                                foreach (KeyValuePair<string, int> author in abc)
                                {
                                    Console.WriteLine("Word: {0}, count: {1}{2}",
                                    author.Key, author.Value, author.Key.Trim());
                                }


                            
            Console.ReadKey();
        }

        public static string ScanLinks(string link = "https://www.314e.com")
        {
            
            HttpWebRequest request_;
            System.IO.Stream data;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.DefaultConnectionLimit = 9999;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            request_ = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(link);
            System.Net.WebResponse response = request_.GetResponse();
            data = response.GetResponseStream();
            string content = String.Empty;

            using (var client = new WebClient())
            {
                content = client.DownloadString(link);

            }
            return content;
        }

        public static Dictionary<string, int> WordCount(string content, int numWords = int.MaxValue)
        {
            var delimiterChars = new char[] { ' ', ',', ':', '\t', '\"', '\r', '{', '}', '[', ']', '=', '/' };
            return content
                .Split(delimiterChars)
                .Where(x => x.Length > 0)
                .Select(x => x.ToLower())
                .GroupBy(x => x)
                .Select(x => new { Word = x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Count)
                .Take(numWords)
                .ToDictionary(x => x.Word, x => x.Count);
        }


    }



}
