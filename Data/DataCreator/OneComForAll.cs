using RKP.Data.Indik;
using RKP.Data.Peref;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;


namespace RKP.Data.DataCreator
{
    public class OneComForAll : MeakerData
    {
        

        private Properties.Settings prop = Properties.Settings.Default;

        public OneComForAll() 
        {         

            GetPort();

            if (portEtalon != null && (peref == DevicePeref.esq760 || etalon == DeviceData.KVP307 || test == DeviceData.KVP307)) {
                Console.WriteLine(portEtalon.PortName +  " OneComForAll 32 string");
                shluseEtalon = new ModBusShluse(portEtalon);
                
            }

        }

        private void GetPort()
        {
            ComPort comPort = new ComPort(prop.com_e, prop.baudeRate_e, prop.paryty_e, prop.stop_byts_e, prop.bytSize_e);

            try
            {

                portEtalon = comPort.GetPort();
            }
            catch {
                MessageBox.Show("Не могу открыть порт, курите настройки");
            }
            
            

        }

        public override SZM CreateSZM()
        {
            if (peref == DevicePeref.esq760 && shluseEtalon!= null) {
                return new ESQ760(shluseEtalon, prop.adres_p);
            }

            return null;
        }

        public override Indikator GetIndicatorEtalon()
        {
            if (etalon == DeviceData.KVP307 && shluseEtalon != null ) {
                return new KV307(shluseEtalon, prop.adres_e);
            }
            return null;
        }

        public override Indikator GetIndicatorTest()
        {
            if (test == DeviceData.KVP307 && shluseEtalon != null)
            {
                return new KV307(shluseEtalon, prop.adres_t);
            }
            return null;
        }


    }
}
