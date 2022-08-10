using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace RKP.View
{
    public partial class Settings : Form
    {
        Properties.Settings prop = Properties.Settings.Default;
        public Settings()
        {
            InitializeComponent();

            cb_have_etalon.CheckedChanged += Enabel_tp_etalon;
            cb_have_peref.CheckedChanged += Enable_tp_peref;
            cb_have_test.CheckedChanged += Enable_tp_test;

            setConfigPage();
            setEtalonPage();
            setTestPage();
            setPerefPage();
            setDBPage();


        }

        private void Enable_tp_test(object sender, EventArgs e)
        {
            if (cb_have_test.Checked)
                tp_test.Enabled = true;
            else
                tp_test.Enabled = false;
            prop.test = cb_have_test.Checked;
            prop.Save();
        }

        private void Enable_tp_peref(object sender, EventArgs e)
        {
            if (cb_have_peref.Checked)
                tp_peref.Enabled = true;
            else
                tp_peref.Enabled = false;
            prop.peref = cb_have_peref.Checked;
            prop.Save();
        }

        private void Enabel_tp_etalon(object sender, EventArgs e)
        {
            if (cb_have_etalon.Checked)
                tp_etalon.Enabled = true;
            else
                tp_etalon.Enabled = false;
            prop.etalon = cb_have_etalon.Checked;
            prop.Save();
        }


        private void setConfigPage() 
        {
            cb_have_etalon.Checked = prop.etalon;
            cb_have_test.Checked = prop.test;
            cb_have_peref.Checked = prop.peref;

            if (cb_have_test.Checked)
                tp_test.Enabled = true;
            else
                tp_test.Enabled = false;

            if (cb_have_peref.Checked)
                tp_peref.Enabled = true;
            else
                tp_peref.Enabled = false;

            if (cb_have_etalon.Checked)
                tp_etalon.Enabled = true;
            else
                tp_etalon.Enabled = false;

        }
        private void setEtalonPage() 
        {
            comboBox_com_e.Items.AddRange(SerialPort.GetPortNames());
            comboBox_com_e.SelectedItem = prop.com_e;

            comBox_baudRete_e.Items.AddRange(new string[] { "19200", "9600", "4800", "38400", "57600", "115200" });
            comBox_baudRete_e.SelectedItem = prop.baudeRate_e.ToString();

            comboBox_stopBits_e.Items.AddRange(new string[] { "2", "1" });
            comboBox_stopBits_e.SelectedItem = prop.stop_byts_e.ToString();

            comboBox_BitSize_e.Items.AddRange(new string[] { "8", "7" });
            comboBox_BitSize_e.SelectedItem = prop.bytSize_e.ToString();

            comboBox_parity_e.Items.AddRange(new string[] { "none", "odd", "even",  "mark", "space" });
            switch (prop.paryty_e)
            {
                case 0:
                    comboBox_parity_e.SelectedItem = "none";
                    break;
                case 1:
                    comboBox_parity_e.SelectedItem = "even";
                    break;
                case 2:
                    comboBox_parity_e.SelectedItem = "odd";
                    break;
                case 3:
                    comboBox_parity_e.SelectedItem = "mark";
                    break;
                case 4:
                    comboBox_parity_e.SelectedItem = "space";
                    break;
            }

            comboBox_device_e.Items.AddRange(new string[] { "MGCPluse", "KVP307" });
            comboBox_device_e.SelectedItem = prop.device_e;
            cb_shinaRS_e.Checked = prop.shinaRs_e;
            num_adres_e.Value = prop.adres_e;

        }
        private void setTestPage()
        {
            comboBox_com_t.Items.AddRange(SerialPort.GetPortNames());
            comboBox_com_t.SelectedItem = prop.com_t;            

            comBox_baudRete_t.Items.AddRange(new string[] { "19200", "9600", "4800", "38400", "57600", "115200" });
            comBox_baudRete_t.SelectedItem = prop.baydeRate_t.ToString();

            comboBox_stopBits_t.Items.AddRange(new string[] { "2", "1", "1.5" });
            comboBox_stopBits_t.SelectedItem = prop.stop_byts_t.ToString();

            comboBox_BitSize_t.Items.AddRange(new string[] { "8", "7" });
            comboBox_BitSize_t.SelectedItem = prop.bytSize_t.ToString();

            comboBox_parity_t.Items.AddRange(new string[] { "none", "odd", "even", "mark", "space" });
            switch (prop.paryty_t)
            {
                case 0:
                    comboBox_parity_t.SelectedItem = "none";
                    break;
                case 1:
                    comboBox_parity_t.SelectedItem = "even";
                    break;
                case 2:
                    comboBox_parity_t.SelectedItem = "odd";
                    break;
                case 3:
                    comboBox_parity_t.SelectedItem = "mark";
                    break;
                case 4:
                    comboBox_parity_t.SelectedItem = "space";
                    break;
            }

            comboBox_device_t.Items.AddRange(new string[] { "MGCPluse", "KVP307" });
            comboBox_device_t.SelectedItem = prop.device_t;

            num_adres_t.Value = prop.adres_t;
            cb_shinaRS_t.Checked = prop.shinaRs_t;
        }
        private void setPerefPage()
        {           

            comboBox_com_p.Items.AddRange(SerialPort.GetPortNames());
            comboBox_com_p.SelectedItem = prop.com_p;

            comBox_baudRete_p.Items.AddRange(new string[] { "19200", "9600", "4800", "38400", "57600", "115200" });
            comBox_baudRete_p.SelectedItem = prop.baudeRate_p.ToString();

            comboBox_stopBits_p.Items.AddRange(new string[] { "2", "1" });
            comboBox_stopBits_p.SelectedItem = prop.stop_byts_p.ToString();

            comboBox_BitSize_p.Items.AddRange(new string[] { "8", "7" });
            comboBox_BitSize_p.SelectedItem = prop.bytSize_p.ToString();

            comboBox_parity_p.Items.AddRange(new string[] { "none", "odd", "even", "mark", "space" });
            switch (prop.paryty_p)
            {
                case 0:
                    comboBox_parity_p.SelectedItem = "none";
                    break;
                case 1:
                    comboBox_parity_p.SelectedItem = "even";
                    break;
                case 2:
                    comboBox_parity_p.SelectedItem = "odd";
                    break;
                case 3:
                    comboBox_parity_p.SelectedItem = "mark";
                    break;
                case 4:
                    comboBox_parity_p.SelectedItem = "space";
                    break;
            }

            comboBox_device_p.Items.AddRange(new string[] { "ESQ760", "SZM500" });
            comboBox_device_p.SelectedItem = prop.device_p;
            cb_shinaRS_p.Checked = prop.shinaRs_p;
            num_adres_p.Value = prop.adres_p;
        }
        private void setDBPage() 
        {
            textBox_IP.Text = prop.IP;
            textBox_port.Text = prop.port.ToString();
            textBox_path.Text = prop.path;
        }

        private void btn_save_etalon_Click(object sender, EventArgs e)
        {           

            try
            {
                prop.com_e = comboBox_com_e.SelectedItem.ToString();

                prop.baudeRate_e = int.Parse(comBox_baudRete_e.SelectedItem.ToString());
                prop.bytSize_e = int.Parse(comboBox_BitSize_e.SelectedItem.ToString());
                prop.stop_byts_e = int.Parse(comboBox_stopBits_e.SelectedItem.ToString());
                prop.paryty_e = comboBox_parity_e.SelectedIndex;
                prop.device_e = comboBox_device_e.SelectedItem.ToString();
                prop.adres_e = (int)num_adres_e.Value;
                prop.shinaRs_e = cb_shinaRS_e.Checked;
                prop.Save();
            }
            catch {
                MessageBox.Show("Проверьте настройки");
            
            }
            
        }
        private void btn_save_test_Click(object sender, EventArgs e)
        {
            
            try { 

            prop.com_t = comboBox_com_t.SelectedItem.ToString();
            prop.baydeRate_t = int.Parse(comBox_baudRete_t.SelectedItem.ToString());
            prop.bytSize_t = int.Parse(comboBox_BitSize_t.SelectedItem.ToString());
            prop.stop_byts_t = int.Parse(comboBox_stopBits_t.SelectedItem.ToString());
            prop.paryty_t = comboBox_parity_t.SelectedIndex;
            prop.device_t = comboBox_device_t.SelectedItem.ToString();
            prop.adres_t = (int)num_adres_t.Value;
            prop.shinaRs_t = cb_shinaRS_t.Checked;
            prop.Save();
            }
            catch {
                MessageBox.Show("Проверьте что все настройки указаны верно");
            }
        }
        private void btn_save_p_Click(object sender, EventArgs e)
        {

            try
            {
                prop.com_p = comboBox_com_p.SelectedItem.ToString();
                prop.baudeRate_p = int.Parse(comBox_baudRete_p.SelectedItem.ToString());
                prop.bytSize_p = int.Parse(comboBox_BitSize_p.SelectedItem.ToString());
                prop.stop_byts_p = int.Parse(comboBox_stopBits_p.SelectedItem.ToString());
                prop.paryty_p = comboBox_parity_p.SelectedIndex;
                prop.device_p = comboBox_device_p.SelectedItem.ToString();
                prop.adres_p = (int)num_adres_p.Value;
                prop.shinaRs_p = cb_shinaRS_p.Checked;
                prop.Save();
            }
            catch
            {
                MessageBox.Show("Проверьте что все настройки указаны верно");
            }


        }

        private bool checkSimbolIP() {

            var tempIP = textBox_IP.Text;
            foreach (var c in tempIP) {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '.')
                {

                    continue;
                }
                else {
                    MessageBox.Show("Не допустимый символ в IP: " + c);
                    return false;
                }
            }

            return true;
        
        }

        private bool checkSimbolPort()
        {

            var tempPort = textBox_port.Text;
            foreach (var c in tempPort)
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {

                    continue;
                }
                else
                {
                    MessageBox.Show("Не допустимый символ в Port: " + c);
                    return false;

                }
            }

            return true;

        }

        private void btn_save_db_Click(object sender, EventArgs e)
        {
            
            if (checkSimbolIP() && checkSimbolPort() ) {
                prop.IP = textBox_IP.Text;
                prop.port = int.Parse( textBox_port.Text);
                prop.path = textBox_path.Text;
                prop.Save();
            }
        }

        
    }
}
