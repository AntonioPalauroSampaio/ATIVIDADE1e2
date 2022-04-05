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
using System.Windows.Shapes;

namespace ATV01.Janelas
{
    /// <summary>
    /// Lógica interna para PrincipalWindow.xaml
    /// </summary>
    public partial class PrincipalWindow : Window
    {
        public PrincipalWindow()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btSoma_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double resultado = num1 + num2;
            txtResulSoma.Text =Convert.ToString(resultado);
            resultado = num1 - num2;
            txtResulSub.Text = Convert.ToString(resultado);
            resultado = num1 * num2;
            txtResulMult.Text = Convert.ToString(resultado);
            resultado = num1 / num2;
            txtResulDiv.Text = Convert.ToString(resultado);
        }

        private void btFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtResultado_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();    
            txtResulSoma.Clear();
            txtResulSub.Clear();
            txtResulMult.Clear();
            txtResulDiv.Clear();
        }
    }
}
