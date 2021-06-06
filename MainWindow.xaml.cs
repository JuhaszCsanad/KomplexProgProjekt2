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

namespace Memoria
{
    
    public partial class MainWindow : Window
    {
        string[] kepek = { "kör.png", "hatszög.png", "négyzet.png", "háromszög.png" };
        string kep_egy_source;
        string kep_ketto_source;
        string kep_harom_source;
        string kep_negy_source;
        public MainWindow()
        {        
            InitializeComponent();            
        }

        private void Kilep_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult valasz = MessageBox.Show("Kilépsz?", "Üzenet!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (valasz == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string sText = null;
            if (lista.SelectedItem != null)
            {
                ComboBoxItem cbi = (ComboBoxItem)lista.SelectedItem;
                sText = cbi.Content.ToString();
            }
            BitmapImage b = new BitmapImage();
            switch (sText)
            {
                case "kör":
                    b.BeginInit();
                    b.UriSource = new Uri("kepek/kör.png", UriKind.Relative);
                    b.EndInit();
                    nagykep.Source = b;
                    break;

                case "négyzet":
                    b.BeginInit();
                    b.UriSource = new Uri("kepek/négyzet.png", UriKind.Relative);
                    b.EndInit();
                    nagykep.Source = b;
                    break;

                case "háromszög":
                    b.BeginInit();
                    b.UriSource = new Uri("kepek/háromszög.png", UriKind.Relative);
                    b.EndInit();
                    nagykep.Source = b;
                    break;

                case "hatszög":
                    b.BeginInit();
                    b.UriSource = new Uri("kepek/hatszög.png", UriKind.Relative);
                    b.EndInit();
                    nagykep.Source = b;
                    break;

                default:
                    b.BeginInit();
                    b.UriSource = new Uri("kepek/whitey.jpg", UriKind.Relative);
                    b.EndInit();
                    nagykep.Source = b;
                    break;
            }
        }

        private void Fordit_Click(object sender, RoutedEventArgs e)
        {
            string sText = null;
            if (lista.SelectedItem != null)
            {
                ComboBoxItem cbi = (ComboBoxItem)lista.SelectedItem;
                sText = cbi.Content.ToString();
            }
            BitmapImage b = new BitmapImage();
            if (No1.IsChecked == true)
            {       
                if (kep_egy_source.Contains(sText))
                {
                    MessageBox.Show("Eltaláltad!");
                    b.BeginInit();
                    b.UriSource = new Uri(kep_egy_source, UriKind.Absolute);
                    b.EndInit();
                    kep1.Source = b;
                }
                else { MessageBox.Show("Nem találtad el!"); }
            }
            else if (No2.IsChecked == true)
            {
                if (kep_ketto_source.Contains(sText))
                {
                    MessageBox.Show("Eltaláltad!");
                    b.BeginInit();
                    b.UriSource = new Uri(kep_ketto_source, UriKind.Absolute);
                    b.EndInit();
                    kep2.Source = b;
                }
                else { MessageBox.Show("Nem találtad el!"); }
            }
            else if (No3.IsChecked == true)
            {
                if (kep_harom_source.Contains(sText))
                {
                    MessageBox.Show("Eltaláltad!");
                    b.BeginInit();
                    b.UriSource = new Uri(kep_harom_source, UriKind.Absolute);
                    b.EndInit();
                    kep3.Source = b;
                }
                else { MessageBox.Show("Nem találtad el!"); }
            }
            else if (No4.IsChecked == true)
            {
                if (kep_negy_source.Contains(sText))
                {
                    MessageBox.Show("Eltaláltad!");
                    b.BeginInit();
                    b.UriSource = new Uri(kep_negy_source, UriKind.Absolute);
                    b.EndInit();
                    kep4.Source = b;
                }
                else { MessageBox.Show("Nem találtad el!"); }
            }
        }       
        private void Kever_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            List<int> rnd_szamok = new List<int>();
            int index = 0;
            BitmapImage b = new BitmapImage();
            BitmapImage bb = new BitmapImage();
            BitmapImage bbb = new BitmapImage();
            BitmapImage bbbb = new BitmapImage();
            BitmapImage c = new BitmapImage();
            index = rnd.Next(kepek.Length);
            if (!rnd_szamok.Contains(index))
            {
                rnd_szamok.Add(index);
                b.BeginInit();
                b.UriSource = new Uri("kepek/" + kepek[index], UriKind.Relative);
                b.EndInit();
                kep1.Source = b;
            }           
            do
            {
                index = rnd.Next(kepek.Length);
                if (!rnd_szamok.Contains(index))
                {
                    rnd_szamok.Add(index);
                    bb.BeginInit();
                    bb.UriSource = new Uri("kepek/" + kepek[index], UriKind.Relative);
                    bb.EndInit();
                    kep2.Source = bb;
                    break;
                }
            } while (rnd_szamok.Contains(index));
            do
            {
                index = rnd.Next(kepek.Length);
                if (!rnd_szamok.Contains(index))
                {
                    rnd_szamok.Add(index);
                    bbb.BeginInit();
                    bbb.UriSource = new Uri("kepek/" + kepek[index], UriKind.Relative);
                    bbb.EndInit();
                    kep3.Source = bbb;
                    break;
                }
            } while (rnd_szamok.Contains(index));
            do
            {
                index = rnd.Next(kepek.Length);
                if (!rnd_szamok.Contains(index))
                {
                    rnd_szamok.Add(index);
                    bbbb.BeginInit();
                    bbbb.UriSource = new Uri("kepek/" + kepek[index], UriKind.Relative);
                    bbbb.EndInit();
                    kep4.Source = bbbb;
                    break;
                }
            } while (rnd_szamok.Contains(index));                    
        }

        private void Lefordit_Click(object sender, RoutedEventArgs e)
        { 
            kep_egy_source = kep1.Source.ToString();
            kep_ketto_source = kep2.Source.ToString();
            kep_harom_source = kep3.Source.ToString();
            kep_negy_source = kep4.Source.ToString();
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri("kepek/cover.png", UriKind.Relative);
            b.EndInit();
            kep1.Source = b;
            kep2.Source = b;
            kep3.Source = b;
            kep4.Source = b;
        }
    }
}
