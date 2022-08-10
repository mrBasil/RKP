using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace RKP.Data
{

    public class ComPort 
    {
        
        public string Name { get; set; }
        public int BaudRate { get; set; }
        public int Parity { get; set; }
        public int StopByts { get; set; }
        public int BytSize { get; set; }


        public ComPort(string Name, int br, int pariyt, int sb, int bs) {

           this.Name = Name;
            BaudRate = br;
            Parity = pariyt;
            StopByts = sb;
            BytSize = bs;
        }

        public SerialPort GetPort() 
        { 
            SerialPort port = new SerialPort(Name);
            port.BaudRate = BaudRate;
            port.Parity =(Parity)Parity;
            port.DataBits = BytSize;
            port.StopBits = (StopBits)StopByts;
            port.Open();
            return port;           

        }

        

        

    }
}
