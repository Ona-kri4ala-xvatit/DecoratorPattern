using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using WeaponMenu.Models.Decorators;
using WeaponMenu.Models.Weapons;
using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Weapon? pistol;
        private Weapon? rifle;
        private Weapon? smg;
        private Weapon? minigun;
        private Weapon? sniperRifle;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Weapon? Pistol
        {
            get => pistol;
            set
            {
                pistol = value;
                PropertyChanged?.Invoke(sender: this, new PropertyChangedEventArgs(nameof(Pistol)));
            }
        }

        public Weapon? Rifle { get; set; }
        public Weapon? SMG { get; set; }
        public Weapon? Minigun { get; set; }
        public Weapon? SniperRifle { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Pistol = new Pistol();
            Rifle = new Rifle();
            SMG = new SMG();
            Minigun = new Minigun();
            SniperRifle = new SniperRifle();

            DataContext = this;
        }

        #region Sight
        private void SightCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Pistol = new Sight(Pistol);
        }

        private void SightCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Pistol = new Pistol();
        }
        #endregion

        #region Silincer
        private void SilincerCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Pistol = new Silencer(Pistol);
        }

        private void SilincerCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Pistol = new Pistol();
        }
        #endregion

        #region Double Magazine
        private void DoubleMagazineCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Pistol = new DoubleMagazine(Pistol);
        }

        private void DoubleMagazineCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Pistol = new Pistol();
        }
        #endregion

        #region Weapon Butt
        private void WeaponButtCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Pistol = new WeaponButt(Pistol);
        }

        private void WeaponButtCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Pistol = new Pistol();
        }
        #endregion
    }
}
