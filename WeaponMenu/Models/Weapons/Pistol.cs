using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Weapons
{
    public class Pistol : Weapon
    {
        public Pistol()
        {
            this.Damage = 15;
            this.Accuracy = 65;
            this.Recoil = 27;
            this.RateOfFire = 10;
        }
    }
}
