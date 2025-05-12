using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.MetodoExtensao
{
    internal static class StringExtensions
    {
        internal static string InvertString(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
            //usado em tiposdados 4
        }
    }
}
