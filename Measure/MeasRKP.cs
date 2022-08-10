using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKP.Model;

namespace RKP.Measure
{
    public class MeasRKP
    {
        private readonly LoadCell sensor;
        private double dis_etal;
        private double dis_test;

        public MeasRKP(LoadCell sensor)
        {
            this.sensor = sensor;
            if (sensor != null)
            {
                dis_etal = (sensor.NPI / 3000d);
                dis_test = (sensor.RKP / 3000d);
            }

        }

        /// <summary>
        ///Возвращает расчетную наминальную величину 
        ///которую должен выдать тестовый датчик
        /// </summary>
        /// <param name="etalon">Показания эталона</param>
        /// <returns>расчитанный выход в вольтах </returns>
        public double GetOutCounted(double etalon)
        {
            return (10d / sensor.NPI * etalon) / 1000d;
        }

        /// <summary>
        /// Расчет сопротивление 
        /// </summary>
        /// <param name="etalon">Вес эталон kg</param>
        /// <param name="test">Выход с тестового датчика mV/V </param>
        /// <returns> Сопротивление в Ом </returns>
        private double GetDeltaR(double etalon, double test)
        {
            double delta;
            if (test == 0)
            {
                return 0;
            }
            else
            {
                var deltaVin = ((5d * GetOutCounted(etalon)) / ((test * 5d) / 1000d));
                delta = ((5d * sensor.R_in) - (sensor.R_in * deltaVin)) / deltaVin;
            }
            return Math.Round( delta, 1);
        }

        private double GetError(double etalon, double test)
        {
            var d_etalon = sensor.NPI / 3000d;
            var d_test = sensor.RKP / 3000d;
            return (etalon / d_etalon) - (test / d_test);
        }

        public string GetItog(double etalon, double test) 
        {

            var interval = MeasError.GetIntervalEtalon(etalon);

            var abs_e = Math.Round( MeasError.GetAbsoluteError(etalon, test), 2);

            if (etalon > sensor.NPI) {
                return "Перегруз";
            }

            if (MeasError.GetItog(etalon, test))
            {
                return " Уложился,\n\r еrror =  " + abs_e;
            }
            else {
                return " Не уложился,\n\r еrror =  " + abs_e + "\n\r" + GetDeltaR(etalon, test) + " Om";
            }      
            
        }
    }
}
