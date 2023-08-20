using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Decorators.Base
{
    public class WeaponUpdate : Weapon
    {
        private Weapon weapon;

        protected double damage;
        protected double accuracy;
        protected double recoil;
        protected double rateOfFire;

        public override double Damage { get => this.weapon.Damage + damage; }
        public override double Accuracy { get => this.weapon.Accuracy + accuracy;}
        public override double Recoil { get => this.weapon.Recoil + recoil; }
        public override double RateOfFire { get => this.weapon.RateOfFire + rateOfFire; }

        public Weapon SetUpdate(Weapon weapon)
        {
            this.weapon = weapon;
            return this;
        }

        public Weapon RemoveUpdate() 
        {
            return weapon;   
        }
    }
}
