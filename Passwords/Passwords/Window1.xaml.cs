using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Passwords
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            PasswordField.Text = "";
          int LengthVal = Convert.ToInt32(LenghtSlide.Value);
          string puncMarks = "!£$%^&*():@~<>?;#,.+_-=;|";
          Random rnd = new Random();
          for (int i = 0; i < LengthVal; i ++)
            {
                
                int nextCharType = rnd.Next(0, 4);
                if (nextCharType == 0)
                {
                    int letterGenNum = rnd.Next(0, 26); 
                    char letter = (char)('a' + letterGenNum);
                    PasswordField.Text += letter;
                }
                else if (nextCharType == 1 && PuncCheck.IsChecked == true)
                {
                    int puncGenNum = rnd.Next(0, puncMarks.Length - 1);
                    char punc = puncMarks[puncGenNum];
                    PasswordField.Text += punc;
                }
                else if (nextCharType == 2 && NumCheck.IsChecked == true)
                {
                    int NumGen = rnd.Next(0, 9);
                    PasswordField.Text += NumGen.ToString();
                }
                else if (nextCharType == 3 && CapCheck.IsChecked == true)
                {
                    int letterGenNum = rnd.Next(0, 26);
                    char letter = (char)('a' + letterGenNum);
                    letter = Char.ToUpper(letter);
                    PasswordField.Text += letter;
                }
                else
                {
                    LengthVal += 1;
                }
            }
            ScoreBox.Text = GetPasswordRating().ToString();
            int score = GetPasswordRating();
            if(score >= 90)
            {
                PasswordRating.Fill = new SolidColorBrush(Colors.DarkOliveGreen);
            }
            else if (score >= 80)
            {
                PasswordRating.Fill = new SolidColorBrush(Colors.LightGreen);
            }
            else if (score >= 70)
            {
                PasswordRating.Fill = new SolidColorBrush(Colors.Yellow);
            }
            else if (score >= 50)
            {
                PasswordRating.Fill = new SolidColorBrush(Colors.Orange);
            }
            else
            {
                PasswordRating.Fill = new SolidColorBrush(Colors.Red);
            }
        }

        private void LenghtSlide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (LengthSlideLabeller != null)
            {
                LengthSlideLabeller.Text = "Length is " + LenghtSlide.Value.ToString();
            }
            
        }
        public int GetPasswordRating()
        {
            int Rating = 0;
            string Password = PasswordField.Text;
            Rating = Rating + Password.Length * 4 + 4 * Password.Where(c => char.IsPunctuation(c)).ToArray().Length + 4 * Password.Where(c => char.IsNumber(c)).ToArray().Length + 2 * (Password.Length - Password.Where(c => char.IsLower(c)).ToArray().Length) + 2 * (Password.Length - Password.Where(c => char.IsUpper(c)).ToArray().Length);
            /*Rating = Rating + 2 * (Password.Length - Password.Where(c => char.IsUpper(c)).ToArray().Length);
            Rating = Rating + 2 * (Password.Length - Password.Where(c => char.IsLower(c)).ToArray().Length);
            Rating = Rating + 4 * Password.Where(c => char.IsNumber(c)).ToArray().Length;
            Rating = Rating + 4 * Password.Where(c => char.IsPunctuation(c)).ToArray().Length; */
            if (Password.Length >= 8)
            {
                Rating += 5;
            }

            return Rating;
        }
    }
}
