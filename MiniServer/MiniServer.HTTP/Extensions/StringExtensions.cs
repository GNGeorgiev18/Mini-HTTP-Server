using System;
using System.Collections.Generic;
using System.Text;

namespace MiniServer.HTTP.Extensions
{
    public static class StringExtensions
    {
        public static void Capitalize(string text) {
             Char.ToUpper(text[0]);
        }
    }
}
