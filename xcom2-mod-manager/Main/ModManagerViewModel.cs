using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using xcom2_mod_manager.View.ViewModel;

namespace XCom2ModManager.Main
{
    [ImplementPropertyChanged]
    public class ModManagerViewModel
    {
        private RelayCommand launchClickCommand;
        private RelayCommand setXcomFolderCommand;
        private string xcomPath = "E:\\";

        public string Title
        {
            get { return "XCOM2 Mod Manager"; }
        }

        public string XcomPath
        {
            get { return xcomPath; }
            set { xcomPath = value; }
        }
    

        public ICommand LaunchClickCommand
        {
            get
            {
                if (launchClickCommand == null)
                {
                    launchClickCommand = new RelayCommand(s => LaunchClick(s));
                }
                return launchClickCommand;
            }
        }

        public ICommand SetXcomFolderCommand
        {
            get
            {
                if (setXcomFolderCommand == null)
                {
                    setXcomFolderCommand = new RelayCommand(s => SetXcomFolder(s));
                }
                return setXcomFolderCommand;
            }
        }

        private void SetXcomFolder(object sender)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                XcomPath = dialog.SelectedPath;
            }
        }

        private void LaunchClick(object sender)
        {
            System.Windows.MessageBox.Show("Launch click");
        }

    }
}
