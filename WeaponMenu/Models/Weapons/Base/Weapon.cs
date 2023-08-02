namespace WeaponMenu.Models.Weapons.Base
{
    public abstract class Weapon
    {
        public virtual double Damage { get; set; }
        public virtual double Accuracy { get; set; }
        public virtual double Recoil { get; set; }
        public virtual double RateOfFire { get; set; }
    }
}
