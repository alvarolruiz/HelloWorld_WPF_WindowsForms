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
using ClassLibrary1;

// Para relacionar unas clases y proyectos con otros hay que crear una referencia y despues pulsar
// en proyectos, de ese modo se podrá acceder a lo que se ha programado en esas clases
// Valorar que el nombre no este vacío
namespace C1HelloWorld_WPF_CSharp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Declaramos e instanciamos un objeto de tipo persona
            Persona p1 = new Persona();
            //Asignamis el valor del txt a la propiedad nombre del objeto
            p1.nombre = txtnombre.text;
            //Mostramos el mensaje
            MessageBox.Show($"Saludo" + p1.nombre);
            Console.WriteLine("Tu nombre es"+p1.nombre);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
