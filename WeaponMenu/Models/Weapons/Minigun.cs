using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Weapons
{
    public class Minigun : Weapon
    {
        public Minigun()
        {
            this.Damage = 95;
            this.Accuracy = 11;
            this.Recoil = 88;
            this.RateOfFire = 98;
        }
    }
}
