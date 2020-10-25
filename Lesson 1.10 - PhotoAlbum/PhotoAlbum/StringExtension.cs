using System;

namespace PhotoAlbum
{
    public static class StringExtension
    {
        public static string ToCamelCase(this string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length > 1)
            {
                return str[0].ToString().ToUpper() + str.Substring(1);
            }
            return str;
        }
    }
}