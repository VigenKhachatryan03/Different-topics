namespace Explisite_Implisite_05
{
    internal class Second
    {
        public int Seconds { get; set; }

        //public Second(int second)
        //{
        //    Seconds = second;
        //}

        public static explicit operator int(Second second) { return second.Seconds; }
        public static implicit operator Second(int a) { return new Second { Seconds = a }; }
    }
}