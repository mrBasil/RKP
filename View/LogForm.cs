using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RKP.Controller;

namespace RKP.View
{
    public partial class LogForm : Form
    {
        private MainClass mc = Program.mc;
        public LogForm()
        {
            InitializeComponent();
            textBox_log.Text = mc.Logger.Log;
        }
    }
}
