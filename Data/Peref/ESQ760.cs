using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus.Device;
using RKP.Controller;

namespace RKP.Data.Peref
{
    public class ESQ760:SZM
    {
        private  IModbusSerialMaster Master;
        private ModBusShluse Shluse;
        private int HZ = 1000;
        


        public ESQ760(ModBusShluse shluse, int ID) 
        {
            
            Shluse = shluse;
            this.Master = shluse.Master;
            this.ID = ID;
            Write(0x3000,1000);
            ReadHZ();
            
        }

        public override void Stop() 
        {           
            Write( 0x2000, 5);
            // Console.WriteLine("Stop");
            Program.mc.Logger.Log = "Команда Стоп отправлена";                        
        }

        public override void Load()
        {            
                Write(0x2000, 1);
            // Console.WriteLine("Load ");
            Program.mc.Logger.Log = "Команда Нагрузка отправлена";
        }

        public override void UnLoad()
        {         
                Write(0x2000, 2);
            // Console.WriteLine("unLoad ");
            Program.mc.Logger.Log = "Команда Разгрузка отправлена";



        }

        public override int Speed {
            get
            {                
                return HZ/100;                
            }
            set 
            {        
                
                Write(0x3000,(ushort)value);
                Program.mc.Logger.Log = "Команда Смены частоты отправлена";
                ReadHZ();              

            }
        }

        private async void ReadHZ(){

           await Task.Run(() =>
            {              

                    try
                    {
                        HZ = Master.ReadHoldingRegistersAsync((byte)ID, 0x3000, 1).Result[0];
                    Program.mc.Logger.Log = "Чтение частоты произведено";
                }
                    catch(Exception e)
                    {
                        // Console.WriteLine("Не верный адрес ESQ 54str;  ID = " + ID);
                        //mc.Logger.Log = "Исключение при чтениии частоты";
                        //mc.Logger.Log = e.Message;
                }
                    Task.Delay(500);
                
                
            });
                
        }

        private async Task Write(ushort reg, ushort val) 
        {
            try
            {
                await Master.WriteSingleRegisterAsync((byte)ID, reg, (ushort)val);
                Program.mc.Logger.Log = "Команда на запись в частотник отправлена reg = " + reg + "/ val = " + val;
            }
            catch(Exception e) {
                //await Write(reg, val);
                //Console.WriteLine("Не сработало " + reg);
                Program.mc.Logger.Log = e.Message;
                Program.mc.Logger.Log = ("Не сработала команда на запись в reg =  " + reg + "/ value = " + val);
            }
        }
    }
}
