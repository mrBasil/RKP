using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RKP.View
{
    public partial class CalkResistirForm : Form
    {
        public CalkResistirForm()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            lb_itog.Text =Math.Round( (num_r1.Value * num_r2.Value) / (num_r1.Value + num_r2.Value), 0) + " Om";
        }
    }
}
