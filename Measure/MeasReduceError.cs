using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKP.Model.Chart;


namespace RKP.Measure
{
    public static class MeasReduceError
    {
        public static Point GetPointForReduce(List<Point> points) 
        {
            var interval75point = Properties.Settings.Default.NPI * 0.75;
            //var interval75point = 15000 * 0.75;

            var difInPoint = 100000d;
            Point point75 = null;            

            for (int i = 1; i < points.Count; i++) 
            {                
                if (difInPoint > Math.Abs(interval75point - points[i].Etalon) && points[i-1].Etalon <  points[i].Etalon)
                {
                    point75 = points[i];
                    difInPoint = Math.Abs(interval75point - points[i].Etalon);
                }
            }

            return point75;
        }

    }
}
