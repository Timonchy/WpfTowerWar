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
    class BuildPlase
    {
        private int x;
        private int y;
        private bool free;

        public BuildPlase(int _x, int _y, bool _free)
        {
            x = _x;
            y = _y;
            free = _free;
        }

        public void Draw(Canvas cnvs)
        {
            var rcngl =  new Rectangle();
            rcngl.Width = 30;
            rcngl.Height = 30;
            rcngl.Fill = Brushes.LightGreen;
            Canvas.SetLeft(rcngl, x);
            Canvas.SetTop(rcngl,y);

            cnvs.Children.Add(rcngl);
        }
    }
}
