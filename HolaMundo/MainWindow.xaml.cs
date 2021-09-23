using System.Windows;
using System.Windows.Media;

namespace HolaMundo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mensaje;

            mensaje = NombreTextBox.Text;
            MensajeTextBlock.Text = "Adios " + mensaje;
            MensajeTextBlock.Foreground = Brushes.Chartreuse;
        }
    }
}
