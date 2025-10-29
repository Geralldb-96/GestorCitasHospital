using System.Windows;

namespace GestorCitasHospital.Views.Citas
{
    public partial class CitasMenuViews : Window
    {
        public CitasMenuViews()
        {
            InitializeComponent();
        }

        // Métodos de eventos para los controles definidos en el XAML
        private void LblInicio_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Lógica para el evento Inicio
        }

        private void LblPaciente_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Lógica para el evento Paciente
        }

        private void LblMedico_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Lógica para el evento Medico
        }

        private void LblHistoria_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Lógica para el evento Historia Clínica
        }

        private void LblEstadisticas_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Lógica para el evento Estadísticas
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para agendar nueva cita
        }

        private void BtnPorPaciente_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para consultar por paciente
        }

        private void BtnPorMedico_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para consultar por médico
        }

        private void BtnPorFecha_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para consultar por fecha
        }

        private void BtnPorEstado_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para consultar por estado
        }

        private void BtnResumen_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para resumen general de citas
        }
    }
}