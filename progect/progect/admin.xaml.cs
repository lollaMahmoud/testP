﻿using System;
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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        DesktopEntities db = new DesktopEntities();
        public admin()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = db.useres.Where(x => x.city.Contains(city.Text)).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Delete x = new Delete();
            this.NavigationService.Navigate(x);
        }
    }
}
