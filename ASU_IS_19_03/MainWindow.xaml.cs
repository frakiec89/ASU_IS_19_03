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

namespace ASU_IS_19_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btSklad.Click += BtSklad_Click;
        }

        private void BtSklad_Click(object sender, RoutedEventArgs e)
        {
            Forms.SkladWindows windows = new Forms.SkladWindows();
            windows.Show();
        }

        private void btPrint_Click(object sender, RoutedEventArgs e)
        {
            Forms.PpintersWindow ppintersWindow = new Forms.PpintersWindow();
            ppintersWindow.Show();
        }
    }
}
