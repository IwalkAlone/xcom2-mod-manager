using System.Windows;
using XCom2ModManager.Main;

namespace XCom2ModManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ModManagerViewModel vm;

        public MainWindow()
        {
            vm = new ModManagerViewModel();
            InitializeComponent();
        }

        public ModManagerViewModel ViewModel
        {
            get { return vm; }
            set { vm = value; }
        }
    }
}
