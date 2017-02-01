using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Phone
    {
        //model, touch-screen,ring-tone, volume-setting 
        public string Model { get; set; }
        public bool OnSilent { get; set; }
        public int Volume { get; set; }


        //phone rings, volume settings
        public void Ring()
        {
            if (Volume > 0)
                Console.WriteLine("ring,ring, "+Model + " is ringing");
            else
                Console.WriteLine("...");

        }

        public void VolumeUp()
        {
            Volume++;
        }

        public void VolumeDown()
        {
            Volume--;
        }

        public void IsItOnSilent()
        {

            if (Volume == 0)
                OnSilent = true;
            else
                OnSilent = false;

            Console.WriteLine("Is you're phone " + Model+ " on silent: " +OnSilent);
        }
        public void PrintPhone()
        {
            Console.WriteLine("You're phone is: "+Model + " and the volume is: " +Volume );
            
        }

    }
}
