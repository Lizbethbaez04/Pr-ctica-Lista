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
            Materia historia = new Materia("HS6542", "Historia");
            Materia matematicas = new Materia("MA8765", "Matematicas");
            Materia civismo = new Materia("CV1454", "Civismo");
            Materia espanol = new Materia("ESP4657", "Español");
            Materia artistica = new Materia("ART468", "Artistica");

            alumnos.Add(new Alumno("José Perez", "154675", "Lic. en Derecho"));
            alumnos.Add(new Alumno("Juan Lopez", "194121", "Lic. en Psicología"));
            alumnos.Add(new Alumno("Cristina García", "145866", "Lic. en Finanzas"));
            alumnos.Add(new Alumno("María Valenzuela", "184251", "ing. Civil"));

            //Primer alumno
            alumnos[0].Materias.Add(espanol);
            alumnos[0].Materias.Add(artistica);
            //Segundo
            alumnos[1].Materias.Add(matematicas);
            alumnos[1].Materias.Add(civismo);
            //Tercero
            alumnos[2].Materias.Add(historia);
            alumnos[2].Materias.Add(espanol);
            //Cuarto
            alumnos[3].Materias.Add(civismo);
            alumnos[3].Materias.Add(artistica);

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

            //Borrar todos los elementos de la coleccion
            lstMaterias.Items.Clear();

            foreach(Materia materia in alumnos[lstAlumnos.SelectedIndex].Materias)
            {
                lstMaterias.Items.Add(new ListBoxItem() { Content = materia.Nombre });
            }
        }

        private void lstMaterias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //el if es para que no marque error al cambiar de alumnos
            if(lstMaterias.SelectedIndex != -1)
            {
                lblNombreMateria.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Nombre;
                lblClaveMateria.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Clave;
            }
            else
            {
                lblNombreMateria.Text = "";
                lblClaveMateria.Text = "";
            }
        }
    }
}
