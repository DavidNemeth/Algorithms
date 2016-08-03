using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class CaesarCipher
    {
        protected char[] encoder = new char[26];
        protected char[] decoder = new char[26];

        public CaesarCipher(int rotation)
        {
            for (int k = 0; k < 26; k++)
            {
                encoder[k] = (char)('A' + (k + rotation) % 26);
                decoder[k] = (char)('A' + (k - rotation + 26) % 26);
            }
        }

        public string Encrypt(string message)
        {
            return transform(message, encoder);
        }

        public string Decrypt(string secret)
        {
            return transform(secret, decoder);
        }

        private string transform(string original, char[] code)
        {
            char[] msg = original.ToCharArray();
            for (int k = 0; k < msg.Length; k++)
            {
                if (char.IsUpper(msg[k]))
                {
                    int j = msg[k] - 'A';
                    msg[k] = code[j];
                }
            }
            return new string(msg);
        }
    }
}
