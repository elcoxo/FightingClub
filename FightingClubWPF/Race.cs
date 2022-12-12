using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingClubWPF
{
    public class Race
    {
        public string Name;
        private int Health;

        public Race(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public int getHealth()
        {
            return Health;
        }

        public static List<string> getInfo(List<Race> list)
        {
            List<string> info = new List<string>();
            foreach (Race race in list) 
            {
                if(race.getHealth()>0)
                    info.Add(race.Name + " (+" + race.getHealth() + "hp)");
                else
                    info.Add(race.Name + " (" + race.getHealth() + "hp)");
            }
            return info;
        }

        public static List<Race> listRace = new List<Race>();

        public static Race Nord = new Race("Норд", 40);
        public static Race Emperior = new Race("Имперец", 10);
        public static Race Cagit = new Race("Каджит", -10);
        public static Race Ork = new Race("Орк", 0);

    }
}
