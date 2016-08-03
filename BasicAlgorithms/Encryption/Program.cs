using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher cipher = new CaesarCipher(3);
            string message = "THE EAGLE IS IN PLAY; MEET AT JOE'S.";
            string coded = cipher.Encrypt(message);
            Console.WriteLine("secret: {0}", coded);
            string answer = cipher.Decrypt(coded);
            Console.WriteLine("message: {0}", answer);
        }
    }
}
