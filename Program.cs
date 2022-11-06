namespace laba3._1
{
    public class Logic
    {
        public static double IdenticalValues(double x)
        {
            return x;
        }
        public static double Meter2ToHectare(double x)
        {
            return x / 10000;
        }
        public static double Meter2ToAres(double x)
        {
            return x / 100;
        }
        public static double Meter2ToTithing(double x)
        {
            return x / 10925.4;
        }
        public static double HectareToMeter2(double x)
        {
            return x * 10000;
        }
        public static double HectareToAres(double x)
        {
            return x * 100;
        }
        public static double HectareToTithing(double x)
        {
            return x / 1.09254;
        }
        public static double AresToMeter2(double x)
        {
            return x * 100;
        }
        public static double AresToHectare(double x)
        {
            return x / 100;
        }
        public static double AresToTithing(double x)
        {
            x = AresToMeter2(x);
            x = Meter2ToTithing(x);
            return x;
        }
        public static double TithingToMeter2(double x)
        {
            x = x * 10925.4;
            return x;
        }
        public static double TithingToHectare(double x)
        {
            return x * 1.092;
        }
        public static double TithingToAres(double x)
        {
            return x * 109.254;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}