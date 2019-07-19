using System;

namespace Game
{
    public class GameTime
    {
        private const int HOURS_PER_DAY = 24;
        private const int MINUTES_PER_HOUR = 60;
        
        private int _day = 0;
        private int _hour = 0;
        private int _minute = 0;

        public Action<string> OnTimeChanged;


        public GameTime(int day = 0, int hour = 0, int minute = 0){
            _day = day;
            _hour = hour;
            _minute = minute;
        }

        public void ChangeTime(int hour, int minute){
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

        public string ClockToString(){
            var clockText = _hour + ":" + _minute;
            return clockText;
        }
    }
}