using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKP.Measure;

namespace RKP.Model.Chart
{
    public class Point
    {
        private ChartSetModel chartSet;
        
        private double etalon;
        private double test;

        private double absError;
        
        private double reduceError;
        private float x;
        private float y;

        
        private float reduceY;

        

        public Point(ChartSetModel chartSet, double etalon, double test)
        {
            this.chartSet = chartSet;
            this.etalon = etalon;
            this.test = test;

            absError =  MeasError.GetAbsoluteError(etalon, test) ;

            setX();
            setY();

        }
        public double Etalon 
        {
            get { return etalon; }
        }

        public float ReduceCoef { get; set; } = 1;
        public float ReduceInterval { get; set; } = 75;

        public double AbsError { get { return absError; } }
        public double ReduseError { get { return reduceError; }  }
        public Color colorPoint { 
            get 
            {
                if (MeasError.GetItog(etalon, test))
                {
                    return Color.Blue;
                }
                else 
                {
                    return Color.Red;
                }
            }
        }


        public double Test
        {
            get { return test; }
        }
        
        /// <summary>
        /// Интервал точки от 0 до 3000
        /// </summary>
        public float X { get { return x; }  }

        /// <summary>
        /// Количество дискрет погрешности
        /// </summary>
        public float Y { get { return y; }  }

        public float ReduceY { get { return reduceY; } }

        private void setX() 
        {
            
            x = (float) (chartSet.OneDiscretWidth * MeasError.GetIntervalEtalon(etalon));           
        }

        private void setY()
        {
            var tempError = 1d;
            if (absError < 4d && absError > -4d)
            {

                tempError = absError *(-1) ;
            }
            else if (absError > 4d)
            {
                tempError = -4d;
               
            }
            else if (absError < -4d) {
                tempError = 4d;
                
            }

            y = chartSet.CentrHight + (float)(chartSet.OneDiscretHight * tempError);
        }



        private void setReduceY() 
        {
            var tempError = 1d ;
            if (absError < 4d && absError > -4d)
            {

                tempError = absError * (-1);
            }
            else if (absError > 4d)
            {
                tempError = -4d;

            }
            else if (absError < -4d)
            {
                tempError = 4d;

            }

            //tempError = absError - reduceError;

            if(reduceError < 0 && absError <0)
                tempError = absError + Math.Abs(reduceError);

            else  if(reduceError > 0 && absError < 0)
                tempError = absError - reduceError;

            else if (reduceError > 0 && absError > 0)
                tempError = absError - reduceError;

            else if (reduceError < 0 && absError > 0)
                tempError = absError + Math.Abs(reduceError);

            reduceY = chartSet.CentrHight - (float)(chartSet.OneDiscretHight * tempError);
            reduceError = tempError;
        }

        /// <summary>
        /// Приведение точки к точке приведения
        /// </summary>
        /// <param name="ReduceCoef">Погрешность в точке приведения </param>
        /// <param name="ReducrInterval">Интервал в точке приведения </param>
        public void Reduce(float ReduceCoef, float ReduceInterval) {

            this.ReduceCoef = ReduceCoef;
            this.ReduceInterval = ReduceInterval;

            reduceError = (ReduceCoef * MeasError.GetIntervalEtalon(etalon)) / MeasError.GetIntervalEtalon(ReduceInterval);
            setReduceY();
            
        }
    }
}
