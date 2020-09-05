using System;
using System.Security.Cryptography;
using System.Text;


namespace CryptaRSA.Clasess
{
   public class Crypro
    {
        // Значение Закрытого ключа

        private static string key = "<RSAKeyValue><Modulus>u72kuOcTxfddOYkifKYlDiO0yGJuGcsumGvfzNk6bspbzNtOmHWKgHDB7p5mOBkxgXiz6OF6hVkuXAF7iTf4/cf8vocsS8ankL+XA3CJLzLJagFCtO6wjJdJMGiSlze4P/9BJIw+44lnRhHj/kN4qJTgBP4SzSFRW0YURia6PWk=</Modulus><Exponent>AQAB</Exponent><P>3Qz5puCJ/QzI4wcEvOP53pMWPXz9ylP9A64OthSyVpuIbhyHltDrjYy+pBab7SGt5A3nPbbgAVo7KD8Fgxcorw==</P><Q>2WxzYaAkYHfJqldE5fZqqHEU6FT24M9jGgFUFjLywHj4tGYSgFpVHY6z8w8ovy/xIfLkoYgAl97PhfFii27RZw==</Q><DP>vaDs5fCHz5JRHxkdQmGcMAkkMhlwqkpEqgx+SEsW9l80uak10/ZjrCmKPb+7gcC7qQEYV4PzRJXAW/U8aEnMtw==</DP><DQ>AqJXu4UPK8QHw3KPOSIFJMlJ8Y6l9w9MKhJ+DE7NthtBGB5sdvWhNlx2PamfWsGf8ENbFcHqD+z5IqxL/1h2XQ==</DQ><InverseQ>kjHbjtkiZ61B6byzTA91b79T6gcPSZUY4XptyPLhEfTRwl37w9rk+56QDJ7qTYHHlaBT6FcREU44NjLjn2TcmA==</InverseQ><D>opkE6P95KKOsogAbVkmvHifekw5svPo0SN5k3k3lRb8M8sedsn1ajxMZY0jczwlCzxdy+ecO7h7m/9ho3dcUVXv1d8d1asd7/xwP9RwmnnFWS7JSXLIkurg2dNVAM6QBLXSRsejkMNLGaUqNJeO7c5PB0P7aHKliJarnN5tO6GE=</D></RSAKeyValue>";



        public static string Decript(string passWord)
        {
            byte[] descontent;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            descontent = rsa.Decrypt(Convert.FromBase64String(passWord), true);
            return _toString(descontent);
        }

        private static byte[] _toByte(string p)
        {
            return Encoding.UTF8.GetBytes(p);
        }

        private static string _toString(byte[] p)
        {
            return Encoding.UTF8.GetString(p);
        }

        internal static string Encript(string p)
        {
            byte[] encContent;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            
            // передача закрытого ключа
            rsa.FromXmlString(key);
            //Возвращаем байтовый массив с зашифрованной строкой
           encContent = rsa.Encrypt(_toByte(p), false);

            return Convert.ToBase64String(encContent);

        }
    }
}
