using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTowerWar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<BuildPlase> bpList = new List<BuildPlase>();
        List<Tower> tList = new List<Tower>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var lm = new LevelMaker();
            lm.MakeLvl(CanvasMap, this.Width, this.Height, 40, bpList);

            tList.Add(new Tower(1, 50, 200, 50));
            foreach (var tower in tList)
            {
                tower.Draw(CanvasMap);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            foreach (UIElement element in CanvasMap.Children)
            {
                VisualTreeHelper.HitTest(this, null, new HitTestResultCallback(myCallback), new PointHitTestParameters(e.GetPosition(element)));

                //var element1 = element.InputHitTest(e.GetPosition(element)) as UIElement;
                var element1 = VisualTreeHelper.HitTest(element, e.GetPosition(element));
                var hitResultsList = new List<HitTestResult>();
                if (element1 != null)
                {
                    int index = CanvasMap.Children.IndexOf(element);
                    var elemType = "";
                    if(CanvasMap.Children[index] is Ellipse)
                    {
                        elemType = (element as Ellipse).Tag.ToString();
                    }

                    if (CanvasMap.Children[index] is Rectangle)
                    {
                        elemType = (element as Rectangle).Tag.ToString();
                    }
                    MessageBox.Show(elemType + " Index = " + index + 
                        " Left = " + Canvas.GetLeft(CanvasMap.Children[index]) + 
                        " Top = " + Canvas.GetTop(CanvasMap.Children[index]));
                }
            }
        }

        public HitTestResultBehavior myCallback(HitTestResult result)
        {
            if (result.VisualHit.GetType() == typeof(DrawingVisual))
            {
                if (((DrawingVisual)result.VisualHit).Opacity == 1.0)
                {
                    ((DrawingVisual)result.VisualHit).Opacity = 0.4;
                }
                else
                {
                    ((DrawingVisual)result.VisualHit).Opacity = 1.0;
                }
            }

            // Stop the hit test enumeration of objects in the visual tree.
            return HitTestResultBehavior.Stop;
        }
    }
}


