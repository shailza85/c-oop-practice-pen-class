using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop_practice_pen_class
{
    class Pen //Pen class with Brand, InkColor, InkLevel, MaxInk, HasLid properties
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
                return Math.Round((_inklevel + 2.5)/5.0)*5.0;     //Round inputs to two decimal places
            }

            private set
            {
                //Percentage, must not accept values below 0 or above 100, throw an exception if an attempt to go lower than 0 is made.
                // and clamp values higher than 100 to 100.
                if (value > 100)
                {
                    _inklevel = 100;
                }
                else
                {
                    if (value <= 0)
                    {
                        throw new Exception("Not enough ink level! Cannot print text...");

                    }
                    _inklevel = value;

                }
            }
        }

        //Constructor

        public Pen()
        {
            Brand = "Pilot";
            InkColor = "Red";
            InkLevel = 100;
            MaxInk = 100;
            HasLid = true;
        }
        //Methods created: lower ink level according to the number of characters written, assuming 10 characters for the version without parameters. One character equals 0.05mL of ink usage.
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
