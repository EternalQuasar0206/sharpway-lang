using System.Collections.Generic;
using System.Text.RegularExpressions;
using Sharpway.JavaScript;

namespace Sharpway.JavaScript {
    public static class JSParser {
        public static string Parse(string code) {
            /* General Tags Parsing */
            foreach(var n in GeneralContent.GeneralTags) {
                code = code.Replace("\"", "\"&&%quote%&&")
                .Replace("'", "'&&%singlequote%&&")
                .Replace("`", "`&&%specialquote%&&");

                string[] parts = code.Split('\'', '"', '`');
                for (int i = 0; i < parts.Length; i += 2) {
                    parts[i] = parts[i].Replace(n.Key, n.Value);
                }
                code = string.Join("", parts)
                .Replace("&&%quote%&&", "\"")
                .Replace("&&%singlequote%&&", "'")
                .Replace("&&%specialquote%&&", "`");
            }
            return code;
        }
    }
}