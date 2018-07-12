using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfTowerWar
{
    class Enemy:Figures
    {
        public int HP;
        public int speed;

        Enemy(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
