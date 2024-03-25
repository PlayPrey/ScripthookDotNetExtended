using GTA.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScripthookDotNetExtended
{
    public static class Time
    {
        [Description("Sets the time of day to the desired time and locks it. Time must be released if you want it to change later.")]
        public static void FORCE_TIME_OF_DAY(int hour, int minute)
        {
            Function.Call("FORCE_TIME_OF_DAY", hour, minute);
        }



        [Description("Sets the time of day. Will skip to next day if time already passed.")]
        public static void FORWARD_TO_TIME_OF_DAY(int hour, int minute)
        {
            Function.Call("FORWARD_TO_TIME_OF_DAY", hour, minute);
        }



        [Description("[Not figured out]")]
        public static void GET_CURRENT_DATE(ref int day, ref int month)
        {
            Function.Call("GET_CURRENT_DATE",  day, month);           
        }



        [Description("Gets the current day of the week as an integer, starting from Sunday.")]
        public static int GET_CURRENT_DAY_OF_WEEK
        {
            get
            {
                return Function.Call<int>("GET_CURRENT_DAY_OF_WEEK");
            }
        }



        [Description("Gets the current hour clock.")]
        public static int GET_HOURS_OF_DAY
        {
            get
            {
                return Function.Call<int>("GET_HOURS_OF_DAY");
            }
        }



        [Description("Gets the current minute clock.")]
        public static int GET_MINUTES_OF_DAY
        {
            get
            {
                return Function.Call<int>("GET_MINUTES_OF_DAY");
            }
        }



        [Description("Returns how many minutes it is until the desired time of day.")]
        public static int GET_MINUTES_TO_TIME_OF_DAY(int hour, int minute)
        {
                return Function.Call<int>("GET_MINUTES_TO_TIME_OF_DAY", hour, minute);           
        }



        [Description("Releases the time again if you've earlier forced it to some value.")]
        public static void RELEASE_TIME_OF_DAY()
        {
            Function.Call("RELEASE_TIME_OF_DAY");
        }



    }
}
