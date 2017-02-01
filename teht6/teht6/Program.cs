using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Iphone 
            Phone iphone = new Phone();
            iphone.Model = "iphone 6S";
            iphone.Volume = 5;

            Phone huawei = new Phone();
            huawei.Model = "Honor 8";
            huawei.Volume = 0;

            iphone.PrintPhone();
            Console.ReadLine();
            huawei.PrintPhone();
            Console.ReadLine();

            iphone.Ring();
            Console.ReadLine();

            for (int i=0; i<5;i++)
            {
                iphone.VolumeDown();
            }

            iphone.PrintPhone();
            Console.ReadLine();

            iphone.IsItOnSilent();
            Console.ReadLine();

            huawei.VolumeUp();
            Console.ReadLine();

            huawei.Ring();
            Console.ReadLine();




        }
    }
}
