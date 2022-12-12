using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingClubWPF
{
    public interface IWeapon
    {
        String Name { get; set; }
        String Type { get; set; }
        //int Power { get; set; }
        //int Cost { get; set; }

        int getPower();
        void setPower(int newPower);
        int getCost();
        void setCost(int newCost);
        void Attack(Entity Enemy);

        Weapon GetWeapon(int index);
    }
}
