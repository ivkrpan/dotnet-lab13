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

namespace dotnet_lab13
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

        private void miIzlaz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void miPregledaj_Click(object sender, RoutedEventArgs e)
        {

            Window1 noviProzor = new Window1();

            TextRange tekst = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            noviProzor.pregledTekst.Text = tekst.Text;
            noviProzor.ShowDialog();
        }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            TextRange tekst = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            tekst.Text = "";
        }

        private void btnPonovi_Click(object sender, RoutedEventArgs e)
        {
            TextRange tekst = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            tekst.Text += tekst.Text;
        }
    }
}
