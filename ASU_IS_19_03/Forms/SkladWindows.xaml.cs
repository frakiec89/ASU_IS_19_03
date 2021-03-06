using ASU_IS_19_03.DB.Model;
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
       
        private void tbDel_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            DB.Model.Sklad sklad = button.DataContext as DB.Model.Sklad;
            if (sklad!=null)
            {
                string message = $"Вы уверены что хотите удалить: \n {sklad.Adress} из базы данный";

                if (
                    MessageBox.Show(message , 
                    "Удаление" , MessageBoxButton.YesNo )
                    == MessageBoxResult.Yes)
                {
                    try
                    {
                        DB.MsSqlContext context = new DB.MsSqlContext();
                        context.Sklads.Remove(sklad);
                        context.SaveChanges();
                        MessageBox.Show("Удаление  прошло");

                        DB.MsSqlContext sqlContext = new DB.MsSqlContext(); // экземпляр подключения
                        var content = sqlContext.Sklads.ToList(); // получили коллекцию 
                        datagridSklad.ItemsSource = content;// отдали коллекцию таблице
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var contextMenu = (ContextMenu)menuItem.Parent;
            var item = (DataGrid)contextMenu.PlacementTarget;
            var sklad = item.SelectedItem as Sklad;
          
            if (sklad != null)
            {
                string message = $"Вы уверены что хотите удалить: \n {sklad.Adress} из базы данный";

                if (
                    MessageBox.Show(message,
                    "Удаление", MessageBoxButton.YesNo)
                    == MessageBoxResult.Yes)
                {
                    try
                    {
                        DB.MsSqlContext context = new DB.MsSqlContext();
                        context.Sklads.Remove(sklad);
                        context.SaveChanges();
                        MessageBox.Show("Удаление  прошло");

                        DB.MsSqlContext sqlContext = new DB.MsSqlContext(); // экземпляр подключения
                        var content = sqlContext.Sklads.ToList(); // получили коллекцию 
                        datagridSklad.ItemsSource = content;// отдали коллекцию таблице
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
