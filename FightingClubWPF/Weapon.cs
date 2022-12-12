using System.Collections.Generic;

namespace FightingClubWPF
{
    public abstract class Weapon : IWeapon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        protected int Power;
        protected int Cost;
        protected int Boost;
        abstract public int getPower();
        abstract public void setPower(int newPower);
        abstract public int getCost();
        abstract public void setCost(int newCost);
        abstract public void Attack(Entity Enemy);

        abstract public Weapon GetWeapon(int index);    
        public Weapon(string name, string type, int power, int cost, int boost)
        {
            Name = name;
            Type = type;
            Power = power;
            Cost = cost;
            Boost = boost;
        }

        public static List<string> getInfo(List<Weapon> list)
        {
            List<string> info = new List<string>();
            foreach (Weapon weapon in list)
            {
                info.Add(weapon.Name + " (+" + weapon.getPower() + ")");
            }
            return info;
        }


        public static List<Weapon> listWeapon = new List<Weapon>();

        // test
        public static Weapon[] testListWeapon =
            {
                new Melee("Кулаки2", "Ближний бой", 6, 0, 0) { },
                new Melee("Кастет2", "Ближний бой", 8, 4, 0 ){},
                new Melee("Нож", "Ближний бой", 10, 5, 0){ },

            };
    }

    public class Melee : Weapon
    {
        public Melee(string name, string type, int power, int cost, int boost) : base(name, type, power, cost, boost)
        {

        }

        public override void Attack(Entity Enemy)
        {
            int stamina = Enemy.getStamina();
            int health = Enemy.getHealth();

            if (Enemy.getStamina() > 0)
            {
                Enemy.setStamina(Enemy.getStamina() - Power / 2);
                Enemy.setHealth(Enemy.getHealth() - Power / 2);

            }
            
        }

        public override int getCost()
        {
            return Cost;
        }

        public override int getPower()
        {
            return Power;
        }

        public override void setCost(int newCost)
        {
            Cost = newCost;
        }

        public override void setPower(int newPower)
        {
            Power = newPower;
        }

        public override Weapon GetWeapon(int index)
        {
            throw new System.NotImplementedException();
        }

        public static Melee NoneMelee = new Melee("Кулаки", "Ближний бой", 6, 0, 0);
        public static Melee Knuckles = new Melee("Кастет", "Ближний бой", 8, 4, 0);
        public static Melee Knife = new Melee("Нож", "Ближний бой", 10, 5, 0);
        public static Melee Bat = new Melee("Бита", "Ближний бой", 16, 10, 0);
        public static Melee Morgenstern = new Melee("Моргенштерн", "Ближний бой", 20, 17, 0);
    }

    public class Gun : Weapon
    {
        public Gun(string name, string type, int power, int cost, int boost) : base(name, type, power, cost, boost)
        {
        }

        public override void Attack(Entity Enemy)
        {

        }

        public override int getCost()
        {
            return Cost;
        }

        public override int getPower()
        {
            return Power;
        }

        public override void setCost(int newCost)
        {
            Cost = newCost;
        }

        public override void setPower(int newPower)
        {
            Power = newPower;
        }

        public override Weapon GetWeapon(int index)
        {
            throw new System.NotImplementedException();
        }

        public static Gun Pistol = new Gun("Травмат", "Дальний бой", 24, 22, 0);
        public static Gun Stones = new Gun("Камни", "Дальний бой", 12, 9, 0);
    }
}
