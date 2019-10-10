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

namespace RaadPogingen.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        const int MAX_GETAL = 10000;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRaad_Click(object sender, RoutedEventArgs e)
        {
            string inputTeRadenGetal;
            string feedback = "";

            inputTeRadenGetal = txtTeRaden.Text;

            
            lblFeedback.Content = feedback;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        bool IsGeldigGeheelGetal(string teCheckenInput)
        {
            bool isGeldigGeheelGetal = true;
            try
            {
                int.Parse(teCheckenInput);
            }
            catch (Exception)
            {

                isGeldigGeheelGetal = false;
            }
            return isGeldigGeheelGetal;
        }
    }
}
