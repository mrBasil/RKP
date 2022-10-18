using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RKP.Data.Indik;

namespace RKP.Measure
{
    public delegate void CreepsEvents();    

    public class MeasureCreeps
    {
        private Indikator test;
        private double mainPoint;
        Timer timer = new Timer();


        public event CreepsEvents HadNewPoint;
        public event CreepsEvents EndTest;

        private double lastPoint;

        private int minut = 0;
        private int sec = 0;

        private string timerForShow;

        List<double> points_of_discret_differnce = new List<double>();

        public MeasureCreeps(Indikator indicatorTest) 
        {
            this.test = indicatorTest;
            timer.Interval = 1000;
            timer.Tick += setNewPoint;
        }

        private void setNewPoint(object sender, EventArgs e)
        { 

            if (sec % 5 == 0)
            {
                countDiffernt(test.data);
                //countDiffernt(new Random().NextDouble()); ;
                HadNewPoint();
            }

            TimerMaker();            
            
        }

        private void TimerMaker() {
            if (sec == 60)
            {
                sec = 0;
                ++minut;
            }

            if (minut == 30)
            {
                timer.Stop();

            }

            if (sec <= 9)
            {
                timerForShow = minut + " : 0" + sec;
            }
            else {
                timerForShow = minut + " : " + sec;

            }

            ++sec;

        }

        public void start(double mainPoint)
        {
            this.mainPoint = mainPoint;
            timer.Start();
        }

        public void stop() {
            timer.Stop();
        }
        public double GetLastPoint() {
            return lastPoint;
        }

        public List<double> getListPoints() {
            return points_of_discret_differnce;
        }

        public string getTimer() {
            return timerForShow;
        }

        private void countDiffernt(double testNaw) 
        {
            var diff = Math.Round((mainPoint - testNaw)/(2d/3000d), 2);
            lastPoint = diff;
            points_of_discret_differnce.Add(diff);
            Console.WriteLine(lastPoint);
        }


        public string GetResult()
        {
            foreach (var point in points_of_discret_differnce)
            {
                if ((Math.Abs(point)) > 2d)
                {
                    return "Не уложился";
                }                
            }
            return "Уложился";
        }
    }
}
