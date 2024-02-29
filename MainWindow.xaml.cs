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

namespace WpfApp14
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<help_deskEntities> helpDeskEntities = help_deskEntities.GetAllEntities();

            helpDeskDataGrid.ItemsSource = helpDeskEntities;
        }
    }

    public partial class help_deskEntities
    {
        public static List<help_deskEntities> GetAllEntities()
        {
            
            return new List<help_deskEntities>();
        }
    }
}
