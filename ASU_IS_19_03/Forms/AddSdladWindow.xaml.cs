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
    /// Логика взаимодействия для AddSdladWindow.xaml
    /// </summary>
    public partial class AddSdladWindow : Window
    {
        public AddSdladWindow()
        {
            InitializeComponent();
            btAdd.Click += BtAdd_Click;
        }

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
           if ( String.IsNullOrWhiteSpace(textBoxAdres.Text) )
           {
                MessageBox.Show("Укажите адрес");
                return;
           }

            DB.Model.Sklad sklad = new DB.Model.Sklad();
            sklad.Adress = textBoxAdres.Text;
            
            DB.MsSqlContext msSqlContext = new DB.MsSqlContext();
            msSqlContext.Sklads.Add(sklad);
            msSqlContext.SaveChanges();

            MessageBox.Show("Склад добавлен в бд");
            this.DialogResult = true;
            this.Close();
        }
    }
}
