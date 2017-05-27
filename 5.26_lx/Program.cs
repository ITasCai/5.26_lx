using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._26_lx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个最小值：");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入一个最大值：");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你要获取元素的个数：");
            int count = Convert.ToInt32(Console.ReadLine());

            GetShow(min,max,count);
            Console.ReadKey();

        }

        //private static void GetShow(int min, int max, int count)
        //{
        //    int[] num = new int[count];

        //    for (int i = 0; i < num.Length; i++)
        //    {

        //    }

        //}

        private static void GetShow(int min, int max, int count)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int temp = random.Next(min, max);
                if (!list.Contains(temp))
                {
                    list.Add(temp);
                }

            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(" "+list[i]);
            }

        }
    }
}
