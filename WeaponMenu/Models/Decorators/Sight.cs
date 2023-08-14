using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Decorators;

public class Sight : WeaponUpdate
{
    public Sight(Weapon weapon = null) //: base(weapon)
    {
        this.damage = 5;
        this.accuracy = 10;
    }
}

