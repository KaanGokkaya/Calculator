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

namespace Calculator
{
    public partial class MainWindow : Window
    {

        int first = 0, second = 0;
        string calculation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_clear_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Calcu.Text = "";
            txtBox_Result.Text = "";
        }

        private void btn_divide_Clicked(object sender, RoutedEventArgs e)
        {
            if ((!(txtBox_Result.Text == "")) && first == 0)
            {
                first = Convert.ToInt32(txtBox_Result.Text);
                calculation = "divide";
                txtBox_Calcu.Text = txtBox_Result.Text + " ÷ ";
                txtBox_Result.Text = "";
            }
            else
            {

            }
        }

        private void btn_zero_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_zero.Content;
        }

        private void btn_one_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_one.Content;
        }

        private void btn_two_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_two.Content;
        }

        private void btn_three_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_three.Content;
        }

        private void btn_four_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_four.Content;
        }

        private void btn_five_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_five.Content;
        }

        private void btn_six_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_six.Content;
        }

        private void btn_seven_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_seven.Content;
        }

        private void btn_eight_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_eight.Content;
        }

        private void btn_nine_Clicked(object sender, RoutedEventArgs e)
        {
            txtBox_Result.Text += btn_nine.Content;
        }

        private void txt_multiple_Clicked(object sender, RoutedEventArgs e)
        {
            if ((!(txtBox_Result.Text == "")) && first == 0)
            {
                first = Convert.ToInt32(txtBox_Result.Text);
                calculation = "multiple";
                txtBox_Calcu.Text = txtBox_Result.Text + " x ";
                txtBox_Result.Text = "";
            }
            else
            {

            }
        }

        private void txt_minus_Clicked(object sender, ContextMenuEventArgs e)
        {
            if ((!(txtBox_Result.Text == "")) && first == 0)
            {
                first = Convert.ToInt32(txtBox_Result.Text);
                calculation = "minus";
                txtBox_Calcu.Text = txtBox_Result.Text + " - ";
                txtBox_Result.Text = "";
            }
            else
            {

            }
        }

        private void btn_plus_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_back_Clicked(object sender, RoutedEventArgs e)
        {
            if(txtBox_Result.Text == "")
            {
                txtBox_Result.Text = txtBox_Calcu.Text.Substring(0, txtBox_Calcu.Text.Length - 3);
                txtBox_Calcu.Text = "";
            }
            else
            {
                txtBox_Result.Text = txtBox_Result.Text.Remove(txtBox_Result.Text.Length - 1);
            }
        }
    }
}
