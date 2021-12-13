using System;
using System.Collections.Generic;
using System.Text;

namespace Bsort
{
    class Sorting
    {
        //بابل سرت :یک ارایه را میگیرد و یه ارایه سرت شده برمیگرداند
        public int[] bubbleSort( int[] arry )
        {
            //طول ارایه
            var lenght = arry.Length;
            //ساختار الگوریتم
            for (int i = 0; i < lenght-1; i++)
            {
                for (int j = 0; j < lenght - i - 1; j++)
                {
                    //اگر دیتای اندیس اوا بزگ تر از اندیس بعدی بود
                    if (arry[j] > arry[j + 1])
                    {
                        //تعویض اندیس ها
                        var samp = arry[j];
                        arry[j] = arry[j + 1];
                        arry[j + 1] = samp;
                        Console.WriteLine($"we swap space "+j+" and "+(j+1)+" :  values  was vlaue "+arry[j]+" and " + arry[j+1] );
                    }
                }
            }
            //برگرداندن ارایه سرت شده
            return arry;
        }
    }
}
