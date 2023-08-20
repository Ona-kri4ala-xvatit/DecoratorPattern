using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Decorators
{
    public class Silencer : WeaponUpdate
    {
        public Silencer()
        {
            this.accuracy = 20;
            this.rateOfFire = -10;
        }
    }
}
