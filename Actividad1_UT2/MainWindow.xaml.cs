using System;
using System.Windows;

namespace Actividad1_UT2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numeroRandom;
        Random generador = new Random();
        public MainWindow()
        {
            numeroRandom = generador.Next(0, 101);
            InitializeComponent();
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(numeroTextBox.Text) == numeroRandom) resultadoTextBlock.Text = "¡Has acertado!";
            else if (int.Parse(numeroTextBox.Text) < numeroRandom) resultadoTextBlock.Text = "Te has quedado corto";
            else resultadoTextBlock.Text = "Te has pasado";
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroRandom = generador.Next(0, 101);
            resultadoTextBlock.Text = "";
            numeroTextBox.Text = "";
        }
    }
}
