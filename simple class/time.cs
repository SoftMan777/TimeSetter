using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timesetter
{
  public class Program
    {
        public class TimeExcepts : Exception
        {
            public override string Message
            {
                get
                {
                    return "Ошибка изменения значений времени.";
                }
            }
        }
        public class HoursExcept : TimeExcepts
        {
            public override string Message
            {
                get
                {
                    return base.Message + " Вы ввели недопустимое значение для переменной Часы.";
                }
            }
        }
        public class MinutesExcept : TimeExcepts
        {
            public override string Message
            {
                get
                {
                    return base.Message + " Вы ввели недопустимое значение для переменной Минуты.";
                }
            }
        }
        public class SecondsExcept : TimeExcepts
        {
            public override string Message
            {
                get
                {
                    return base.Message + " Вы ввели недопустимое значение для переменной Секунды.";
                }
            }
        }
        public class Time
        {
            private int hours = 0;
            private int minuts = 0;
            private int seconds = 0;
            public Time(int hours, int minuts, int seconds)
            {
                SetTime(hours, minuts, seconds);
            }
            public Time() { }
            public int Hours
            {
                get { return hours; }
                set { hours = value; }
            }
            public int Minutes
            {
                get { return minuts; }
                set { minuts = value; }
            }
            public int Seconds
            {
                get { return seconds; }
                set { seconds = value; }

            }
            public void SetTime(int hours, int minuts, int seconds)
            {
                Hours = hours;
                Minutes = minuts;
                Seconds = seconds;
            }
        }
        
        }
    }

