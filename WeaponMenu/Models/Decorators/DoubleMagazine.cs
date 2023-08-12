﻿using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu.Models.Decorators;

public class DoubleMagazine : WeaponUpdate
{
    public DoubleMagazine(Weapon wrapper) : base(wrapper)
    {
        this.rateOfFire = 5;
    }
}