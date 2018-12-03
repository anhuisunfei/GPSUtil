using System;

namespace GCJ02Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            double dis = GetDistance(121.400311, 31.194358, 121.40966, 31.18885);

            Console.WriteLine(dis);

            dis = LocationUtils.getDistance(121.400311, 31.194358, 121.39191, 31.18834);
            Console.WriteLine(dis);


            Console.ReadKey();
        }

        private static double EARTH_RADIUS = 6378.137;//地球半径
        private static double rad(double d)
        {
            return d * Math.PI / 180.0;
        }
        /**
         * 计算两点间距离
         * @return double 距离 单位公里,精确到米
         */
        public static double GetDistance(double lat1, double lng1, double lat2, double lng2)
        {
            double radLat1 = rad(lat1);
            double radLat2 = rad(lat2);
            double a = radLat1 - radLat2;
            double b = rad(lng1) - rad(lng2);
            double s = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(a / 2), 2) +
                    Math.Cos(radLat1) * Math.Cos(radLat2) * Math.Pow(Math.Sin(b / 2), 2)));
            s = s * EARTH_RADIUS;


            s = Math.Round(s, 5, MidpointRounding.AwayFromZero);
            return s;
        }
    }
}
