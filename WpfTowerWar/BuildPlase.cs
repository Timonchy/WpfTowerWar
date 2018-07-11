using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfTowerWar
{
    class BuildPlase:Figures
    {
        
        public bool free;

        public BuildPlase(int _x, int _y, bool _free)
        {
            x = _x;
            y = _y;
            free = _free;
        }

        public override void Draw(Canvas cnvs, int radius = 40)
        {
            var fig = new Rectangle();
            fig.Width = radius;
            fig.Height = radius;
            fig.Fill = Brushes.LightGreen;
            Canvas.SetLeft(fig, x);
            Canvas.SetTop(fig, y);
            cnvs.Children.Add(fig);
        }
    }
}
