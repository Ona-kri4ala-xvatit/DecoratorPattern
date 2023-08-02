using System.Windows;
using WeaponMenu.Models.Weapons;
using WeaponMenu.Models.Weapons.Base;

namespace WeaponMenu
{
    public partial class MainWindow : Window
    {
        public Weapon weapon { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            weapon = new Pistol();
            DataContext = weapon;
        }


    }
}
