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
using System.Windows.Threading;

namespace Zegar
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isOn;
        public int sekundy = 0;
        public int minuty = 0;
        public string wyświetlane = "00:00";
        DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Send);
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += Licznik;
            timer.Interval = TimeSpan.FromMilliseconds(990);
            timer.Start();
            Ustawienia ustawienia = new Ustawienia();
            ustawienia.Show();
        }
        private void Licznik(object sender, EventArgs e)
        {
            if (isOn)
            {
                if (sekundy < 59)
                {
                    sekundy++;
                }
                else
                {
                    sekundy = 0;
                    minuty++;
                }
                if (minuty < 10)
                    wyświetlane = "0" + minuty + ":";
                else
                    wyświetlane = minuty + ":";
                if (sekundy < 10)
                    wyświetlane += "0" + sekundy;
                else
                    wyświetlane += sekundy;
            }
           Zegar.Content = wyświetlane;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window w in Application.Current.Windows)
            {
                w.Close();
            }
        }
    }
}
