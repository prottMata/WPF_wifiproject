using SimpleWifi;
using SimpleWifi.Win32;
using SimpleWifi.Win32.Interop;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new WifiViewModel();
            scanButton.Click += ScanButtonClick;
            //saveButton.Click += SaveButtonClick;
        }
        private void ScanButtonClick(object sender, RoutedEventArgs e)
        {
            Wifi wifi = new Wifi();
            List<AccessPoint> accessPoints = wifi.GetAccessPoints();
            foreach (AccessPoint ap in accessPoints)
            {
                wifiGrid.Items.Add(ap);
                nameWN.SetValue(UidProperty, ap.Name);
                signalWN.SetValue(UidProperty, ap.SignalStrength);
            }
            AccessPoint best = accessPoints[0];
            foreach (AccessPoint nw in accessPoints) 
            {
                if (nw.SignalStrength > best.SignalStrength)
                {
                    best = nw;
                }
            }
            bestSignal.Text = best.Name;
        }
        /*private void SaveButtonClick(object sender, RoutedEventArgs e) 
        {

        }*/


        /*private void CreateButton(string text, bool? dialogResult, bool isDefault, bool isCancel)
{
   Button button = new Button
   {
       Content = text,
       IsDefault = isDefault,
       IsCancel = isCancel
   };
}*/
    }
}