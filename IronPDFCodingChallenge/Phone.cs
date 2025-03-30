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
            List<KeyPad> keys = new List<KeyPad>();
            keys.Add(new KeyPad { Number = "1", Alphabet = "&'(" });
            keys.Add(new KeyPad { Number = "2", Alphabet = "ABC" });
            keys.Add(new KeyPad { Number = "3", Alphabet = "DEF" });
            keys.Add(new KeyPad { Number = "4", Alphabet = "GHI" });
            keys.Add(new KeyPad { Number = "5", Alphabet = "JKL" });
            keys.Add(new KeyPad { Number = "6", Alphabet = "MNO" });
            keys.Add(new KeyPad { Number = "7", Alphabet = "PQRS" });
            keys.Add(new KeyPad { Number = "8", Alphabet = "TUV" });
            keys.Add(new KeyPad { Number = "9", Alphabet = "WXYZ" });
            keys.Add(new KeyPad { Number = "0", Alphabet = " " });

            char? lastKey = null;
            int count = 0;

            foreach (char c in input)
            {
                if (c == '#')
                    break;

                if (c == '*')
                {
                    if (stringBuilder.Length > 0)
                        stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    lastKey = null;
                    count = 0;
                    continue;
                }

                if (c == ' ')
                {
                    lastKey = null;
                    count = 0;
                    continue;
                }

                if (lastKey == c)
                {
                  
                    lastKey = c;
                    count++;
                }
                else
                {
                  
                    lastKey = c;
                    count = 0;
                }

                KeyPad keyPad = keys.Find(k => k.Number == c.ToString());
                if (keyPad != null)
                {
                    stringBuilder.Append(keyPad.Alphabet[count % keyPad.Alphabet.Length]);
                }
            }

            return stringBuilder.ToString();
        }
    }


    public class KeyPad
    {
        public string Number { get; set; }
        public string Alphabet { get; set; }

    }
}
