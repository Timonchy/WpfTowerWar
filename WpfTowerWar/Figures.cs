using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfTowerWar
{
    class Figures
    {
        public int x;
        public int y;

        public virtual void Draw(Canvas cnvs, int radius = 40)
        {
            var fig = new Ellipse();
            fig.Width = radius;
            fig.Height = radius;
            fig.Fill = Brushes.LightGreen;
            Canvas.SetLeft(fig, x);
            Canvas.SetTop(fig, y);
            cnvs.Children.Add(fig);
        }
    }
}
