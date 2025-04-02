using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronPDFCodingChallenge
{


    public class Phone
    {
        public static string OldPhonePad(string input)
        {
            if (string.IsNullOrEmpty(input) || !input.EndsWith("#"))
                return string.Empty;

            StringBuilder stringBuilder = new StringBuilder();
            List<KeyPad> keys = KeyPad.GetKeyPads();
            char? lastKey = null;
            int count = 0;

            foreach (char c in input)
            {
                if (c == '#')
                    break;

                if (HandleSpecialKeys(c, stringBuilder, ref lastKey, ref count))
                    continue;

                if (lastKey == c)
                {
                    RemoveLastCharacter(stringBuilder);
                    count++;
                }
                else
                {
                    lastKey = c;
                    count = 0;
                }

                KeyPad? keyPad = keys.Find(k => k.Number == c.ToString());
                if (keyPad != null)
                {
                    stringBuilder.Append(keyPad.Alphabet[count % keyPad.Alphabet.Length]);
                }
            }

            return stringBuilder.ToString();
        }



        private static bool HandleSpecialKeys(char c, StringBuilder stringBuilder, ref char? lastKey, ref int count)
        {
            if (c == '*')
            {
                RemoveLastCharacter(stringBuilder);
                lastKey = null;
                count = 0;
                return true;
            }

            if (c == ' ')
            {
                lastKey = null;
                count = 0;
                return true;
            }

            return false;
        }

        private static void RemoveLastCharacter(StringBuilder stringBuilder)
        {
            if (stringBuilder.Length > 0)
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
        }


    }

}
