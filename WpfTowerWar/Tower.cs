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
    class Tower
    {
        private int lvl;
        private Point p;
        private int demage;

        Tower(int _lvl, Point _p, int _damege)
        {
            lvl = _lvl;
            p = _p;
            demage = _damege;
        }

        void Draw()
        {
            var el = new Ellipse();
            el.Height = 30;
            el.Width = 30;
            el.Fill = Brushes.Green;
            Canvas.SetLeft(el, p.X);
            Canvas.SetTop(el, p.Y);
        }
    }
}
