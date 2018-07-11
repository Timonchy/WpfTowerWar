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
    class Tower:Figures
    {
        private int lvl;
        private Point p;
        private int demage;

        public Tower(int _lvl, int _x, int _y, int _damege)
        {
            lvl = _lvl;
            x = _x;
            y = _y;
            demage = _damege;
        }
    }
}
