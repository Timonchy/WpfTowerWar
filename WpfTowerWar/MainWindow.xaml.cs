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
            bpList.Add(new BuildPlase(0, 0, true));
            bpList.Add(new BuildPlase(60, 20, true));
            bpList.Add(new BuildPlase(300, 10, true));
            bpList.Add(new BuildPlase(20, 300, true));
            bpList.Add(new BuildPlase(20, 150, true));
            bpList.Add(new BuildPlase(20, 400, true));

            foreach (BuildPlase bp in bpList)
            {
                bp.Draw(CanvasMap);
            }

            tList.Add(new Tower(1, 50, 200, 50));
            foreach (var tower in tList)
            {
                tower.Draw(CanvasMap);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            foreach (UIElement element in CanvasMap.Children)
            {
                var element1 = element.InputHitTest(e.GetPosition(element)) as UIElement;
                if (element1 != null)
                {
                    int index = CanvasMap.Children.IndexOf(element);
                    var elemType = "";
                    if (CanvasMap.Children[index] is Rectangle)
                    {
                        elemType = (element as Rectangle).Tag.ToString();
                    }
                    else
                    {
                        elemType = (element as Ellipse).Tag.ToString();
                    }
                    MessageBox.Show(elemType + " Index =" + index + 
                        " Left = " + Canvas.GetLeft(CanvasMap.Children[index]) + 
                        " Top = " + Canvas.GetTop(CanvasMap.Children[index]));
                }
            }
        }
    }
}


