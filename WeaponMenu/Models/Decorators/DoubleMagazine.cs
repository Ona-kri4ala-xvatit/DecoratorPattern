using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Decorators;

public class DoubleMagazine : WeaponUpdate
{
    public DoubleMagazine()
    {
        this.rateOfFire = 10;
    }
}