using System;
using System.IO;
using System.Net;
using System.Text;

namespace codedecode
{
    public class Dcode
    {
        private string code;
        public string Code
        {
            get { return code; }
        }
        public Dcode()
        {
            code = Convert.ToBase64String(Encoding.UTF8.GetBytes(dateTostring()));
        }
        public void go()
        {
            code = Convert.ToBase64String(Encoding.UTF8.GetBytes(dateTostring()));
        }
        private string dateTostring()
        {
            NistTime n = new NistTime();
            string str = n.GetNowTime().ToString();
            string num = null;
            foreach (char item in str)
            {
                if (item >= 48 && item <= 58)
                {
                    num += item;
                }
            }
            char[] s = num.ToCharArray();
            s[s.Length - 1] = '0';
            s[s.Length - 2] = '0';
            string end = new string(s).Replace(":", "").Trim();
            return end;
        }
    }
}