using System;

namespace Bsort
{
    class Program
    {
        static void Main(string[] args)
        {
            // درست کردن نمونه 
            var sort = new Sorting();
            //دادن یک ارایه به متد و بازگشت ارایه سورت شده
            var sortedarry = sort.bubbleSort(new int[] { 1, 5, 10, 12, 3 ,468,54,22});
            Console.WriteLine("\n");
            //چاپ ارایه سرت شده
            foreach (var item in sortedarry)
            {
                Console.WriteLine(item);
            }
        }
    }
}
