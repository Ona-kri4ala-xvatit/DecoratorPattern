using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Weapons
{
    public class SniperRifle : Weapon
    {
        public SniperRifle()
        {
            this.Damage = 90;
            this.Accuracy = 85;
            this.Recoil = 89;
            this.RateOfFire = 10;
        }
    }
}
