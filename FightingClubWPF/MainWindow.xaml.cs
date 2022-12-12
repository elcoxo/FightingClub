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

namespace FightingClubWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                        Race.listRace.Add(Race.Nord);
            Race.listRace.Add(Race.Emperior);
            Race.listRace.Add(Race.Cagit);
            Race.listRace.Add(Race.Ork);

            Weapon.listWeapon.Add(Melee.NoneMelee);
            Weapon.listWeapon.Add(Melee.Knuckles);
            Weapon.listWeapon.Add(Melee.Knife);
            Weapon.listWeapon.Add(Melee.Bat);
            Weapon.listWeapon.Add(Melee.Morgenstern);
            Weapon.listWeapon.Add(Gun.Pistol);
            Weapon.listWeapon.Add(Gun.Stones);

            Armor.listHead.Add(Head.NoneHead);
            Armor.listHead.Add(Head.Bandana);
            Armor.listHead.Add(Head.Hat);
            Armor.listHead.Add(Head.Cascet);
            Armor.listHead.Add(Head.Bucket);

            Armor.listBody.Add(Body.NoneBody);
            Armor.listBody.Add(Body.Singlet);
            Armor.listBody.Add(Body.Shirt);
            Armor.listBody.Add(Body.Jacket);
            Armor.listBody.Add(Body.Vest);

            Armor.listLegs.Add(Legs.NoneLegs);
            Armor.listLegs.Add(Legs.Shorts);
            Armor.listLegs.Add(Legs.Camo);
            Armor.listLegs.Add(Legs.Joggers);
            Armor.listLegs.Add(Legs.Jeans);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1 pg = new Page1();
            this.Content = pg;
        }

        private void MainImage_MouseDown(object sender, RoutedEventArgs e)
        {

            MainTyler.Source = BitmapFrame.Create(new Uri(@"E:\4KURS\OOP\1\FightingClubWPF\FightingClubWPF\main\andan.PNG"));
        }


    }
}
