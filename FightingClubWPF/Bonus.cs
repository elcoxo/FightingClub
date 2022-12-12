using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingClubWPF
{
    public abstract class Bonus
    {
        public string Name;
        public string Description;
        private int healPower;
        private int staminaPower;
        private int forcePower;

        public abstract void getEffect(Entity entity);

        public abstract void removeEffect(Entity entity);
        public abstract void deleteItem(Entity entity);
        public abstract int getHealthPower();
        public abstract int getStaminaPower();
        public abstract int getForcePower();

    }

    public class HealItem : Bonus
    {
        public string Name;
        public string Description;
        private int healPower;
        private int staminaPower;
        private int forcePower;

        public HealItem(string name, string description, int healpower, int staminapower, int forcepower)
        {
            Name = name;
            Description = description;
            healPower = healpower;
            staminaPower= staminapower;
            forcePower = forcepower;
        }

        public override void deleteItem(Entity entity)
        {
            throw new NotImplementedException();
        }

        public override void getEffect(Entity entity)
        {
            entity.setHealth(entity.getHealth() + this.healPower);
            entity.setStamina(this.staminaPower);
        }

        public override void removeEffect(Entity entity)
        {
            throw new NotImplementedException();
        }

        public override int getHealthPower() { return healPower; }
        public override int getStaminaPower() { return staminaPower; }
        public override int getForcePower() { return forcePower; }

        public static HealItem EstusFlask = new HealItem("Фляга с эстусом", "Нежить ценит эти тусклые зеленые фляги. Выпейте его, чтобы восстановить 20 единиц здоровья", 20, 0, 0);
        public static HealItem Jiguly = new HealItem("Банка жигулевского", "Как можно еще похвалить это пиво - ну, невъебенное пиво, да к тому же восстанавливает 20 единиц стойкости", 20, 0, 0);
        public static HealItem Medovik = new HealItem("Медовик", "Пускай это и маленький кусочек медовика, но боже его вкус наполняет мое здоровье на 10 единиц", 10, 0, 0);
        public static HealItem Tea = new HealItem("Зеленый чай с буфета", "Стоит гроши, эффект такой же - 10 единиц стойкости", 10, 0, 0);
    }

    public class PoisonItem : Bonus
    {
        public string Name;
        public string Description;
        private int healPower;
        private int staminaPower;
        private int forcePower;

        public PoisonItem(string name, string description, int healpower, int staminapower, int forcepower)
        {
            Name = name;
            Description = description;
            healPower = healpower;
            staminaPower = staminapower;
            forcePower = forcepower;
        }

        public override void deleteItem(Entity entity)
        {
            throw new NotImplementedException();
        }

        public override void getEffect(Entity entity)
        {
            entity.setHealth(entity.getHealth() - this.healPower);
            entity.setStamina(this.staminaPower);
        }

        public override int getForcePower()
        {
            throw new NotImplementedException();
        }

        public override int getHealthPower()
        {
            throw new NotImplementedException();
        }

        public override int getStaminaPower()
        {
            throw new NotImplementedException();
        }

        public override void removeEffect(Entity entity)
        {
            throw new NotImplementedException();
        }

        public static PoisonItem Ipa = new PoisonItem("Любимая Ипа", "Врагу не пожелаешь этот напиток, но дать попробовать можно. Так он потеряет 5 единиц здоровья", 5, 0,0);
        public static PoisonItem Rag = new PoisonItem("Вонючая тряпка", "Та самая вонючая тряпка возле раковины, которая просто существует распыляет на других минус 10 единиц здоровья", 10, 0, 0);
    }
}
