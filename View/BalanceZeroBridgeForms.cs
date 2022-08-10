using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RKP.Model;
using RKP.Measure;
using RKP.Data.Indik;
using RKP.Controller;

namespace RKP.View
{
    public partial class BalanceZeroBridgeForms : Form
    {
        private Indikator test;
        private LoadCell LoadCell;
        
        public BalanceZeroBridgeForms(LoadCell LoadCell)
        {
            InitializeComponent();
            
            test = Program.mc.test;
            if (test == null) {
                btn_set.Enabled = false;
                MessageBox.Show("Нет подключения к тестовому прибору \n\r Курите настройки");
            }
            this.LoadCell = LoadCell;
            
            
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            var deltaR = MeasZero.GetDeltaR(test.data, LoadCell);
            lb_itog.Text =Math.Round( deltaR, 2) + " Om";
        }
    }
}
