using System;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;
        private int _mins;
        private int _seconds;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if ((value < 0)&(value > 23))
                {
                    throw new ArgumentException("Часы от 0 до 23");
                }

                _hours = value;
            }
        }
        public int Mins
        {
            get
            {
                return _mins;
            }
            set
            {
                if ((value < 0)&(value > 60))
                {
                    throw new ArgumentException("Минуты от 0 до 60");
                }

                _mins = value;
            }
        }
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if ((value < 0)&(value > 60))
                {
                    throw new ArgumentException("Часы от 0 до 60");
                }

                _seconds = value;
            }
            
        }

        public Time()
        {
            
        }

        public Time(int hours, int mins, int seconds)
        {
            _hours = hours;
            _mins = mins;
            _seconds = seconds;
        }
    }
}