using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "5.5";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",//Учитываем "." при конверте, ведь учитывается ","
            };
            double dbl = double.Parse(str, numberFormatInfo);//Узконаправленный конверт (из строки в число) + учёт знака

            str = "5.5awdawd";
            double.TryParse(str, out dbl);//TryParse не кидает исключения, если не получается распарсить, то скипает
        }
    }
}
