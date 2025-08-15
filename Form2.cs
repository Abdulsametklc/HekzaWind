using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hekzawind_Prototip
{
    public partial class WindingForm : Form
    {
        private string windingSchema; // Hesaplanan şema buraya gelecek

        public WindingForm(string schema)
        {
            InitializeComponent();
            windingSchema = schema;
            this.Paint += new PaintEventHandler(DrawWinding);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WindingForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "WindingForm";
            this.ResumeLayout(false);
        }

        private void DrawWinding(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = 150;
            int nuten = windingSchema.Length;
            double angleStep = 360.0 / nuten;

            for (int i = 0; i < nuten; i++)
            {
                double angle = i * angleStep * Math.PI / 180;
                int x = centerX + (int)(radius * Math.Cos(angle));
                int y = centerY + (int)(radius * Math.Sin(angle));

                Brush brush = Brushes.Black;
                char c = windingSchema[i];

                if (c == 'A' || c == 'a') brush = Brushes.Red;
                else if (c == 'B' || c == 'b') brush = Brushes.Blue;
                else if (c == 'C' || c == 'c') brush = Brushes.Green;

                g.FillRectangle(brush, x - 10, y - 10, 20, 20);
            }
        }
    }
}
