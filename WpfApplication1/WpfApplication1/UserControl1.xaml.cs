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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public int LocationX { get; set; }
        public int LocationY { get; set; }

        public UserControl1()
        {
            InitializeComponent();
            LocationX = 10;
            LocationY = 20;
            Width = 50;
            Height = 50;
        }

        public void UpdatePosition()
        {
            Canvas.SetLeft (this, LocationX);
            Canvas.SetTop (this, LocationY);
        }
    }
}
