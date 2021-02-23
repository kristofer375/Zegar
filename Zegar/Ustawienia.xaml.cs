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
using System.Windows.Threading;

namespace Zegar
{
    /// <summary>
    /// Logika interakcji dla klasy Ustawienia.xaml
    /// </summary>
    public partial class Ustawienia : Window
    {
        int p1 = 0;
        int p2 = 0;
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (((MainWindow)Application.Current.MainWindow).isOn == false)
            {
                ((MainWindow)Application.Current.MainWindow).isOn = true;
                team1.IsEnabled = team2.IsEnabled = false;
            }
        }
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).isOn = false;
            team1.IsEnabled = team2.IsEnabled = true;
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).isOn = false;
            //
            team1.IsEnabled = team2.IsEnabled = true;
            team1.Text = "GSP";
            team2.Text = "GŚĆ";
            ((MainWindow)Application.Current.MainWindow).team1.Content = team1.Text.Substring(0, 3).ToUpper();
            ((MainWindow)Application.Current.MainWindow).team2.Content = team2.Text.Substring(0, 3).ToUpper();
            //
            ((MainWindow)Application.Current.MainWindow).sekundy = 0;
            ((MainWindow)Application.Current.MainWindow).minuty = 0;
            ((MainWindow)Application.Current.MainWindow).Zegar.Content = ((MainWindow)Application.Current.MainWindow).wyświetlane = "00:00";
            //
            score1.Text = "0";
            score2.Text = "0";
            p1 = p2 = 0;
            ((MainWindow)Application.Current.MainWindow).wynik.Content = score1.Text + " - " + score2.Text;
        }
        private void Poczatek_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).isOn = false;
            team1.IsEnabled = team2.IsEnabled = true;
            ((MainWindow)Application.Current.MainWindow).sekundy = 0;
            ((MainWindow)Application.Current.MainWindow).minuty = 0;
            ((MainWindow)Application.Current.MainWindow).Zegar.Content = ((MainWindow)Application.Current.MainWindow).wyświetlane = "00:00";
        }
        private void Druga1_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).isOn = false;
            team1.IsEnabled = team2.IsEnabled = true;
            ((MainWindow)Application.Current.MainWindow).sekundy = 0;
            ((MainWindow)Application.Current.MainWindow).minuty = 30;
            ((MainWindow)Application.Current.MainWindow).Zegar.Content = ((MainWindow)Application.Current.MainWindow).wyświetlane = "30:00";
        }
        private void Druga2_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).isOn = false;
            team1.IsEnabled = team2.IsEnabled = true;
            ((MainWindow)Application.Current.MainWindow).sekundy = 0;
            ((MainWindow)Application.Current.MainWindow).minuty = 45;
            ((MainWindow)Application.Current.MainWindow).Zegar.Content = ((MainWindow)Application.Current.MainWindow).wyświetlane = "45:00";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window w in Application.Current.Windows)
            {
                w.Close();
            }
        }

        private void potwierdź_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).team1.Content = team1.Text.Substring(0, 3).ToUpper();
            ((MainWindow)Application.Current.MainWindow).team2.Content = team2.Text.Substring(0, 3).ToUpper();
        }

        private void score1Zmniejsz_Click(object sender, RoutedEventArgs e)
        {
            p1--;
            score1.Text = p1.ToString();
            ((MainWindow)Application.Current.MainWindow).wynik.Content = p1.ToString() + " - " + p2.ToString();
        }

        private void score1Zwieksz_Click(object sender, RoutedEventArgs e)
        {
            p1++;
            score1.Text = p1.ToString();
            ((MainWindow)Application.Current.MainWindow).wynik.Content = p1.ToString() + " - " + p2.ToString();
        }

        private void score2Zmniejsz_Click(object sender, RoutedEventArgs e)
        {
            p2--;
            score2.Text = p2.ToString();
            ((MainWindow)Application.Current.MainWindow).wynik.Content = p1.ToString() + " - " + p2.ToString();
        }

        private void score2Zwieksz_Click(object sender, RoutedEventArgs e)
        {
            p2++;
            score2.Text = p2.ToString();
            ((MainWindow)Application.Current.MainWindow).wynik.Content = p1.ToString() + " - " + p2.ToString();
        }
    }
}
