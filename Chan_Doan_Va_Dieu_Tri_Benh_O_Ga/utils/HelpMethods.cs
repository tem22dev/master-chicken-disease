using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.utils
{
    static class HelpMethods
    {
        public static int[] NumberStringToArr(string str) {

            str = Regex.Replace(str, @"[,\[\]]", " ");
            string[] strArr = str.Trim().Split(' ');

            int count = 0;

            int[] arr = new int[strArr.Length];

            foreach (string n in strArr)
            {

                if(n == "")
                {
                    arr[0] = 0;
                    return arr;
                }
                arr[count] = int.Parse(n);
            
                count++;
            }

            return arr;
        }

        public static string NumberArrToString(int[] intArr)
        {

            return "[" + string.Join(", ", intArr) + "]";
        }
    }
}
