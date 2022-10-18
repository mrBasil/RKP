using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using RKP.Data.Indik;
using RKP.Data.DataCreator;
using RKP.Data.Peref;
using RKP.Data;



namespace RKP.Controller
{
    public class MainClass
    {        

        private Properties.Settings prop = Properties.Settings.Default;

        public Indikator etalon;
        public Indikator test;
        public SZM peref;
        private MeakerData md;
        public Logger Logger;

        public MainClass() 
        {
            md = SetMakerData();
            Logger = new Logger();

            if (md != null) 
            { 
                etalon = md.GetIndicatorEtalon();
                test = md.GetIndicatorTest();
                peref = md.CreateSZM();            
            }
            
        }

        private MeakerData SetMakerData() {

            if (prop.etalon && prop.test && prop.peref)
            {
                if (prop.shinaRs_e && prop.shinaRs_t && prop.shinaRs_p)
                {
                    return new OneComForAll();
                }

                if (prop.shinaRs_e && prop.shinaRs_t && !prop.shinaRs_p)
                {
                    return new OneComForIndicatorOnePeref();
                }

            }


            else if (prop.etalon && prop.test && !prop.peref) {

                if (prop.device_e == "MGCPluse" && prop.device_t == "MGCPluse") {
                    return new OneMGCpluse();
                }
            }

            else if (!prop.etalon && prop.test && !prop.peref)
            {

                if ( prop.device_t == "KVP307")
                {
                    return new OneComForOnlyTest();
                }
            }



            return null;
        }
  

    }
}
