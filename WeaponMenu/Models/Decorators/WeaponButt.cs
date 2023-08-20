using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Decorators
{
    public class WeaponButt : WeaponUpdate
    {
        public WeaponButt()
        {
            this.recoil = -5;
            this.accuracy = 5;
        }
    }
}
