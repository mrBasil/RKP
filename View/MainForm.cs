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
using RKP.Model;
using RKP.Data.Indik;
using RKP.Data.Peref;
using RKP.Measure;

namespace RKP.View
{
    public partial class MainForm : Form
    {
        LoadCell sensor;

        private MainClass mc;
        private Indikator etalon;
        private Indikator test;
        private SZM szm;
        
        Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();

            sensor = setLoadCell();
            mc = Program.mc;
            this.FormClosed += stopWork;
            
            etalon = mc.etalon;
            test = mc.test;
            szm = mc.peref;
            
            timer.Interval = 50;

            timer.Tick += UpdateLB;
            timer.Tick += SetEnable;

            timer.Start();

            rBtn_1.Checked = true;

            rBtn_1.CheckedChanged += UpdateHz;
            rbtn_2.CheckedChanged += UpdateHz;
            rbtn_3.CheckedChanged += UpdateHz;
            rbtn_4.CheckedChanged += UpdateHz;
            rbtn_5.CheckedChanged += UpdateHz;

            

            if (sensor != null) {
                UpdeteLabelInfo();
                // и дальше запускать всю программу
            }
            
        }

        private void stopWork(object sender, FormClosedEventArgs e)
        {
            Program.work = false;
        }

        private void SetEnable(object sender, EventArgs e)
        {
            if (etalon != null)
            {
                lb_main.Enabled = true;
                
            }
            else
            {
                lb_main.Enabled = false;
            }

            if (test != null)
            {
                lb_test.Enabled = true;
                
            }
            else
            {
                lb_test.Enabled = false;
            }

            if (etalon != null && test != null)
            {
                btn_set.Enabled = true;
            }
            else
            {
                btn_set.Enabled = false;
            }

            if (szm != null)
            {
                SetRBTN(true);
                btn_load.Enabled = true;
                btn_unLoad.Enabled = true;
                btn_stop.Enabled = true;                
            }
            else
            {
                SetRBTN(false);
                btn_load.Enabled = false;
                btn_unLoad.Enabled = false;
                btn_stop.Enabled = false;
            }
        }

        private  void  UpdateHz(object sender, EventArgs e)
        {

            RadioButton rbtn = (RadioButton)sender;
            
            switch (rbtn.Text) {
                case "1":
                    if (rBtn_1.Checked)
                    {
                        szm.Speed = 1000;
                        Console.WriteLine(rbtn.Text);
                    }
                    break;
                case "2":
                    if (rbtn_2.Checked)
                    {
                        szm.Speed = 2000;
                        Console.WriteLine(rbtn.Text);
                    }

                    break;
                case "3":
                    if (rbtn_3.Checked)
                    {
                        szm.Speed = 3000;
                        Console.WriteLine(rbtn.Text);
                    }
                    break;
                case "4":
                    if (rbtn_4.Checked)
                    {
                        szm.Speed = 4000;
                        Console.WriteLine(rbtn.Text);
                    }
                    break;
                case "5":
                    if (rbtn_5.Checked)
                    {
                        szm.Speed = 5000;
                        Console.WriteLine(rbtn.Text);
                    }
                    break;
            }

            

        }

        private void SetRBTN(bool vkl) {

            if (vkl)
            {

                rBtn_1.Enabled = vkl;
                rbtn_2.Enabled = vkl;
                rbtn_3.Enabled = vkl;
                rbtn_4.Enabled = vkl;
                rbtn_5.Enabled = vkl;

            }
            else {
                rBtn_1.Enabled = vkl;
                rbtn_2.Enabled = vkl;
                rbtn_3.Enabled = vkl;
                rbtn_4.Enabled = vkl;
                rbtn_5.Enabled = vkl;
            }
        }

        private void UpdateLB(object sender, EventArgs e)
        {
            if (etalon != null)
            {                
                lb_main.Text = etalon.data + "kg";
                if (etalon.data < 0)
                {
                    pb_load.Value = 0;
                }
                else {
                    try
                    {
                        pb_load.Value = (int)etalon.data;
                    }
                    catch {

                        lb_main.Text = "Перегруз или неверные настройки";
                        
                    }
                    
                }


            }
            

            if (test != null)
            {               
                lb_test.Text = test.data + "mV/V";
            }      

            

            if (szm != null)
            {
                lb_HZ.Text = szm.Speed + " HZ";
            }


        }

        private LoadCell setLoadCell() {
            pb_load.Minimum = 0;
            pb_load.Maximum = Properties.Settings.Default.NPI;
            return new LoadCell()
            {
                NPI = Properties.Settings.Default.NPI,
                RKP = Properties.Settings.Default.RKP,
                R_in = Properties.Settings.Default.R

            };

        }

        private  void UpdeteLabelInfo() {
            
                lb_info.Text = "НПИ: " + sensor.NPI + "kg, РКП: " + sensor.RKP + "mV/V, мост: " + sensor.R_in + " Om";      
                
        }

        private void loadCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var LCsettings = new LoadCellSettingsForm();

            LCsettings.FormClosed += (object obj, FormClosedEventArgs ee) =>
            {
                sensor = setLoadCell();
                UpdeteLabelInfo();
            };

            LCsettings.ShowDialog();
            
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var settings = new Settings();
            settings.ShowDialog();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (etalon != null && test != null)
            {
                var Exam = new ExamForm(sensor);
                Exam.Show();
            }
            else {
                MessageBox.Show("Тест не доступен, изиа отсутствия источников вычислений");
            }
            
        }

        private void lb_main_Click(object sender, EventArgs e)
        {
            if (etalon.zero_data == 0)
            {
                etalon.zero_data = etalon.data;
                lb_main.ForeColor = Color.Green;
            }
            else {
                etalon.zero_data = 0;
                lb_main.ForeColor = Color.Blue;
            }
            
        }

        private void lb_test_Click(object sender, EventArgs e)
        {
            if (test.zero_data == 0)
            {
                test.zero_data = test.data;
                lb_test.ForeColor = Color.Green;
            }
            else
            {
                test.zero_data = 0;
                lb_test.ForeColor = Color.Blue;
            }
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            MeasRKP measRKP = new MeasRKP(sensor);
            
            lb_res.Text = measRKP.GetItog(etalon.data, test.data);
            mc.Logger.Log = "Кнопка Set нажата, главная форма";
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
           

            szm.Load();
            lb_info_szm.Text = "Нагрузка";

            mc.Logger.Log = "Кнопка нагрузка нажата нажата, главная форма";
        }


        private void btn_stop_Click(object sender, EventArgs e)
        {
            szm.Stop();
            lb_info_szm.Text = "СТОП";
            mc.Logger.Log = "Кнопка стоп  нажата, главная форма";
        }


        private void btn_unLoad_Click(object sender, EventArgs e)
        {
            szm.UnLoad();
            lb_info_szm.Text = "Разгрузка";
            mc.Logger.Log = "Кнопка разгрузка нажата, главная форма";
        }


        private void lb_info_Click(object sender, EventArgs e)
        {
            var LCsettings = new LoadCellSettingsForm();

            LCsettings.FormClosed += (object obj, FormClosedEventArgs ee) =>
            {
                sensor = setLoadCell();
                UpdeteLabelInfo();
            };

            LCsettings.ShowDialog();

        }

        private void калькРезисторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calcForm = new CalkResistirForm();
            calcForm.Show();
        }

        private void баланНоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var zeroForm = new BalanceZeroBridgeForms(sensor);
            zeroForm.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var LogForm = new LogForm();
            LogForm.Show();
        }

        private void текучестьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreepsForm = new CreepsForm();
            CreepsForm.ShowDialog();
        }
    }
}
