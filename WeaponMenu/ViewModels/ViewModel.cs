using System.Windows;
using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Decorators;
using WeaponMenu.Models.Weapons;
using WeaponMenu.Models.Weapons.Base;
using WeaponMenu.ViewModels.Base;

namespace WeaponMenu.ViewModels
{
    public class ViewModel : Inpc
    {
        /*
        private Weapon rifle;
        private Weapon smg;
        private Weapon minigun;
        private Weapon sniperRifle;
        */

        /*public Weapon Rifle { get; set; }
        public Weapon SMG { get; set; }
        public Weapon Minigun { get; set; }
        public Weapon SniperRifle { get; set; }*/

        private Weapon pistol;

        public Weapon Pistol { get => pistol; set => OnPropertyChanged(out pistol, value); }

        public ViewModel()
        {
            /*
            Rifle = new Rifle();
            SMG = new SMG();
            Minigun = new Minigun();
            SniperRifle = new SniperRifle();
            */

            Pistol = new Pistol();
        }

        #region Sight
        public void SightCreate()
        {
            WeaponUpdate weaponUpdate = new Sight();
            Pistol = weaponUpdate.SetUpdate(Pistol);
        }

        public void SightRemove() 
        {
            Pistol = (Pistol as WeaponUpdate).RemoveUpdate();
        }
        #endregion



        #region Silincer
        public void SilincerCreate()
        {
            WeaponUpdate weaponUpdate = new Silencer();
            Pistol = weaponUpdate.SetUpdate(Pistol);
        }

        public void SilincerRemove()
        {
            Pistol = (Pistol as WeaponUpdate).RemoveUpdate();
        }
        #endregion



        #region Double Magazine
        public void DoubleMagazineCreate()
        {
            WeaponUpdate weaponUpdate = new DoubleMagazine();
            Pistol = weaponUpdate.SetUpdate(Pistol);
        }

        public void DoubleMagazineRemove()
        {
            Pistol = (Pistol as WeaponUpdate).RemoveUpdate();
        }
        #endregion



        #region  Weapon Butt
        public void WeaponButtCreate()
        {
            WeaponUpdate weaponUpdate = new WeaponButt();
            Pistol = weaponUpdate.SetUpdate(Pistol);
        }

        public void WeaponButtRemove()
        {
            Pistol = (Pistol as WeaponUpdate).RemoveUpdate();
        }
        #endregion

    }
}
