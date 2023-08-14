using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Decorators
{
    public class Silencer : WeaponUpdate
    {
        public Silencer(Weapon wrapper = null)// : base(wrapper)
        {
            this.accuracy = 5;
            this.rateOfFire = -1;
        }
    }
}
