using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using WeaponMenu.Models.Weapons;
using WeaponMenu.Models.Weapons.Base;
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

        private bool Is_checked(object sender)
        {
            if (sender is CheckBox checkBox)
            {
                return (bool)checkBox.IsChecked!;
            }
            else
            {
                throw new Exception("Conversion failed!");
            }
        }

        #region Sight
        private void SightCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                //bool? is_checked = Is_checked(sender);
                viewModel.SightCreate(Is_checked(sender));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void SightCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.SightRemove();
        }
        #endregion

        #region Silincer
        private void SilincerCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                viewModel.SilincerCreate(Is_checked(sender));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

        private void SilincerCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.SilincerRemove();
        }
        #endregion

        #region DoubleMagazine
        private void DoubleMagazineCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                viewModel.DoubleMagazineCreate(Is_checked(sender));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }

        private void DoubleMagazineCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.DoubleMagazineRemove();
        }
        #endregion

        #region WeaponButt
        private void WeaponButtCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                viewModel.WeaponButtCreate(Is_checked(sender));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void WeaponButtCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.WeaponButtRemove();
        }

        #endregion

        #region Multi-ShotAccessoryUnderbarrelLauncher
        private void MultiShotAccessory_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                //bool? is_checked = Is_checked(sender);
                viewModel.MultiShotAccessoryCreate(Is_checked(sender));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MultiShotAccessory_Unchecked(object sender, RoutedEventArgs e)
        {
            viewModel.MultiShotAccessoryRemove();
        }
        #endregion

    }
}
