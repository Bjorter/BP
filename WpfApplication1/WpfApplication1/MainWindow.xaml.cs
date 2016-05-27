using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        UserControl1 dude;
        
        public MainWindow()
        {
            InitializeComponent();
            dude = new UserControl1();
            Canvas.SetTop(dude, dude.LocationY);
            Canvas.SetLeft(dude, dude.LocationX);
            Debug.WriteLine(dude.LocationX + " " + dude.LocationY);
            can.Children.Add(dude);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dude.LocationX++;
            dude.LocationY++;
            dude.UpdatePosition();
            //Canvas.SetTop(dude, dude.LocationY);
            //Canvas.SetLeft(dude, dude.LocationX);
            Debug.WriteLine(dude.LocationX + " " + dude.LocationY);
        }
        /*private void button_Click(object sender, RoutedEventArgs e)
{
   //dude.UpdatePosition();
   Canvas.SetTop(dude, dude.LocationY);
   Canvas.SetLeft(dude, dude.LocationX);
   Debug.WriteLine(dude.LocationX + " " + dude.LocationY);
   can.Children.Add(dude);
}*/
    }
}
