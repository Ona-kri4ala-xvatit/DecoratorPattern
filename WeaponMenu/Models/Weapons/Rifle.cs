using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Weapons
{
    public class Rifle : Weapon
    {
        public Rifle()
        {
            this.Damage = 45;
            this.Accuracy = 31;
            this.Recoil = 64;
            this.RateOfFire = 57;
        }
    }
}
