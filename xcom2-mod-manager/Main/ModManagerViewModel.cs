using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using xcom2_mod_manager.View.ViewModel;

namespace XCom2ModManager.Main
{
    public class ModManagerViewModel
    {
        private RelayCommand launchClickCommand;

        public string Title
        {
            get { return "XCOM2 Mod Manager"; }
        }

        private void LaunchClick(object sender)
        {
            MessageBox.Show("Launch click");
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
    }
}
