using System.Windows;
using WeaponMenu.Models.Decorators.Base;
using WeaponMenu.Models.Decorators;
using WeaponMenu.Models.Weapons;
using WeaponMenu.ViewModels;

namespace WeaponMenu
{
    public partial class MainWindow : Window
    {
        private readonly ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();    
            DataContext = viewModel;
        }

        private void SightCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.SightCreate();
        }

        private void SightCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.SightRemove();
        }




        private void SilincerCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.SilincerCreate();
        }

        private void SilincerCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.SilincerRemove();
        }




        private void DoubleMagazineCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.DoubleMagazineCreate();
        }

        private void DoubleMagazineCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.DoubleMagazineRemove();
        }




        private void WeaponButtCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            viewModel.WeaponButtCreate();
        }

        private void WeaponButtCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.WeaponButtRemove();
        }
    }
}
