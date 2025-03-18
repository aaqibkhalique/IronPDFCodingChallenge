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

        public static String OldPhonePad(string input)
        {
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

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in input)
            {
                if (item == '#')
                {
                    break;
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
