using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RKP.Model.Chart;
using RKP.Model;
using RKP.Controller;
using RKP.Data.Indik;
using RKP.Data.Peref;

using Point = RKP.Model.Chart.Point;
using RKP.Measure;

namespace RKP.View
{
    public partial class ExamForm : Form
    {
        LoadCell loadCell;
        ChartSetModel chartSet;
        MainClass mc = Program.mc;
        private int centHight;

        private Indikator etalon;
        private Indikator test;
        private SZM szm;
        private static Graphics graf;
        private bool drowe;

        

        List<Point> points = new List<Point>();
        Pen absolutePen = new Pen(Color.Black);
        Pen countedPen = new Pen(Color.Green);

        Timer timer = new Timer();

        public ExamForm(LoadCell lc)
        {
            InitializeComponent();

            chartSet = new ChartSetModel(pb_1.Width, pb_1.Height);

            pb_1.Image = new Bitmap(chartSet.widthPane, chartSet.heightPane);

            pb_1.BackColor = chartSet.colorBacGround;

            centHight = (chartSet.heightPane / 2);

            
            

            etalon = mc.etalon;
            test = mc.test;
            szm = mc.peref;

            loadCell = lc;
            
            

            points.Add(new Point(chartSet, 0, 0));

            timer.Interval = 100;
            timer.Tick += SetProgressBar;
            timer.Start();

            graf = Graphics.FromImage(pb_1.Image);
            
            SetChart();
            //DrawePoint();

        }

        public void SetChart()
        {            
            var pen = new Pen(Color.CadetBlue);           

                graf.DrawLine(pen, 0, centHight - (chartSet.OneDiscretHight / 2), chartSet.OneDiscretWidth * 500, centHight - (chartSet.OneDiscretHight / 2));

                graf.DrawLine(pen, chartSet.OneDiscretWidth * 500, centHight - (chartSet.OneDiscretHight / 2), chartSet.OneDiscretWidth * 500, centHight - (chartSet.OneDiscretHight));
                graf.DrawLine(pen, chartSet.OneDiscretWidth * 500, centHight - (chartSet.OneDiscretHight), chartSet.OneDiscretWidth * 2000, centHight - (chartSet.OneDiscretHight));
                graf.DrawLine(pen, chartSet.OneDiscretWidth * 2000, centHight - (chartSet.OneDiscretHight), chartSet.OneDiscretWidth * 2000, centHight - (chartSet.OneDiscretHight * 3 / 2));
                graf.DrawLine(pen, chartSet.OneDiscretWidth * 2000, centHight - (chartSet.OneDiscretHight * 3 / 2), chartSet.OneDiscretWidth * 3000, centHight - (chartSet.OneDiscretHight * 3 / 2));
                graf.DrawLine(pen, chartSet.OneDiscretWidth * 3000, centHight - (chartSet.OneDiscretHight * 3 / 2), chartSet.OneDiscretWidth * 3000, centHight + (chartSet.OneDiscretHight * 3 / 2));

                graf.DrawLine(pen, chartSet.OneDiscretWidth * 3000, centHight + (chartSet.OneDiscretHight * 3 / 2), chartSet.OneDiscretWidth * 2000, centHight + (chartSet.OneDiscretHight * 3 / 2));
                graf.DrawLine(pen, chartSet.OneDiscretWidth * 2000, centHight + (chartSet.OneDiscretHight * 3 / 2), chartSet.OneDiscretWidth * 2000, centHight + (chartSet.OneDiscretHight));
                graf.DrawLine(pen, chartSet.OneDiscretWidth * 2000, centHight + (chartSet.OneDiscretHight), chartSet.OneDiscretWidth * 500, centHight + (chartSet.OneDiscretHight));
                graf.DrawLine(pen, chartSet.OneDiscretWidth * 500, centHight + (chartSet.OneDiscretHight), chartSet.OneDiscretWidth * 500, centHight + (chartSet.OneDiscretHight / 2));
                graf.DrawLine(pen, chartSet.OneDiscretWidth * 500, centHight + (chartSet.OneDiscretHight / 2), chartSet.OneDiscretWidth, centHight + (chartSet.OneDiscretHight / 2));

                graf.DrawLine(new Pen(Color.Orange), chartSet.OneDiscretWidth, centHight, chartSet.OneDiscretWidth * 3000, centHight);             
                        
        }

        private void DrawePoint() 
        {
            Point nextPoint = new Point(chartSet, etalon.data, test.data);
            var pointLas = points.Last();
            pb_1.Image = this.pb_1.Image;
            using (var graf = Graphics.FromImage(pb_1.Image))
            {
                absolutePen.Color = nextPoint.colorPoint;
               graf.DrawLine(absolutePen, pointLas.X, pointLas.Y, nextPoint.X, nextPoint.Y);
                graf.DrawString(Math.Round(nextPoint.AbsError, 1) + "", this.Font, new SolidBrush(nextPoint.colorPoint), nextPoint.X, nextPoint.Y);
            }
            //Console.WriteLine(pointLas.X + " " + pointLas.Y + " / " + nextPoint.X + " " + nextPoint.Y);
            points.Add(nextPoint);   
        }

        private void DrawePointReduse()
        {
            var pointForReduce = MeasReduceError.GetPointForReduce(points);

            Console.WriteLine(pointForReduce.Etalon);

            foreach (var pointForError in points) 
            {
                pointForError.Reduce((float)pointForReduce.AbsError,(float) pointForReduce.Etalon);
            }

            for (int i = 1; i< points.Count; i++)
            {
                pb_1.Image = this.pb_1.Image;
                using (var graf = Graphics.FromImage(pb_1.Image))
                {                    
                    graf.DrawLine(countedPen, points[i-1].X, points[i-1].ReduceY, points[i].X, points[i].ReduceY);
                    graf.DrawString(Math.Round(points[i].ReduseError, 1) + "", this.Font, new SolidBrush(Color.Blue), points[i].X, points[i].ReduceY);
                }
            }
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            DrawePoint();      
            
        }

        private void SetProgressBar(object sender, EventArgs e) 
        {
            pb_loading.Maximum = loadCell.NPI;
            try
            {
                if (etalon != null)
                {
                    pb_1.BackColor = chartSet.colorBacGround;
                    if (etalon.data > 0)
                        pb_loading.Value = (int)etalon.data;                    
                    else if(etalon.data > pb_loading.Maximum)
                        pb_loading.Value = pb_loading.Maximum;
                    else
                        pb_loading.Value = 0;
                }
                else
                {
                    MessageBox.Show("Эталон не доступен");
                }
            }
            catch { 
                pb_1.BackColor = Color.Red;
            }
            
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            DrawePointReduse();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            mc.Logger.Log = "Кнопка нагрузка нажата нажата, форма испытания";
            szm.Load();
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            mc.Logger.Log = "Кнопка Стоп нажата нажата, форма испытания";
            szm.Stop();
            //mc.Logger.Log = "Кнопка Стоп нажата нажата, главная форма";
        }

        private void btn_unLoad_Click(object sender, EventArgs e)
        {
            mc.Logger.Log = "Кнопка Разгрузка нажата нажата, форма испытания";
            szm.UnLoad();
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
 

