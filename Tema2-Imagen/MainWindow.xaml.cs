using System.Windows;
using System.Windows.Media;

namespace Tema2_Imagen
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

        private void ConfiguraOpacidad(object sender, RoutedEventArgs e)
        {
            if (altaRadioButton.IsChecked == true)
                imagenImage.Opacity = 1;
            else if (mediaRadioButton.IsChecked == true)
                imagenImage.Opacity = 0.6;
            else if (bajaRadioButton.IsChecked == true)
                imagenImage.Opacity = 0.3;
        }

        private void AjustaImagen(object sender, RoutedEventArgs e)
        {
            if (rellenoRadioButton.IsChecked == true)
                imagenImage.Stretch = Stretch.Fill;
            else if (uniformeRadioButton.IsChecked == true)
                imagenImage.Stretch = Stretch.Uniform;
            else if (rellenoUniformeRadioButton.IsChecked == true)
                imagenImage.Stretch = Stretch.UniformToFill;
            else if (sinAjusteRadioButton.IsChecked == true)
                imagenImage.Stretch = Stretch.None;
        }
    }
}