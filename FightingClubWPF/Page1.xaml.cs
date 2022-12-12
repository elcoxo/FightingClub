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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            //Race.listRace.Select(u => u.Name);
            PlayerRace.ItemsSource = Race.getInfo(Race.listRace);
            PlayerHead.ItemsSource = Armor.getInfo(Head.listHead);
            PlayerBody.ItemsSource = Armor.getInfo(Body.listBody);
            PlayerLegs.ItemsSource = Armor.getInfo(Legs.listLegs);
            PlayerWeapon.ItemsSource = Weapon.getInfo(Weapon.listWeapon);

        }

        private void PlayBTN_Click(object sender, RoutedEventArgs e)
        {
            var raceHealth = Race.listRace.ElementAt(PlayerRace.SelectedIndex);
            var headStamina = Armor.listHead.ElementAt(PlayerHead.SelectedIndex);


            Entity Player = new Entity(PlayerName.Text,
                                       100,
                                       0,
                                       10,
                                       Race.listRace.ElementAt(PlayerRace.SelectedIndex),
                                       Weapon.listWeapon.ElementAt(PlayerWeapon.SelectedIndex),
                                       Armor.listHead.ElementAt(PlayerHead.SelectedIndex),
                                       Armor.listBody.ElementAt(PlayerBody.SelectedIndex),
                                       Armor.listLegs.ElementAt(PlayerLegs.SelectedIndex));
            //var test = Race.listRace.ElementAt(PlayerRace.SelectedIndex);
            //var tessto = Player.getRace();
            if (Player.name == null) Player.name = "Player";
            FightWindow fw = new FightWindow(Player);
            fw.ShowDialog();

        }

        private void PlayerRace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlayerHealth.Content = 100 + Race.listRace.ElementAt(PlayerRace.SelectedIndex).getHealth();
        }

        private void PlayerArmor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                PlayerStamina.Content = Armor.listBody.ElementAt(PlayerBody.SelectedIndex).getPower() + Armor.listHead.ElementAt(PlayerHead.SelectedIndex).getPower() + Armor.listLegs.ElementAt(PlayerLegs.SelectedIndex).getPower();
            }
            catch(Exception ex) { }


        }

        private void PlayerBody_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                PlayerStamina.Content = Armor.listBody.ElementAt(PlayerBody.SelectedIndex).getPower() + Armor.listHead.ElementAt(PlayerHead.SelectedIndex).getPower() + Armor.listLegs.ElementAt(PlayerLegs.SelectedIndex).getPower();
            }
            catch (Exception ex) { }
        }

        private void PlayerLegs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                PlayerStamina.Content = Armor.listBody.ElementAt(PlayerBody.SelectedIndex).getPower() + Armor.listHead.ElementAt(PlayerHead.SelectedIndex).getPower() + Armor.listLegs.ElementAt(PlayerLegs.SelectedIndex).getPower();
            }
            catch (Exception ex) { }
        }

        private void PlayerWeapon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PlayerPower.Content = Weapon.listWeapon.ElementAt(PlayerWeapon.SelectedIndex).getPower();
        }
    }
}
