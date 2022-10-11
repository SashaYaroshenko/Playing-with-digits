using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DigPow.digPow(-89, 1);
        }
    }

    public class DigPow
    {
        public static long digPow(int n, int p)
        {        
            n = Math.Abs(n);
            char[]chars = n.ToString().ToCharArray();
            List<double> charsDouble = new List<double>();
            for(int i = 0; i < chars.Length; i++)
            {
                charsDouble.Add(Convert.ToDouble(chars[i].ToString()));
            }
            double sum = 0;
            for(int i = 0; i < charsDouble.Count; i++)
            {
                sum += Math.Pow(charsDouble[i], p);
                p++;
            }
            if(sum<n)
            {
                return -1;
            }
            double res = sum/ n;
            return Convert.ToInt64(res.ToString());
        }
    }
}
