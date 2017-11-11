using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Configuration;
using System.Web.Security;

namespace CsharpHttpHelper.Helper
{
	internal class MD5Helper
	{
		internal static string ToMD5_32(string str)
		{
            //string passwordFormat = FormsAuthPasswordFormat.MD5.ToString();
            //return FormsAuthentication.HashPasswordForStoringInConfigFile(str, passwordFormat);
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

		internal static string ToSHA1(string str)
		{
            //string passwordFormat = FormsAuthPasswordFormat.SHA1.ToString();
            //return FormsAuthentication.HashPasswordForStoringInConfigFile(str, passwordFormat);
            SHA1 algorithm = SHA1.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(str));
		    StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                //sh1 += data[i].ToString("x2").ToUpperInvariant();
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
	}
}
