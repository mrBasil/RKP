using RKP.Data.Indik;
using RKP.Data.Peref;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RKP.Data.DataCreator
{
    public class OneMGCpluse : MeakerData
    {
        MGCPluse mGC;
        public OneMGCpluse() 
        {
            mGC = new MGCPluse("192.168.0.183", 7);
            
        }
        public override SZM CreateSZM()
        {
            return null;
        }

        public override Indikator GetIndicatorEtalon()
        {
            return new MGCPluseData(mGC, MGCPluseData.Target.etalon);
        }

        public override Indikator GetIndicatorTest()
        {
            return new MGCPluseData(mGC, MGCPluseData.Target.test);
        }


    }
}
