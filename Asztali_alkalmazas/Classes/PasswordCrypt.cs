using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazas.Classes
{
    internal class PasswordCrypt
    {
        public string CryptedPwd { get; private set; }


        public string titkosPWD(string pwd)
        {
            CryptedPwd = EncodePasswd(pwd);
            return CryptedPwd;
        }
        private string EncodePasswd(string password)
        {
            try
            {
                byte[] titkoskulcs = new byte[password.Length];
                titkoskulcs = Encoding.UTF8.GetBytes(password);
                string kodoltpassword = Convert.ToBase64String(titkoskulcs);
                return kodoltpassword;
            }
            catch (Exception ex)
            {

                throw new Exception("Hiba a kódolásnál!" + ex.Message);
            }
        }

        public string fejtettPWD(string pwd)
        {
            string fejtettPwd = DecodePasswd(pwd);
            return fejtettPwd;
        }

        private string DecodePasswd(string kodoltpassword)
        {
            try
            {
                UTF8Encoding encoder = new UTF8Encoding();
                Decoder utf8decoder = encoder.GetDecoder();
                byte[] decode_byte = Convert.FromBase64String(kodoltpassword);
                int karakterDB = utf8decoder.GetCharCount(decode_byte, 0, decode_byte.Length);
                char[] decode_char = new char[karakterDB];
                utf8decoder.GetChars(decode_byte, 0, decode_byte.Length, decode_char, 0);
                string eredmeny = new string(decode_char);
                return eredmeny;
            }
            catch (Exception ex)
            {

                throw new Exception("Hiba a kódolás visszafejtésénél!" + ex.Message);
            }

        }
    }
}
