using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus.Device;
using Modbus.Extensions;
using System.IO.Ports;

namespace RKP.Data
{
    public class ModBusShluse
    {
        public IModbusSerialMaster Master { get; set; }
        

        public ModBusShluse(SerialPort port)
        {
            if (port.IsOpen)
            {
                Master = ModbusSerialMaster.CreateRtu(port);
                Master.Transport.ReadTimeout = 300;
                Master.Transport.WriteTimeout = 50;                       
            }


        }

        

        

        

        
    }

    
}
