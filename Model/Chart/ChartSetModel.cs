using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace RKP.Model.Chart
{
    public class ChartSetModel
    {
        private float discrHight;
        private float discrWidth;
        private float centHight ;

        public int widthPane { get; set; }
        public int heightPane { get; set; }
        public ChartSetModel(int width, int hight)
        {
            this.widthPane = width;
            this.heightPane = hight;

            discrHight = hight / 10f;
            discrWidth = width / 3000f;
            centHight = (heightPane / 2);
        }
        public float OneDiscretHight { get { return discrHight; } }
        public float OneDiscretWidth { get { return discrWidth; } }

        public Color colorBacGround { get; set; } = Color.AntiqueWhite;

        public Color colorPoint { get; set; } = Color.Green;

        public float CentrHight { get { return centHight; } }
    }
}
