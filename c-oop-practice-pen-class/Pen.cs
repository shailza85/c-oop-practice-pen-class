using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop_practice_pen_class
{
    class Pen
    {

        public string Brand { get; set; }

        public string InkColor { get; set; }

       
        public int MaxInk { get; set; }

        public Boolean HasLid { get; set; }

        private double _inklevel;

        public double InkLevel
        {
            get
            {
                return Math.Round((_inklevel + 2.5)/5.0)*5.0;     
            }

            private set
            {
                if (value > 100)
                {
                    _inklevel = 100;
                }
                else
                {
                    if (value <= 0)
                    {
                        throw new Exception("Not enough ink level! Cannot print...");

                    }
                    _inklevel = value;

                }
            }
        }

        

        public Pen()
        {
            Brand = "Pilot";
            InkColor = "Red";
            InkLevel = 100;
            MaxInk = 100;
            HasLid = true;
        }

        public void Write()
        {
            string myString = "Shailza Sharma";
            double length = myString.Length;
            InkLevel -=((length/0.05)/MaxInk);
            Console.WriteLine("After printing Ink level is:"+InkLevel + "%");

        }

        public void Write(string characterCount)
        {
            string myString = characterCount;
            double lengthOfString = myString.Length;
            InkLevel -=((lengthOfString/0.05)/MaxInk);

           Console.WriteLine("After printing Ink level is:" + InkLevel+ "%");
            
        }
    }
}
