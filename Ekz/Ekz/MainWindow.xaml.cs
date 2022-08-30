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
using System.Threading;

namespace Ekz
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button1.Content = " ";
            Button2.Content = "  ";
            Button3.Content = "   ";
            Button4.Content = "    ";
            Button5.Content = "     ";
            Button6.Content = "      ";
            Button7.Content = "       ";
            Button8.Content = "        ";
            Button9.Content = "         ";
        }
        string temp = "X";
        bool ChecWin()
        {
            if (Button1.Content == Button2.Content && Button1.Content == Button3.Content)
            {
                return true;
            }
            else if (Button4.Content == Button5.Content && Button4.Content == Button6.Content)
            {
                return true;
            }
            else if (Button7.Content == Button8.Content && Button7.Content == Button9.Content)
            {
                return true;
            }
            if (Button1.Content == Button4.Content && Button1.Content == Button7.Content)
            {
                return true;
            }
            else if (Button2.Content == Button5.Content && Button2.Content == Button8.Content)
            {
                return true;
            }
            else if (Button3.Content == Button6.Content && Button3.Content == Button9.Content)
            {
                return true;
            }
            else if (Button1.Content == Button5.Content && Button1.Content == Button9.Content)
            {
                return true;
            }
            else if (Button3.Content == Button5.Content && Button3.Content == Button7.Content)
            {
                return true;
            }
            else if (Button1.IsEnabled == false && Button2.IsEnabled == false && Button3.IsEnabled == false && Button4.IsEnabled == false && Button5.IsEnabled == false && Button6.IsEnabled == false && Button7.IsEnabled == false && Button8.IsEnabled == false && Button9.IsEnabled == false)
            {
                Info.Text = "Ничья!";
                Button1.IsEnabled = true;
                Button2.IsEnabled = true;
                Button3.IsEnabled = true;
                Button4.IsEnabled = true;
                Button5.IsEnabled = true;
                Button6.IsEnabled = true;
                Button7.IsEnabled = true;
                Button8.IsEnabled = true;
                Button9.IsEnabled = true;
                Button1.Content = " ";
                Button2.Content = "  ";
                Button3.Content = "   ";
                Button4.Content = "    ";
                Button5.Content = "     ";
                Button6.Content = "      ";
                Button7.Content = "       ";
                Button8.Content = "        ";
                Button9.Content = "         ";
            }

            return false;
        }
        void LabelText()
        {

            if (temp == "X")
            {


                string xwinStr = XWin.Text;
                char num = xwinStr[2];
                int num2 = Convert.ToInt32(num);
                num2++;
                num = (char)num2;
                xwinStr = xwinStr.Substring(0, xwinStr.Length - 1);
                xwinStr = String.Concat(xwinStr, num);

                XWin.Text = xwinStr;

                Info.Text = "Победил-X!";

            }
            else if (temp == "O")
            {


                string owinStr = OWin.Text;
                char num = owinStr[2];
                int num2 = Convert.ToInt32(num);
                num2++;
                num = (char)num2;
                owinStr = owinStr.Substring(0, owinStr.Length - 1);
                owinStr = String.Concat(owinStr, num);
                OWin.Text = owinStr;

                Info.Text = "Победил-O!";


            }
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            Button9.IsEnabled = true;
            Button1.Content = " ";
            Button2.Content = "  ";
            Button3.Content = "   ";
            Button4.Content = "    ";
            Button5.Content = "     ";
            Button6.Content = "      ";
            Button7.Content = "       ";
            Button8.Content = "        ";
            Button9.Content = "         ";
        }
        void Cliked(Button btn)
        {
            btn.Content = temp;
            btn.Background = Brushes.SpringGreen;
            btn.IsEnabled = false;
            if (ChecWin())
            {
                LabelText();
                return;
            }
            if (temp == "X")
            {
                temp = "O";
            }
            else
            {
                temp = "X";
            }
        }
        private void XO1(object sender, RoutedEventArgs e)
        {
            Cliked(Button1);
        }
        private void XO2(object sender, RoutedEventArgs e)
        {
            Cliked(Button2);
        }
        private void XO3(object sender, RoutedEventArgs e)
        {
            Cliked(Button3);
        }
        private void XO4(object sender, RoutedEventArgs e)
        {
            Cliked(Button4);
        }

        private void XO5(object sender, RoutedEventArgs e)
        {
            Cliked(Button5);
        }
        private void XO6(object sender, RoutedEventArgs e)
        {
            Cliked(Button6);
        }
        private void XO7(object sender, RoutedEventArgs e)
        {
            Cliked(Button7);
        }
        private void XO8(object sender, RoutedEventArgs e)
        {
            Cliked(Button8);
        }
        private void XO9(object sender, RoutedEventArgs e)
        {
            Cliked(Button9);
        }
    }
}
