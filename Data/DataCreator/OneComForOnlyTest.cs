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
    public class OneComForOnlyTest : MeakerData
    {

        private Properties.Settings prop = Properties.Settings.Default;

        public OneComForOnlyTest() {

            SetPoertTest();
            if (portEtalon == null && portTest != null && test == DeviceData.KVP307)
            {
                Console.WriteLine(portTest.PortName + " OneComForOnlyTest  22 string");
                shluseTest = new ModBusShluse(portTest);

            }

        }

        public override SZM CreateSZM()
        {
            return null;
        }

        public override Indikator GetIndicatorEtalon()
        {
            return null;
        }

        public override Indikator GetIndicatorTest()
        {
            if (test == DeviceData.KVP307)
            {
                return new KV307(shluseTest, prop.adres_t);
            }
            return null;
        }

        private void SetPoertTest()
        {
            ComPort comPort = new ComPort(prop.com_t, prop.baydeRate_t, prop.paryty_t, prop.stop_byts_t, prop.bytSize_t);

            try
            {

                portTest = comPort.GetPort();
            }
            catch
            {
                MessageBox.Show("Не могу открыть порт, Тест, курите настройки");
            }

        }
    }
}
