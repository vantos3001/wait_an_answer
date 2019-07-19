namespace Game
{
    public class CharacteristicConstants
    {
        //When Eating
        public static int EATING_DELTA_EAT = 40;
        public static int EATING_DELTA_SLEEP = -20;
        public static int EATING_DELTA_WORK = -10;
        public static int EATING_DELTA_MOOD = 0;
        public static int EATING_TIME_IN_HOURS = 1;
        
        //When Sleeping
        public static int SLEEPING_DELTA_EAT = -40;
        public static int SLEEPING_DELTA_SLEEP = 60;
        public static int SLEEPING_DELTA_WORK = -30;
        public static int SLEEPING_DELTA_MOOD = 0;
        public static int SLEEPING_TIME_IN_HOURS = 8;
        
        //When Working
        public static int WORKING_DELTA_EAT = -30;
        public static int WORKING_DELTA_SLEEP = -30;
        public static int WORKING_DELTA_WORK = 50;
        public static int WORKING_DELTA_MOOD = 0;
        public static int WORKING_TIME_IN_HOURS = 8;
        
        //When Relaxing
        public static int RELAXING_DELTA_EAT = -20;
        public static int RELAXING_DELTA_SLEEP = -25;
        public static int RELAXING_DELTA_WORK = -20;
        public static int RELAXING_DELTA_MOOD = 20;
        public static int RELAXING_TIME_IN_HOURS = 5;
    }
}