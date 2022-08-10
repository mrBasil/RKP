using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKP.Measure
{
    public static class MeasError
    {
        /// <summary>
        /// Возвращает количество дискрет что является абсолютной погрешностью тестового датчика
        /// </summary>
        /// <param name="etalon">Нагрузка на эталон номинальная</param>
        /// <param name="test">Показания тестового датчика в mV/V</param>
        /// <returns>Количесвто дискрет, если отрицательное то датчик не дотягивает, если положительное то датчик выдает больше чем надо</returns>
        public static double GetAbsoluteError(double etalon, double test)
        {
            var interval_etalon = GetIntervalEtalon(etalon);
            var interval_test = GetIntervalTest(test);
            return (interval_test - interval_etalon);

        }
        /// <summary>
        /// Возвращает количество дискрет на даненой нагрузке
        /// </summary>
        /// <param name="etalon">Показания эталона в наминальных единицах</param>
        /// <returns>количество дискрет на данной нагрузке</returns>
        public static double GetIntervalEtalon(double etalon) 
        {
            var prop = Properties.Settings.Default;
            return etalon / (prop.NPI / 3000d);

        }
        /// <summary>
        /// Возвращает количество дискрет на даненой нагрузке испытуемого датчика
        /// </summary>
        /// <param name="test">Показания тестового датчика в mV/V </param>
        /// <returns> Количество дискрет на данной нагрузке </returns>
        public static double GetIntervalTest(double test) 
        {
            var prop = Properties.Settings.Default;
            return test / (prop.RKP / 3000d);
        }

        public static bool GetItog(double etalon, double test) 
        {
            var interval = MeasError.GetIntervalEtalon(etalon);

            var abs_e = Math.Round(MeasError.GetAbsoluteError(etalon, test), 2);
            

            if (interval <= 500 && Math.Abs(abs_e) < 0.5)
            {
                return true;
            }

            if (interval <= 500 && Math.Abs(abs_e) > 0.5)
            {
                return false;
            }


            if (interval > 500 && interval <= 2000 && Math.Abs(abs_e) < 1)
            {
                return true;
            }

            if (interval > 500 && interval <= 2000 && Math.Abs(abs_e) > 1)
            {
                return false;
            }


            if (interval > 2000 && interval <= 3000 && Math.Abs(abs_e) < 1.5)
            {
                return true;
            }

            if (interval > 2000 && interval <= 3000 && Math.Abs(abs_e) > 1.5)
            {
                return false;
            }

            return false;
        }

    }
}
