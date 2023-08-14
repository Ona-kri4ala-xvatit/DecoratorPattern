using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Decorators.Base
{
    public class WeaponUpdate : Weapon
    {
        private Weapon wrapper;

        protected double damage;
        protected double accuracy;
        protected double recoil;
        protected double rateOfFire;

        //public WeaponUpdate(Weapon wrapper)
        //{
        //    this.wrapper = wrapper;
        //}

        public override double Damage { get => this.wrapper.Damage + damage; }
        public override double Accuracy { get => this.wrapper.Accuracy + accuracy;}
        public override double Recoil { get => this.wrapper.Recoil + recoil; }
        public override double RateOfFire { get => this.wrapper.RateOfFire + rateOfFire; }

        public Weapon SetUpdate(Weapon wrapper)
        {
            this.wrapper = wrapper;
            return this;
        }

        public Weapon RemoveUpdate() 
        {
            return wrapper; 
        }
    }
}
