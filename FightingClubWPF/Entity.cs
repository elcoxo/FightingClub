using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingClubWPF
{
    public class Entity
    {
        public string name;
        private int health;
        private int stamina;
        private int money;
        //private int power;
        Race race;
        Weapon weapon;
        Armor head;
        Armor body;
        Armor legs;
        List<Bonus> BonusItems = new List<Bonus>(3) {
        };

        public Entity(string name, int health, int stamina, int money, Race race, Weapon weapon, Armor head, Armor body, Armor legs)
        {
            this.name = name;
            this.health = health + race.getHealth();
            this.stamina = head.getPower() + body.getPower() + legs.getPower();
            this.money = money;
            this.weapon = weapon;
            this.head = head;
            this.body = body;
            this.legs = legs;
            this.BonusItems.Add(null);
            this.BonusItems.Add(null);
            this.BonusItems.Add(null);
        }

        public Entity()
        {
            this.name = "Player";
            this.health = 100;
            this.stamina = 0;
            this.money = 20;
            this.weapon = Weapon.listWeapon.ElementAt(0);
            this.head = Armor.listHead.ElementAt(0);
            this.body = Armor.listBody.ElementAt(0);
            this.legs = Armor.listLegs.ElementAt(0);
        }

        public void CopyData(Entity other)
        {
            this.name = other.name;
            this.health = other.health;
            this.stamina = other.stamina;
            this.money = other.money;
            this.weapon = other.weapon;
            this.head = other.head;
            this.body = other.body;
            this.legs = other.legs;
            //this.BonusItems = other.BonusItems;
        }

        public void Attack(Weapon weapon)
        {
            weapon.Attack(this);
        }

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int health)
        {
            this.health = health;
        }
        public int getStamina() 
        {
            return stamina;
        }

        public void setStamina(int stamina)
        {
            this.stamina = stamina;
        }

        public Race getRace() 
        { 
            return race; 
        }

        public int getMoney() 
        { 
            return money; 
        }

        public void setMoney(int money) 
        { 
            this.money = money; 
        }

        public List<Bonus> getItems() 
        { 
            return BonusItems; 
        }
        public void addItems(Entity entity, Bonus item) 
        {
            
        }
    }
}
