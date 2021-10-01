using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;


namespace ASU_IS_19_03.Forms
{
    /// <summary>
    /// Логика взаимодействия для PpintersWindow.xaml
    /// </summary>
    public partial class PpintersWindow : Window
    {
        public PpintersWindow()
        {
            InitializeComponent();
            this.Loaded += PpintersWindow_Loaded;

        }

        private void PpintersWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DB.MsSqlContext context = new DB.MsSqlContext();
            listboxPrint.ItemsSource = 
                context.Printers.Include(x=>x.Manufacturer).
                Include(x=>x.TypePrinter).
                ToList();
        }

        private void listboxPrint_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
          

        }
    }
}
