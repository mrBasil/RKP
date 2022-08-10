using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKP.Data.Indik
{
    public class MGCPluseData:Indikator
    {
        MGCPluse mGCPluse;
        /// <summary>
        /// Под какое значение создавать экземпляр класса
        /// Под эталон или под испытуемый
        /// </summary>
        public enum Target { 
            etalon,
            test
        };

        private Target mTarget;
        public MGCPluseData(MGCPluse mGCPluse, Target target ) {
            this.mGCPluse = mGCPluse;
            mTarget = target;
        }
        public override double data 
        { 
            get 
            {
                if (mTarget == Target.etalon)
                {
                    return mGCPluse.etalon - zero_data;
                }
                else
                {
                    return mGCPluse.test - zero_data;
                }
            }
        }

        public override double zero_data { get; set; } = 0;
    }
}
