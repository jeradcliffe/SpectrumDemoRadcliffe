using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;

namespace SpectrumDemoRadcliffe.Models.Utils
{
    public class SecurityUtils
    {
        public byte[] GetHash(String password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            return sha256.ComputeHash(bytes);
        }

        public String GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString());
            }
            return result.ToString();
        }

        public String GetStringFromHash(String password)
        {
            return GetStringFromHash(GetHash(password));
        }
    }
}
