using System;
using System.Linq;

public static class Utils {

    public static int ToInt(this string txt) { return Convert.ToInt32(txt); }
    public static string RandomString(int length = 64) {
        Random random = new();
        const string chars = "0123456789ABCDEF";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static string TakeChar(this string txt, int length) {
        if (string.IsNullOrEmpty(txt))
            throw new Exception("String is empty");
        
        if (txt.Length < length) return txt;
        return txt.ToString().Substring(0, length);
    }
}
