using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Domains
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BlueButtonClick(object sender, RoutedEventArgs e)
        {
            var currentDomain = AppDomain.CurrentDomain;

            var fileDownloadingDomain = AppDomain.CreateDomain("FileDownloadingApp");

            var fileDownloadingAppPath = currentDomain.BaseDirectory + "FileDownloadApp.exe";

            fileDownloadingDomain.ExecuteAssembly(fileDownloadingAppPath);

            AppDomain.Unload(fileDownloadingDomain);
        }

        private void RedButtonClick(object sender, RoutedEventArgs e)
        {
            var currentDomain = AppDomain.CurrentDomain;

            var largeCalculationDomain = AppDomain.CreateDomain("LargeCalculationApp");

            var largeCalculationAppPath = currentDomain.BaseDirectory + "LargeCalculationsApp.exe";

            largeCalculationDomain.ExecuteAssembly(largeCalculationAppPath);

            AppDomain.Unload(largeCalculationDomain);
        }
    }
}
