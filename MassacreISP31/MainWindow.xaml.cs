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

namespace MassacreISP31
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Victim_Output(object sender, SelectionChangedEventArgs e)
        {
            switch (victimList.SelectedIndex)
            {
                case 0:
                    string str = ((ListBoxItem)victimList.SelectedItem).Content.ToString();
                    OutWindow.Victim victim = new OutWindow.Victim(str, "100", "Дробовик", 1);
                    OutWindow da = new OutWindow(victim);
                    da.ShowDialog();
                    break;
                case 1:
                    str = ((ListBoxItem)victimList.SelectedItem).Content.ToString();
                    victim = new OutWindow.Victim(str, "200", "Оружие для убийства: Арбалет ", 2);
                    da = new OutWindow(victim);
                    da.ShowDialog();
                    break;
                case 2:
                    str = ((ListBoxItem)victimList.SelectedItem).Content.ToString();
                    victim = new OutWindow.Victim(str, "50", "провод", 3);
                    da = new OutWindow(victim);
                    da.ShowDialog();
                    break;
                case 3:
                    str = ((ListBoxItem)victimList.SelectedItem).Content.ToString();
                    victim = new OutWindow.Victim(str, "150", "Ботинок (немытый)", 4);
                    da = new OutWindow(victim);
                    da.ShowDialog();
                    break;
                case 4:
                    str = ((ListBoxItem)victimList.SelectedItem).Content.ToString();
                    victim = new OutWindow.Victim(str, "400", "Беговая дорожка", 5);
                    da = new OutWindow(victim);
                    da.ShowDialog();
                    break;
            }
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }


}
