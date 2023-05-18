using System.Security.Cryptography;
using System.Text;

namespace MachBankingApp
{
    internal class Encrypt
    {
        public static string HashString(string passwordString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(passwordString))
            {
                sb.Append(b.ToString("X3"));
            }
            return sb.ToString();
        }

        public static byte[] GetHash(string passwordString)
        {
            using (HashAlgorithm alg = SHA256.Create())
            {  
                return alg.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
            }
        }
    }
}
