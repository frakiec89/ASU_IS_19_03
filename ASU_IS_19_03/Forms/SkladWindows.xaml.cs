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
using System.Windows.Shapes;

namespace ASU_IS_19_03.Forms
{
    /// <summary>
    /// Логика взаимодействия для SkladWindows.xaml
    /// </summary>
    public partial class SkladWindows : Window
    {
        public SkladWindows()
        {
            InitializeComponent();
            btAdd.Click += BtAdd_Click;
            this.Loaded += SkladWindows_Loaded;
        }

        private void SkladWindows_Loaded(object sender, RoutedEventArgs e)
        {
            DB.MsSqlContext sqlContext = new DB.MsSqlContext(); // экземпляр подключения
            var content = sqlContext.Sklads.ToList(); // получили коллекцию 
            datagridSklad.ItemsSource = content;// отдали коллекцию таблице
        }

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            Forms.AddSdladWindow add = new AddSdladWindow();
            if (   add.ShowDialog()== true)
            {
                DB.MsSqlContext sqlContext = new DB.MsSqlContext(); // экземпляр подключения
                var content = sqlContext.Sklads.ToList(); // получили коллекцию 
                datagridSklad.ItemsSource = content;// отдали коллекцию таблице
            }
        }
    }
}
