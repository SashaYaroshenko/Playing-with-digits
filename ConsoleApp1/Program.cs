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
            DigPow.digPow(89, 1);
        }
    }

    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            char[] chars = n.ToString().ToCharArray();
            int[] arr = chars.Select(x => (int)char.GetNumericValue(x)).ToArray();
            long sum = arr.Select(x => (long)Math.Pow(x, p++)).Sum();
            //for (int i = 0; i < arr.Length; i++, p++)
            //{
            //    sum += (long)Math.Pow(arr[i], p);
            //}
            if (sum < n || sum % n != 0)
            {
                return -1;
            }
            long res = sum / n;
            return res;
        }
    }
}
