using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Decorators
{
    public class WeaponButt : WeaponUpdate
    {
        public WeaponButt(Weapon wreapper = null)// : base(wreapper)
        {
            this.recoil = -10;
            this.accuracy = 5;
        }
    }
}
