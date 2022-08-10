using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKP.Controller
{
    public class Logger
    {
        private StringBuilder log = new StringBuilder();

        public string Log { 
            get 
            {
                return log.ToString();
            }
            set 
            {
                log.AppendLine(value);
            }
        }
    }
}
