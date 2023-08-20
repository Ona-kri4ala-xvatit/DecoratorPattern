using System.Windows;
using WeaponMenu.Models.Decorators;
using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Weapons;
using WeaponMenu.Models.Weapons.Base;
using WeaponMenu.ViewModels.Base;

namespace WeaponMenu.ViewModels
{
    public class ViewModel : Inpc
    {
        private Weapon rifle;

        public Weapon Rifle { get => rifle; set => OnPropertyChanged(out rifle, value); }

        public ViewModel()
        {
            Rifle = new Rifle();
        }

        #region Sight
        public void SightCreate(bool? is_checked)
        {
            if (Rifle != null && is_checked != null)
            {
                WeaponUpdate weaponUpdate = new Sight();
                Rifle = weaponUpdate.SetUpdate(Rifle);
            }
        }

        public void SightRemove()
        {
            if (Rifle is WeaponUpdate weaponUpdate)
            {
                Rifle = weaponUpdate.RemoveUpdate();
            }
            //Rifle = (Rifle as WeaponUpdate).RemoveUpdate();
        }
        #endregion

        #region Silincer
        public void SilincerCreate(bool? is_checked)
        {
            if (Rifle != null && is_checked != null)
            {
                WeaponUpdate weaponUpdate = new Silencer();
                Rifle = weaponUpdate.SetUpdate(Rifle);
            }
        }

        public void SilincerRemove()
        {
            if (Rifle is WeaponUpdate weaponUpdate)
            {
                Rifle = weaponUpdate.RemoveUpdate();
            }
        }
        #endregion

        #region DoubleMagazine
        public void DoubleMagazineCreate(bool? is_checked)
        {
            if (Rifle != null && is_checked != null)
            {
                WeaponUpdate weaponUpdate = new DoubleMagazine();
                Rifle = weaponUpdate.SetUpdate(Rifle);
            }
        }

        public void DoubleMagazineRemove()
        {
            if (Rifle is WeaponUpdate weaponUpdate)
            {
                Rifle = weaponUpdate.RemoveUpdate();
            }
        }
        #endregion

        #region  WeaponButt
        public void WeaponButtCreate(bool? is_checked)
        {
            if (Rifle != null && is_checked != null)
            {
                WeaponUpdate weaponUpdate = new WeaponButt();
                Rifle = weaponUpdate.SetUpdate(Rifle);
            } 
        }

        public void WeaponButtRemove()
        {
            if (Rifle is WeaponUpdate weaponUpdate)
            {
                Rifle = weaponUpdate.RemoveUpdate();
            }
        }
        #endregion

        #region Multi-ShotAccessoryUnderbarrelLauncher
        public void MultiShotAccessoryCreate(bool? is_checked)
        {
            if (Rifle != null && is_checked != null)
            {
                WeaponUpdate weaponUpdate = new MultiShotAccessoryUnderbarrelLauncher();
                Rifle = weaponUpdate.SetUpdate(Rifle);
            }
        }
        public void MultiShotAccessoryRemove()
        {
            if (Rifle is WeaponUpdate weaponUpdate)
            {
                Rifle = weaponUpdate.RemoveUpdate();
            }
        }
        #endregion

    }
}
