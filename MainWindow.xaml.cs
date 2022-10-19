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

namespace AlphaNum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string result1 = "return 0b00000000000000000;";
        int constant = 9;
        public MainWindow()
        {
            InitializeComponent();
        }
        void ReplaceChar1(int num)
        {
            StringBuilder sb = new StringBuilder(result1);
            sb[constant + num] = '1';
            result1 = sb.ToString();
        }
        void ReplaceChar0(int num)
        {
            StringBuilder sb = new StringBuilder(result1);
            sb[constant + num] = '0';
            result1 = sb.ToString();
        }
        private void Ch2_Checked(object sender, RoutedEventArgs e)
        {

            E2_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(2);
            TextBox1.Text = result1;
        }
        private void Ch2_Unchecked(object sender, RoutedEventArgs e)
        {
            E2_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(2);
            TextBox1.Text = result1;
        }
        private void Ch3_Checked(object sender, RoutedEventArgs e)
        {

            E3_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(3);
            TextBox1.Text = result1;
        }
        private void Ch3_Unchecked(object sender, RoutedEventArgs e)
        {
            E3_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(3);
            TextBox1.Text = result1;
        }
        private void Ch4_Checked(object sender, RoutedEventArgs e)
        {

            E4_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(4);
            TextBox1.Text = result1;
        }
        private void Ch4_Unchecked(object sender, RoutedEventArgs e)
        {
            E4_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(4);
            TextBox1.Text = result1;
        }
        private void Ch5_Checked(object sender, RoutedEventArgs e)
        {

            E5_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(5);
            TextBox1.Text = result1;
        }
        private void Ch5_Unchecked(object sender, RoutedEventArgs e)
        {
            E5_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(5);
            TextBox1.Text = result1;
        }
        private void Ch6_Checked(object sender, RoutedEventArgs e)
        {

            E6_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(6);
            TextBox1.Text = result1;
        }
        private void Ch6_Unchecked(object sender, RoutedEventArgs e)
        {
            E6_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(6);
            TextBox1.Text = result1;
        }
        private void Ch7_Checked(object sender, RoutedEventArgs e)
        {

            E7_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(7);
            TextBox1.Text = result1;
        }
        
        private void Ch7_Unchecked(object sender, RoutedEventArgs e)
        {
            E7_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(7);
            TextBox1.Text = result1;
        }
        private void Ch8_Checked(object sender, RoutedEventArgs e)
        {

            E8_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(8);
            TextBox1.Text = result1;
        }
        private void Ch8_Unchecked(object sender, RoutedEventArgs e)
        {
            E8_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(8);
            TextBox1.Text = result1;
        }
        private void Ch9_Checked(object sender, RoutedEventArgs e)
        {

            E9_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(9);
            TextBox1.Text = result1;
        }
        private void Ch9_Unchecked(object sender, RoutedEventArgs e)
        {
            E9_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(9);
            TextBox1.Text = result1;
        }
        private void Ch10_Checked(object sender, RoutedEventArgs e)
        {

            E10_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(10);
            TextBox1.Text = result1;
        }
        private void Ch10_Unchecked(object sender, RoutedEventArgs e)
        {
            E10_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(10);
            TextBox1.Text = result1;
        }
        private void Ch11_Checked(object sender, RoutedEventArgs e)
        {

            E11_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(11);
            TextBox1.Text = result1;
        }
        private void Ch11_Unchecked(object sender, RoutedEventArgs e)
        {
            E11_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(11);
            TextBox1.Text = result1;
        }
        private void Ch12_Checked(object sender, RoutedEventArgs e)
        {

            E12_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(12);
            TextBox1.Text = result1;
        }
        private void Ch12_Unchecked(object sender, RoutedEventArgs e)
        {
            E12_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(12);
            TextBox1.Text = result1;
        }
        private void Ch13_Checked(object sender, RoutedEventArgs e)
        {

            E13_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(13);
            TextBox1.Text = result1;
        }
        private void Ch13_Unchecked(object sender, RoutedEventArgs e)
        {
            E13_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(13);
            TextBox1.Text = result1;
        }
        private void Ch14_Checked(object sender, RoutedEventArgs e)
        {

            E14_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(14);
            TextBox1.Text = result1;
        }
        private void Ch14_Unchecked(object sender, RoutedEventArgs e)
        {
            E14_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(14);
            TextBox1.Text = result1;
        }
        private void Ch15_Checked(object sender, RoutedEventArgs e)
        {

            E15_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(15);
            TextBox1.Text = result1;
        }
        private void Ch15_Unchecked(object sender, RoutedEventArgs e)
        {
            E15_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(15);
            TextBox1.Text = result1;
        }
        private void Ch16_Checked(object sender, RoutedEventArgs e)
        {

            E16_Copy.Visibility = Visibility.Visible;
            ReplaceChar1(16);
            TextBox1.Text = result1;
        }

        private void Ch16_Unchecked(object sender, RoutedEventArgs e)
        {
            E16_Copy.Visibility = Visibility.Collapsed;
            ReplaceChar0(16);
            TextBox1.Text = result1;
        }

    }
}
