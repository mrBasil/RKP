using RKP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKP.Measure
{
    /// <summary>
    /// Баланс ноля будет считаться здесь
    /// </summary>
    public static class MeasZero
    {

        public static double GetDeltaR(double test, LoadCell loadCell) 
        {
            
            var pitanie = 5d;
            var testToV = (test * pitanie / 1000);

            var deltaBridge = ((4 * testToV * loadCell.R_in) / (pitanie - (2d * testToV)));
            var deltaR = ((loadCell.R_in - deltaBridge) * loadCell.R_in ) / (loadCell.R_in - (loadCell.R_in - deltaBridge));
            return deltaR;


        }
    }
}
