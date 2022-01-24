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

namespace Tarea2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                var lista = RolesBll.GetLista();
                DatosDataGrid.ItemsSource = lista;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void NuevoButton()
        {
            

        }
        private void GuardarButton(object sender, RoutedEventArgs e)
        {
            DateTime actual = new DateTime();
            Roles rol = new Roles(DescripcionTextBox.Text);
            rol.SetFechaCreacion(actual.ToString());

            var paso = RolesBll.Insertar(rol);

            if (paso)
                MessageBox.Show("Rol Agregado con Exito!");
            else
                MessageBox.Show("No se pudo Agregar el Rol");
        }

        private void EditarButton(object sender, RoutedEventArgs e)
        {
            DateTime actual = new DateTime();
            Roles rol = new Roles(DescripcionTextBox.Text);
            rol.SetFechaCreacion(actual.ToString());
            rol.RolId = RolIDTextBox.Text;

            var paso = RolesBll.Editar(rol);

            if (paso)
                MessageBox.Show("Rol Editado con Exito!");
            else
                MessageBox.Show("No se pudo Editar el Rol");
        }

        private void EliminarButton(object sender, RoutedEventArgs e)
        {

        }



    }

}
