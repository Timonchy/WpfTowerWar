using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
            fig.Stroke = Brushes.Black;
            fig.Fill = Brushes.LightGreen;
            fig.Tag = "BuildPlase";
            //fig.MouseLeftButtonDown += rect_MouseLeftButtonDown;
            Canvas.SetLeft(fig, x);
            Canvas.SetTop(fig, y);
            cnvs.Children.Add(fig);
        }

        void rect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //var rect = sender as System.Windows.Shapes.Rectangle;
            //// do it!!!!!!!!!!!!!!!!!!!
            //var element = rect.InputHitTest(e.GetPosition(rect)) as UIElement;
            //if(element != null)
            //    MessageBox.Show("BuildPlase!");
        }
    }
}
