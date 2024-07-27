using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_me
{
    public static class StringExtension
    {
            public static string ToMasked(this string textToMask)
            {
                int visibleLength = 4;
                string result = string.Empty;

                if (string.IsNullOrEmpty(textToMask))
                {
                    return result;
                }

                int length = textToMask.Length;
                result = textToMask.Substring(0, visibleLength) + new string('*', length - visibleLength);

                return result;
            }
    }
}
