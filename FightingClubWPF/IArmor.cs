using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingClubWPF
{
    interface IArmor
    {
        String Name { get; set; }
        String Type { get; set; }

        int getPower();
        void setPower(int newPower);
        int getCost();
        void setCost(int newCost);

        void setColor(int newColor);

    }
}
