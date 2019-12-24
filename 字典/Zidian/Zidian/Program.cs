using System;
using System.Collections;
using System.Collections.Generic;

namespace Zidian
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> open = new Dictionary<string, string>();
            open.Add("2018031000", "小王");
            open.Add("2018031001", "小张");
            open.Add("2018031002", "小球");
            open.Add("2018031003", "小果");

            Console.WriteLine("-----------------------------------------");
            if (!open.ContainsKey("qq"))
            {
                open.Add("qq", "123456");
                Console.WriteLine("为 键=\"qq\":添加的值是:{0}", open["qq"]);
            }
            Console.WriteLine("-----------------------------------------");


            foreach (KeyValuePair<string,string> pdd in open)
            {
                Console.WriteLine("键 = {0}  值 = {1}", pdd.Key, pdd.Value);
            }
            Console.WriteLine("-----------------------------------------");


            ICollection<string> mm = open.Values;
            Console.WriteLine();
            foreach (string b in mm)
            {
                Console.WriteLine("值 = {0} ", b);
            }
            Console.WriteLine("-----------------------------------------");

            mm = open.Keys;
            Console.WriteLine();
            foreach (string v in mm)
            {
                Console.WriteLine("键 = {0} ", v);
            }


            Console.WriteLine("这个字典类可以通过学号或者姓名来查询对应的数据。");
            Console.ReadLine();

        }
    }
}
