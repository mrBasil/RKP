using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus.Device;

namespace RKP.Data.Indik
{
    public class KV307:Indikator
    {
        private IModbusSerialMaster Master;
        private ModBusShluse Shluse;

        private double data_weight = 0;
        private double coef = 1;
        private int colZnak = 0;
        public KV307(ModBusShluse shluse, int ID) 
        {
           
            //Console.WriteLine("KVP307 #" + ID);
            try {
                this.Master = shluse.Master;
                Shluse = shluse;
                this.ID = ID;
                SetCoef();
                SetWeightData();
            }catch { }
            
        }

        public override double data {
                    
            get
            {
                return data_weight;

            }
        }

        public override double zero_data { get; set; } = 0;

        public async Task SetWeightData() {
          await Task.Run(() =>
             {
                 while (true)
                 {
                    // Console.WriteLine("Work KVP307 39str");
                     
                     var temp = Master.ReadInputRegistersAsync((byte)ID, 143, 2);
                     try
                     {
                         var temp1 = temp.Result;
                         data_weight =Math.Round(((temp1[0] << 16 | temp1[1]) ) * coef - zero_data, colZnak); 
                     }
                     catch
                     {
                         Console.WriteLine("Не получил данные от платы #" + ID);
                     }            

                 }                
                 
             });

            
        
        }
        private void SetCoef()
        {
            var temp = Master.ReadHoldingRegistersAsync((byte)ID, 2, 1).Result;
            colZnak = temp[0] & 255;
            switch (colZnak) {
                case 1:
                    coef = 0.1;
                    break;
                case 2:
                    coef = 0.01;
                    break;
                case 3:
                    coef = 0.001;
                    break;
                case 4:
                    coef =0.0001;
                    break;
                default:
                    coef = 1;
                    break;
            }
                
        }
    }
}
