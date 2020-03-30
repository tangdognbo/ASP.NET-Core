using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace core.test.Models
{
    public class delegate1
    {
         public delegate void Collecthomework(string name);

        public static void SayChinese(string name)
        {
            //Console.WriteLine("你好，" + name);
            Debug.WriteLine("你好，" + name);
        }
        public static void SayEnglish(string name)
        {
            Console.WriteLine("hello," + name);
            Debug.Print("hello，" + name);
        }


        public static void SayAll(string name, Collecthomework method)
        {
            method.Invoke(name);
        }

    }


}
