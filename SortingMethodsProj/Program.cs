//https://stackoverflow.com/questions/68765332/c-sharp-sort-order-a-textbox-with-given-values/70571196#70571196

using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingMethodsProj
{
    public class Sort
    {
        public string Sorting(string[] text)
        {            
            string txtText = "";
            IEnumerable<string> query = text.OrderBy(i => i.ToString());

            foreach (string r in query)
            {
                txtText += $"{r}\n";
            }
            return txtText;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            string text = "2021-12-08|" + "2020-04-12|" + "2021-06-15|" + "2022-11-28|" + "2019-01-12|" ;
            Sort sort = new Sort();
            string[] test = text.Split('|');
            Console.WriteLine(sort.Sorting(test));
        }
    }
}
