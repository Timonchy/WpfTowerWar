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

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            bpList.Add(new BuildPlase(10, 10, true));
            bpList.Add(new BuildPlase(60, 20, true));
            bpList.Add(new BuildPlase(300, 10, true));
            bpList.Add(new BuildPlase(20, 300, true));
            bpList.Add(new BuildPlase(20, 150, true));
            bpList.Add(new BuildPlase(20, 400, true));

            foreach (BuildPlase bp in bpList)
            {
                bp.Draw(CanvasMap);                
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(bpList[2]. as UIElement , 400);
        }
    }
}

