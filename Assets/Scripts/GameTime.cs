using System;
using UnityEngine;

namespace Game
{
    public static class GameTime
    {
        private const int HOURS_PER_DAY = 24;
        private const int MINUTES_PER_HOUR = 60;
        
        private static int _day = -1;
        private static int _hour = -1;
        private static int _minute = -1;

        public static Action<string> OnTimeChanged;

        public static void InitTime(int day = 0, int hour = 0, int minute = 0){
            if ( 0 <= _day|| 0 <= _hour || 0 <= _minute){
                Debug.LogError("GameTime init the second time");
            }
            
            _day = day;
            _hour = hour;
            _minute = minute;
        }

        public static void AddTime(int hour, int minute){
            _minute += minute;
            var extraHour = _minute / MINUTES_PER_HOUR;
            if (extraHour > 0){
                _hour += extraHour;
                _minute = _minute % MINUTES_PER_HOUR;
            }
            
            _hour += hour;
            var extraDay = _hour / HOURS_PER_DAY;
            if (extraDay > 0){
                _day += extraDay;
                _hour = _hour % HOURS_PER_DAY;
            }
            
            OnTimeChanged?.Invoke(ClockToString());
        }

        public static string ClockToString(){
            var clockText = _hour.ToString("00") + ":" + _minute.ToString("00");
            return clockText;
        }
    }
}