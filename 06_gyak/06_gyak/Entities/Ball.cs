using _06_gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_gyak.Entities
{
    public class Ball : Toy
    {
        public Color Color { get; set; }
        public SolidBrush BallColor { get; private set; }
        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
        }
        protected override void DrawImage(Graphics graphics)
        {
            graphics.FillEllipse(BallColor, 0, 0, Width, Height);
        }
    }
}
