using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MassacreISP31
{
    /// <summary>
    /// Логика взаимодействия для OutWindow.xaml
    /// </summary>
    public partial class OutWindow : Window
    {
        public OutWindow(Victim victim)
        {InitializeComponent();
            lbVictimHP.Content = victim.Health;
            lbVictimName.Content = victim.VictimName;
            lbWeapon.Content = victim.WeaponName;
            meWeaponImage.Source = victim.WeaponImage.Source;
            
        }
        public class Victim
        {
            public string VictimName { get; set; }
            public string Health { get; set; }
            public string WeaponName { get; set; }
            public Image WeaponImage { get; set; }
            public Victim(string victimname, string health, string weaponname, int imnum)
            {
                VictimName = victimname;
                Health = health;
                WeaponName = weaponname;
                WeaponImage = new Image();
                WeaponImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\" + imnum.ToString() + ".jpg"));
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
