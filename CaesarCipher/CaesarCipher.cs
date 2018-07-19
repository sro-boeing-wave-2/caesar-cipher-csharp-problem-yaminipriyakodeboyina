using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            String s=""; int j;
            for (int i = 0; i < text.Length; i++)
            {
                j = 0;
                if (char.IsLetter(text[i]))
                {
                    int d;
                    d = char.IsUpper(text[i]) ? 'A' : 'a';
                    j = ((((text[i]) + shiftKey)-d) % 26) + d;
                    s += (char)j;
                }
                else
                    s += text[i]; 
            }
            return s;
        }
    }
}
