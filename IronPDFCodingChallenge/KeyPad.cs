using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronPDFCodingChallenge
{
    public class KeyPad
    {
        public string Number { get; set; }
        public string Alphabet { get; set; }
        public KeyPad(string number, string alphabet)
        {
            Number = number;
            Alphabet = alphabet;
        }


        public static List<KeyPad> GetKeyPads()
        {
            return new List<KeyPad>
            {
                new KeyPad("1", "&'("),
                new KeyPad("2", "ABC"),
                new KeyPad("3", "DEF"),
                new KeyPad("4", "GHI"),
                new KeyPad("5", "JKL"),
                new KeyPad("6", "MNO"),
                new KeyPad("7", "PQRS"),
                new KeyPad("8", "TUV"),
                new KeyPad("9", "WXYZ"),
                new KeyPad("0", " ")
            };
        }

    }
}
