using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringCase
{
    public static class StringReverser
    {
        public static string ReverseByLinq(string input)
        {
            return new string(input.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
                      char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
        }
        public static string Reverse(string input)
        {
            char[] c = input.ToCharArray();
            string result = "";
            foreach (char item in c)
            {
                if (char.IsLetter(item))
                {
                    if (char.IsLower(item))
                    {
                        result += char.ToUpper(item);
                    }
                    else
                    {
                        result+=char.ToLower(item);
                    }
                }
                else
                {
                    result+=item;
                }
            }
            return result;
        }
    }
}
