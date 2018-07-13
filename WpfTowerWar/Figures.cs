using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfTowerWar
{
    class Figures
    {
        public int x;
        public int y;

        public virtual void Draw(Canvas cnvs, int radius = 30)
        {
            var fig = new Ellipse();
            fig.Width = radius;
            fig.Height = radius;
            
            //fig.MouseLeftButtonDown += el_MouseLeftButtonDown;
            if (radius == 30)
            {
                fig.Tag = "Tower";
                fig.Fill = Brushes.Blue;
                Panel.SetZIndex(fig,1);
            }
            else if (radius == 20)
            {
                fig.Tag = "Enemy";
                fig.Fill = Brushes.Red;
                Panel.SetZIndex(fig, 2);
            }
            else if (radius == 5)
            {
                fig.Tag = "Bulet";
                fig.Fill = Brushes.DarkRed;
                Panel.SetZIndex(fig, 3);
            }

            Canvas.SetLeft(fig, x);
            Canvas.SetTop(fig, y);
            cnvs.Children.Add(fig);
        }

        public void Move(Canvas cnvs, int itemNom, int toX, int toY)
        {
            Canvas.SetLeft(cnvs.Children[itemNom], toX);
            Canvas.SetTop(cnvs.Children[itemNom], toY);
        }

        //void el_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    var el = sender as System.Windows.Shapes.Ellipse;
        //    // do it!!!!!!!!!!!!!!!!!!!
        //    MessageBox.Show("Ellipse mother Fucker!");
        //}
    }
}
