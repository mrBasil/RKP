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
    public class OneComForIndicatorOnePeref : MeakerData
    {
        private Properties.Settings prop = Properties.Settings.Default;

        public OneComForIndicatorOnePeref() 
        {
            this.etalon = etalon;
            this.test = test;
            this.peref = peref;

            SetPoertEtalon();
            if (portEtalon != null && ( etalon == DeviceData.KVP307 || test == DeviceData.KVP307))
            {
                Console.WriteLine(portEtalon.PortName + " OneComForAll 32 string");
                shluseEtalon = new ModBusShluse(portEtalon);

            }



            SetPortPeref();

            

        
        }

        private void SetPoertEtalon() 
        {
            ComPort comPort = new ComPort(prop.com_e, prop.baudeRate_e, prop.paryty_e, prop.stop_byts_e, prop.bytSize_e);

            try
            {

                portEtalon = comPort.GetPort();
            }
            catch
            {
                MessageBox.Show("Не могу открыть порт, ЭТАЛОН, курите настройки");
            }

        }

        private void SetPortPeref() 
        {
            ComPort comPort = new ComPort(prop.com_p, prop.baudeRate_p, prop.paryty_p, prop.stop_byts_p, prop.bytSize_p);

            try
            {

                portPeref = comPort.GetPort();
            }
            catch
            {
                MessageBox.Show("Не могу открыть порт, ПЕРЕФЕРИЯ, курите настройки");
            }

        }

        public override SZM CreateSZM()
        {
            if (portPeref != null && peref == DevicePeref.esq760)
            {
                shlusePeref = new ModBusShluse(portPeref);
                return new ESQ760(shlusePeref, prop.adres_p);
            }

            return null;
        }

        public override Indikator GetIndicatorEtalon()
        {
            if (etalon == DeviceData.KVP307) {
                return new KV307(shluseEtalon, prop.adres_e);
            }
            return null;
        }

        public override Indikator GetIndicatorTest()
        {
            if (test == DeviceData.KVP307)
            {
                return new KV307(shluseEtalon, prop.adres_t);
            }
            return null;
        }
    }
}
