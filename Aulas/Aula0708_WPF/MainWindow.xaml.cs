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

namespace Aula0708_WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
      
        string operacao;
        double x;
        double y;
        double pot;
        //interrogação transforma a variável em uma nullable
        double? memoria;


        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {

            txtTela.Text += "7";

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "8";

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "9";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "6";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "3";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "0";

        }


        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "+")
            {

                x += double.Parse(txtTela.Text);
                txtTela.Text = x.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(txtTela.Text) != 0)
                {
                    x /= double.Parse(txtTela.Text);
                    txtTela.Text = x.ToString();
                }
                else
                {
                    txtTela.Text = "Dividindo por zero";
                }
            }
            else if (operacao == "-")
            {
                x -= double.Parse(txtTela.Text);
                txtTela.Text = x.ToString();

            }
            else if (operacao == "x")
            {
                x *= double.Parse(txtTela.Text);
                txtTela.Text = x.ToString();
            }
            else if (operacao == "pot")
            {
                y = double.Parse(txtTela.Text);
                pot = Math.Pow(x, y);
                txtTela.Text = pot.ToString();


            }
            else if (operacao == "raiz")
            {
                x = Math.Sqrt(x);
                txtTela.Text = x.ToString();


            }


        }

        private void btnSoma_Click(object sender, RoutedEventArgs e)
        {

            x = double.Parse(txtTela.Text);
            txtTela.Text = "";
            operacao = "+";


        }


        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            x = double.Parse(txtTela.Text);
            txtTela.Text = "";
            operacao = "/";

        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            x = double.Parse(txtTela.Text);
            txtTela.Text = "";
            operacao = "-";

        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            x = double.Parse(txtTela.Text);
            txtTela.Text = "";
            operacao = "x";
        }

        private void btnVirgula_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += ",";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            x = 0;
            txtTela.Text = "";
            operacao = "";

        }

        private void btnRaiz_Click(object sender, RoutedEventArgs e)
        {
            x = double.Parse(txtTela.Text);
            txtTela.Text = "";
            operacao = "raiz";
        }




        private void BtnMemo_Click(object sender, RoutedEventArgs e)
        {
            if (memoria.HasValue)
            {
                txtTela.Text = memoria.ToString();
                memoria = null;
            }
            else
            {
                memoria = double.Parse(txtTela.Text);
            }
        }

        private void btnPot_Click(object sender, RoutedEventArgs e)
        {
            x = double.Parse(txtTela.Text);
            txtTela.Text = "";
            operacao = "pot";
        }
    }
}


