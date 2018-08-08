﻿using System;
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
        double valorFinal = 0;
        string operacao;
        long num1 = 0;
        long num2 = 0;
        
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

        private void btnSoma_Click(object sender, RoutedEventArgs e)
        {
            valorFinal += double.Parse(txtTela.Text);
            txtTela.Text = "";
            operacao = "+";
            

        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == "+")
            {
                valorFinal += double.Parse(txtTela.Text);
                txtTela.Text = valorFinal.ToString();
            }else if(operacao == "/")
            {
                if (double.Parse(txtTela.Text) != 0)
                {
                    valorFinal /= double.Parse(txtTela.Text);
                    txtTela.Text = valorFinal.ToString();
                }
                else
                {
                    txtTela.Text = "Dividindo por zero";
                }

            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            valorFinal = double.Parse(txtTela.Text);
            txtTela.Text = "";
            operacao = "/";

        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
