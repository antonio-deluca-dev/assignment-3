using System;
using System.Text;

public class StringCompressor
{
    public string Compress(string str)
    {
        if (string.IsNullOrEmpty(str)) return str;

        StringBuilder compressed = new StringBuilder();
        int count = 1;

        for (int i = 0; i < str.Length; i++)
        {
            if (i + 1 < str.Length && str[i] == str[i + 1])
            {
                count++;
            }
            else
            {
                compressed.Append(str[i]).Append(count);
                count = 1;
            }
        }

        return compressed.Length < str.Length ? compressed.ToString() : str;
    }
}
