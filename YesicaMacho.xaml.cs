using PrimeraAplicacionWPF.Vista;
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

namespace PrimeraAplicacionWPF
{
    /// <summary>
    /// Lógica de interacción para YesicaMacho.xaml
    /// </summary>
    public partial class YesicaMacho : Window
    {
        public YesicaMacho()
        {
            InitializeComponent();
            btnMostrar.Visibility = Visibility.Collapsed;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window1 window1 = new Window1();
            window1.Show();
           
        }

        private void btnEsconder_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Collapsed;
            btnMostrar.Visibility = Visibility.Visible;

        }

        private void resuelto_Checked(object sender, RoutedEventArgs e)
        {
            if(resuelto.IsChecked == true)
            {
                enCurso.IsChecked = false;
            }
        }

        private void enCurso_Checked(object sender, RoutedEventArgs e)
        {
            if (enCurso.IsChecked == true)
            {
                resuelto.IsChecked = false;
            }
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Visible;
            btnMostrar.Visibility= Visibility.Collapsed;
        }

        
    }
}
