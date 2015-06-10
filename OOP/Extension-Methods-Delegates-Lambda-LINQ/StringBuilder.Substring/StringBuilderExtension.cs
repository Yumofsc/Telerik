namespace StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class SubStringExtension
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            var result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(sb[i + index]);
            }
            return result;
        }
    }
}
