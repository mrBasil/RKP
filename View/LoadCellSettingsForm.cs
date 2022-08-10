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

namespace RKP.View
{
    public partial class LoadCellSettingsForm : Form
    {
        LoadCell sensor = new LoadCell()
        {
            NPI = Properties.Settings.Default.NPI,
            RKP = Properties.Settings.Default.RKP,
            R_in = Properties.Settings.Default.R

        };


        public LoadCellSettingsForm()
        {
            InitializeComponent();

            
            if (sensor != null) {

                num_NPI.Value = sensor.NPI;
                num_RKP.Value = (decimal)sensor.RKP;
                num_Bridge.Value = sensor.R_in;
            }
            
            
        }
        /// <summary>
        /// Получает настройки с формы
        /// </summary>
        /// <returns></returns>
        private LoadCell settModel() {

            return  new LoadCell()
            {
                NPI = (int)num_NPI.Value,
                RKP = (double)num_RKP.Value,
                R_in = (int)num_Bridge.Value

            };
            
        }

        private void SaveSettings(LoadCell loadCell) {

            Properties.Settings.Default.NPI = loadCell.NPI;
            Properties.Settings.Default.RKP = loadCell.RKP;
            Properties.Settings.Default.R = loadCell.R_in;

            Properties.Settings.Default.Save();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SaveSettings(settModel());
                Close();
            }
            catch {
                MessageBox.Show("Что-то пошло не так");
            }                
              
            
        }
    }
}
