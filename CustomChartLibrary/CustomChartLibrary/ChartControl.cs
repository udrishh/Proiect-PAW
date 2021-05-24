using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomChartLibrary
{
    public partial class ChartControl : Control
    {
        #region Atribute
        public ChartValue[] Data { get; set; }
        public List<DateTime> zile = new List<DateTime>();
        public List<int> nrRezervari = new List<int>();
        #endregion

        #region Metode
        public ChartControl()
        {
            InitializeComponent();
            Data = null;
        }
        #endregion

        #region Evenimente
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics graphics = pe.Graphics;
            Rectangle rectangle = pe.ClipRectangle;
            
            if(Data!=null)
            {
                var maxDotWidth = rectangle.Width / Data.Length;
                var maxDotHeight = rectangle.Height * 0.9;
                var maxValue = Data.Max(x => x.Value);
                var scalingFactor = maxDotHeight / maxValue;

                Point lastPoint = new Point(0, 0);

                graphics.FillRectangle(
                        Brushes.LightGray,
                        rectangle
                        );

                for (int i = 0; i < Data.Length; i++)
                {
                    var laneWidth = (float)maxDotWidth;
                    graphics.DrawLine(
                        new Pen(Brushes.DarkGray, 2),
                        new Point((int)(25 + i * laneWidth), rectangle.Height),
                        new Point((int)(25 + i * laneWidth), 0)
                    );
                }

                for (int i = 0; i < Data.Length; i++)
                {

                    var laneHeight = (float)scalingFactor * Data[i].Value;
                    var laneWidth = (float)maxDotWidth;

                    if (i > 0)
                    {
                        graphics.DrawLine(
                        new Pen(Brushes.LightSeaGreen, 5),
                        new Point((int)(20 + i * laneWidth), (int)(maxDotHeight - laneHeight + 10)),
                        lastPoint
                        );
                    }
                    lastPoint = new Point((int)(25 + i * laneWidth), (int)(maxDotHeight - laneHeight + 10));

                    graphics.DrawString(
                        Data[i].Label,
                        new Font(FontFamily.GenericSerif, 10, FontStyle.Bold),
                        Brushes.Black,
                        new RectangleF(10 + i * laneWidth, rectangle.Height - 15, 50, 50)
                        );
                }

                for (int i = 0; i < Data.Length; i++)
                {
                    var laneHeight = (float)scalingFactor * Data[i].Value;
                    var laneWidth = (float)maxDotWidth;

                    graphics.FillEllipse(
                        Brushes.SeaGreen,
                        15 + i * laneWidth,
                        (float)maxDotHeight - laneHeight,
                        20,
                        20
                        );
                    graphics.DrawString(
                        Data[i].Value.ToString(),
                        new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold),
                        Brushes.White,
                        new RectangleF(18 + i * laneWidth, (float)maxDotHeight - laneHeight + 2, 50, 50)
                        );
                }
            }       
        }
        #endregion
    }
}
