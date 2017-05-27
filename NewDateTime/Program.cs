using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.ToShortDateString());
            //Console.WriteLine(dt.ToShortTimeString());
            //Console.WriteLine(dt.ToString());


            //string str = "2014/3/24";
            //DateTime d = Convert.ToDateTime(str);
            //Console.WriteLine(d.ToShortDateString());


            #region  Array

          
            Array array = Array.CreateInstance(typeof(int),10);

            for (int i = 0; i <array.Length; i++)
            {
                array.SetValue(i+1,i);
            }


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array.GetValue(i).ToString()+"\t");

            }


       

            Console.ReadKey();

            #endregion
        }
    }
}
