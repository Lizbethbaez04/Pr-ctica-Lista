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

namespace PracticaLista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Alumno> alumnos = new List<Alumno>();

        //Constructor
        public MainWindow()
        {
            InitializeComponent();
            alumnos.Add(new Alumno("José Perez", "154675", "Lic. en Derecho"));
            alumnos.Add(new Alumno("Juan Lopez", "194121", "Lic. en Psicología"));
            alumnos.Add(new Alumno("Cristina García", "145866", "Lic. en Finanzas"));
            alumnos.Add(new Alumno("María Valenzuela", "184251", "ing. Civil"));

            foreach(Alumno alumno in alumnos)
            {
                lstAlumnos.Items.Add(new ListBoxItem() { Content = alumno.Nombre });
            }
        }

        private void lstAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //lstAlumnos.SelectedIndex
            lblNombre.Text = alumnos[lstAlumnos.SelectedIndex].Nombre;
            lblMatricula.Text = alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblCarrera.Text = alumnos[lstAlumnos.SelectedIndex].Carrera;
        }
    }
}
