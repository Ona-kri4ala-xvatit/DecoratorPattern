using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Weapons
{
    public class SMG : Weapon
    {
        public SMG()
        {
            this.Damage = 25;
            this.Accuracy = 42;
            this.Recoil = 50;
            this.RateOfFire = 74;
        }
    }
}
