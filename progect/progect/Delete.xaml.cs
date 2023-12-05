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

namespace progect
{
    /// <summary>
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        DesktopEntities db = new DesktopEntities();
        public Delete()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            usere u = db.useres.Remove(db.useres.First(x => x.phon == delet.Text));
            db.SaveChanges();
            if (u.phon == delet.Text)
            {
                dg.ItemsSource = db.useres.ToList();
            }

            MessageBox.Show("the user data has deleted");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            admin x = new admin();
            this.NavigationService.Navigate(x);
        }
    }
}
