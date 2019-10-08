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

namespace taylor_series
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

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Btn_Exp_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btn_Pi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Sin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Cos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_arcSin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_arcCos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_arcTan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Sinh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Cosh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_arcSinh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_arcTanh_Click(object sender, RoutedEventArgs e)
        {

        }

        bool get_value(TextBox txt, ref double val)
        {

            try
            {
                val = Convert.ToDouble(txt.Text);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Type Value Error ( " + txt.Name[4] + " )", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
