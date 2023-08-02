using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Weapons
{
    public class Rifle : Weapon
    {
        public Rifle()
        {
            this.Damage = 65;
            this.Accuracy = 49;
            this.Recoil = 73;
            this.RateOfFire = 70;
        }
    }
}
