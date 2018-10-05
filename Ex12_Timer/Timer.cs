using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Timer
{
    public class Timer
    {
        string finalTime;
        string hours = "00";
        string minuts= "00";
        int minutCounter = 0;
        int hourCounter = 0;

        public int Seconds { get; set; }

        public string ToString()
        {
            if (0 <= Seconds && 59 >= Seconds)
            {
                if (Seconds > 9)
                {
                    finalTime = hours +":"+ minuts +":"+ Seconds;
                }
                else
                {
                    finalTime = hours + ":"+ minuts + ":0" + Seconds;
                }
            }
            else if (60 <=Seconds && 3600 > Seconds)
            {
                while (Seconds >= 60)
                {
                    Seconds -= 60;
                    minutCounter++;
                }
                if (minutCounter <10 && Seconds <10)
                {
                    finalTime = hours + ":0" + minutCounter + ":0"+Seconds;
                }
                else if (minutCounter > 10 && Seconds <10)
                {
                    finalTime = hours + ":" + minutCounter + ":0" + Seconds;
                }
                else if (minutCounter <10 && Seconds > 10)
                {
                    finalTime = hours + ":0" + minutCounter + ":" + Seconds;
                }
                else
                {
                    finalTime = hours + ":" + minutCounter + ":" + Seconds;
                }
            }
            else
            {
                while (Seconds >= 60)
                {
                    Seconds -= 60;
                    minutCounter++;
                }
                while (minutCounter >= 60)
                {
                    minutCounter -= 60;
                    hourCounter++;
                }
                if (minutCounter < 10 && Seconds < 10)
                {
                    finalTime = "0" + hourCounter + ":0" + minutCounter + ":0" + Seconds;
                }
                else if (minutCounter > 10 && Seconds < 10)
                {
                    finalTime = "0" + hourCounter + ":" + minutCounter + ":0" + Seconds;
                }
                else if (minutCounter < 10 && Seconds > 10)
                {
                    finalTime = "0" + hourCounter + ":0" + minutCounter + ":" + Seconds;
                }
                else
                {
                    finalTime = "0"+ hourCounter + ":" + minutCounter + ":" + Seconds;
                }
            }
            return finalTime;
        }

        public string Padded(int v)
        {
            finalTime = Convert.ToString(v);
            if (v < 10)
            {
                return "0"+finalTime;
            }
            else
            {
                return finalTime;
            }
            
        }
    }
}
