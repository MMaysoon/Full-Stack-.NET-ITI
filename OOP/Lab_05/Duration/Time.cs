using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duration
{
    internal class Time
    {
        int hours;
        int minutes;
        int seconds;

        #region ctor get 3 paramter
        public Time(int _hours, int _minutes, int _seconds)
        {
            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
            Normailze();
        }
        #endregion

        #region ctor get total seconds
        public Time(int totalSeconds)
        {
            hours = totalSeconds / 3600;
            totalSeconds%=3600;

            minutes = totalSeconds / 60;

            seconds = totalSeconds % 60;
        }
        #endregion

        #region Normalize
        private void Normailze()
        {
            if (minutes >= 60)
            {
                hours += minutes / 60;
                minutes %= 60;
            }

            if (seconds >= 60)
            {
                minutes += seconds / 60;
                seconds %= 60;
            }
        }
        #endregion


        #region Operator OverLoad
        public static Time operator +(Time a, Time b)
        {
            // new -> call auto ctor and apply ctor
            return new Time(a.hours + b.hours,
                            a.minutes + b.minutes,
                            a.seconds + a.seconds);
        }

        public static Time operator ++(Time a)
        {
            // only edit minutes so need to normalize time
            a.minutes++;
            a.Normailze();
            return a;
        }


        #endregion

        #region Tostring 
        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
        #endregion
    }
}
