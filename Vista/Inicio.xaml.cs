using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PrimeraAplicacionWPF.Vista
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
           
            SqlConnection connection = new SqlConnection("Data Source = 172.26.4.166; Initial Catalog = DBVENTAS; User ID = sa; Password = 87654321");
            connection.Open();
            SqlCommand query = new SqlCommand("select idUsuario from USUARIO where Documento = @documento and Clave = @clave", connection);
            
            var documento = txtUser.Text;
            var clave = pwdContra.Password.ToString();

            
            query.Parameters.AddWithValue("@documento", documento);
            query.Parameters.AddWithValue("@clave", clave);

            
            var reader = query.ExecuteReader();

           
            if (reader.Read())
            {
                this.Hide();
                YesicaMacho yesicaMacho = new YesicaMacho();
                yesicaMacho.Show();;
            }
            else
            {
                MessageBox.Show("Error");
            }
            connection.Close();


        }


    }
}
