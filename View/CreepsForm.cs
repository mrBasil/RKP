using RKP.Controller;
using RKP.Measure;
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
    public partial class CreepsForm : Form
    {
        MainClass mc = Program.mc;
        private MeasureCreeps creeps;
        Timer timer = new Timer();
        private static Graphics graf;
        private Pen grafPen;
        private double discret_X;
        private double discret_Y;

        private double x = 0;
        private double y;

        public CreepsForm()
        {
            InitializeComponent();

            pb_1.Image = new Bitmap(panel1.Width, panel1.Height);
            discret_X = panel1.Width / (30 * 12);
            discret_Y = panel1.Height / 10;

            y = panel1.Height / 2;

            timer.Interval = 500;
            timer.Tick += showLbTest;
            timer.Start();

            FormClosed += formCleseNow;
        }

        private void formCleseNow(object sender, FormClosedEventArgs e)
        {
            if(creeps != null)
            endTest();
        }

        private void showLbTest(object sender, EventArgs e)
        {
            //lb_test.Text = mc.test.data + "mV/V";
            if (creeps != null) {
                showeTimer();
            }


        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            using (var graf = Graphics.FromImage(pb_1.Image))
            {
                graf.Clear(Color.White);
            }

            creeps = new MeasureCreeps(mc.test);
            creeps.HadNewPoint += printNextPoint;
            creeps.EndTest += endTest;
            //creeps.start(mc.test.data);
            creeps.start(new Random().NextDouble());
            showeCentrLine();
            initializeNewPen();
        }

        private void showeCentrLine() {
            using (var graf = Graphics.FromImage(pb_1.Image))
            {
                for (int i = 1; i < 5; i++) {
                    graf.DrawLine(new Pen(Color.Gray), 0, panel1.Height / 2 -(float)(discret_Y*i), panel1.Width, panel1.Height/2 - (float)(discret_Y * i));
                    graf.DrawLine(new Pen(Color.Gray), 0, panel1.Height/2 + (float)(discret_Y * i), panel1.Width, panel1.Height/2 + (float)(discret_Y * i));
                }

                graf.DrawLine(new Pen(Color.Red), 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);

            }

        }

        private void printNextPoint() {
            
            using (var graf = Graphics.FromImage(pb_1.Image))
            {
                var error = creeps.GetLastPoint();
                graf.DrawLine(grafPen, (float) x, (float)y , (float)(x + discret_X), (float) (y +error));

            }
            x = x + discret_X;
        }
        private void initializeNewPen() {
            grafPen = new Pen(Color.Green);
        }

        private void showeTimer()
        {
            lb_time.Text = creeps.getTimer();

            pb_1.Image = this.pb_1.Image;

            
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            endTest();
            
            
        }

        private void endTest() {

            using (var graf = Graphics.FromImage(pb_1.Image))
            {

                graf.DrawString(creeps.GetResult(), this.Font, new SolidBrush(Color.Blue), (float)20,(float) 10 );

            }

            if (creeps != null)
            {
                creeps.stop();
            }
            else { MessageBox.Show("Что бы закончить испытание, надо его сначала начать!"); }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (pb_1.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        pb_1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
