using System.Runtime.CompilerServices;
using WeaponMenu.Models.Decorators.Base;

namespace WeaponMenu.Models.Decorators;

public class MultiShotAccessoryUnderbarrelLauncher : WeaponUpdate
{
    public MultiShotAccessoryUnderbarrelLauncher()
    {
        this.recoil = 25;
        this.damage = 30;
        this.rateOfFire = -35;
    }
}

