using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKP.Data.Indik;
using RKP.Data.Peref;
using System.IO.Ports;

namespace RKP.Data
{
    /// <summary>
    /// Описывает схему подключения устройств к ПК в зависимости от 
    /// </summary>
    public abstract class MeakerData
    {
        
        protected SerialPort portEtalon;
        protected SerialPort portTest;
        protected SerialPort portPeref;

        protected ModBusShluse shluseEtalon;
        protected ModBusShluse shluseTest;
        protected ModBusShluse shlusePeref;

        protected MGCPluse mgc;

        public enum DeviceData 
        { 
            KVP307,
            MGCPluse                    
        }

        public enum DevicePeref 
        { 
            esq760    
        }

        protected DeviceData etalon;
        protected DeviceData test;
        protected DevicePeref peref;

        public MeakerData() {
            ChouseIndikEtalon();
            ChouseIndikTest();
            ChouseIndikPeref();
        
        }

        private void ChouseIndikEtalon()
        {
            var prop = Properties.Settings.Default;
            switch (prop.device_e)
            {

                case "MGCPluse":
                    etalon = DeviceData.MGCPluse;
                    break;

                case "KVP307":
                    etalon = DeviceData.KVP307;
                    break;
            }
        }

        private void ChouseIndikTest()
        {
            var prop = Properties.Settings.Default;
            switch (prop.device_t)
            {

                case "MGCPluse":
                    test = DeviceData.MGCPluse;
                    break;

                case "KVP307":
                    test = DeviceData.KVP307;
                    break;
                default:
                    break;
            }
        }

        private void ChouseIndikPeref()
        {
            var prop = Properties.Settings.Default;
            switch (prop.device_p)
            {

                case "ESQ760":
                    peref = DevicePeref.esq760;
                    break;
                default:
                    break;

            };
        }
        public abstract Indikator GetIndicatorEtalon();
        public abstract Indikator GetIndicatorTest();
        public abstract SZM CreateSZM();
    }
}
