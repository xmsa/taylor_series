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
            double X = 0;
            double N = 0;

            bool x = get_value(txt_X, ref X);
            bool n = get_value(txt_N, ref N);

            if (x && n)
            {

                // sum(x^n)/n!
                // a = (x^n)
                // b = n!
                // sum = a/b

                double a = 1, b=1, sum=1;

                for (int i = 1; i <= N; i++)
                {
                    a *= X;
                    b *= i;
                    sum += a / b;
                }

                MessageBox.Show(sum.ToString());

            }

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

                MessageBox.Show("Type Value Error ( " + txt.Name[4] + " )", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
    }
}
