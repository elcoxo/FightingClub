using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingClubWPF
{
    public abstract class Armor : IArmor
    {
        public string Name { get; set; }
        public string Type { get; set; }
        protected int Power;
        protected int Cost;
        protected int Boost;
        protected int Color;

        abstract public int getPower();

        abstract public int getCost();

        abstract public void setColor(int newColor);

        abstract public void setPower(int newPower);

        abstract public void setCost(int newCost);


        public Armor(string name, string type, int power, int cost, int boost, int color)
        {
            Name = name;
            Type = type;
            Power = power;
            Cost = cost;
            Boost = boost;
            Color = color;
        }

        public static List<string> getInfo(List<Armor> list)
        {
            List<string> info = new List<string>();
            foreach (Armor armor in list)
            {
                info.Add(armor.Name + " (+" + armor.getPower() + "sp)");
            }
            return info;
        }

        public static List<Armor> listHead = new List<Armor>();
        public static List<Armor> listBody = new List<Armor>();
        public static List<Armor> listLegs = new List<Armor>();

    }

    public class Head : Armor
    {
        public Head(string name, string type, int power, int cost, int boost, int color) : base(name, type, power, cost, boost, color)
        {
        }

        public override int getPower()
        {
            return Power;
        }

        public override int getCost()
        {
            return Cost;
        }

        public override void setColor(int newColor)
        {
            Color= newColor;
        }

        public override void setPower(int newPower)
        {
            Power=newPower;
        }

        public override void setCost(int newCost)
        {
            Cost=newCost;
        }

        public static Head NoneHead = new Head("Ничего", "Голова", 0, 0, 0, 0);
        public static Head Bandana = new Head("Бандана", "Голова", 4, 1, 0, 0);
        public static Head Hat = new Head("Шляпа", "Голова", 8, 2, 0, 0);
        public static Head Cascet = new Head("Каска", "Голова", 14, 7, 0, 0);
        public static Head Bucket = new Head("Ведро", "Голова", 10, 5, 0, 0);
    }

    public class Body : Armor
    {
        public Body(string name, string type, int power, int cost, int boost, int color) : base(name, type, power, cost, boost, color)
        {
        }

        public override int getPower()
        {
            return Power;
        }

        public override int getCost()
        {
            return Cost;
        }

        public override void setColor(int newColor)
        {
            Color = newColor;
        }

        public override void setPower(int newPower)
        {
            Power = newPower;
        }

        public override void setCost(int newCost)
        {
            Cost = newCost;
        }

        public static Body NoneBody = new Body("Ничего", "Торс", 0, 0, 0, 0);
        public static Body Singlet = new Body("Майка", "Торс", 6, 2, 0, 0);
        public static Body Shirt = new Body("Стоник", "Торс", 10, 5, 0, 0);
        public static Body Jacket = new Body("Куртка Тайлера", "Торс", 16, 12, 0, 0);
        public static Body Vest = new Body("Жилетка Сыча", "Торс", 8, 4, 0, 0);
    }


    public class Legs : Armor
    {
        public Legs(string name, string type, int power, int cost, int boost, int color) : base(name, type, power, cost, boost, color)
        {
        }

        public override int getPower()
        {
            return Power;
        }

        public override int getCost()
        {
            return Cost;
        }

        public override void setColor(int newColor)
        {
            Color = newColor;
        }

        public override void setPower(int newPower)
        {
            Power = newPower;
        }

        public override void setCost(int newCost)
        {
            Cost = newCost;
        }

        public static Legs NoneLegs = new Legs("Ничего", "Торс", 0, 0, 0, 0);
        public static Legs Shorts = new Legs("Шорты Гавайские", "Ноги", 6, 2, 0, 0);
        public static Legs Camo = new Legs("Камуфляжные штаны", "Ноги", 10, 5, 0, 0);
        public static Legs Joggers = new Legs("Джоггеры", "Ноги", 12, 7, 0, 0);
        public static Legs Jeans = new Legs("Висячие джинсы", "Ноги", 8, 4, 0, 0);
    }

}

