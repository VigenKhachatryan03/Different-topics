namespace Explisite_Implisite_05
{
    internal class Time
    {
        public int H { get; set; }
        public int M { get; set; }
        public int S { get; set; }

        public static implicit operator Time(Second second)
        {
            int h = second.Seconds / 3600;
            int m = second.Seconds / 60;
            int s = second.Seconds;
            return new Time { H = h, M = m, S = s };
        }

        public static explicit operator Second(Time time)
        {
            return new Second(){ Seconds = 2 };
        }
    }
}