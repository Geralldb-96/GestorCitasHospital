using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestorCitasHospital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LblCita_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Se hizo clic en Citas", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LblPaciente_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Se hizo clic en Pacientes", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LblMedico_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Se hizo clic en Médicos", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LblHistoria_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Se hizo clic en Historia Clínica", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void LblEstadisticas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Se hizo clic en Estadísticas", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}