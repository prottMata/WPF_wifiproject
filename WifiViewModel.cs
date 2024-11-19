using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWifi;
using SimpleWifi.Win32;
using SimpleWifi.Win32.Interop;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

namespace WpfApp1
{
    public class WifiViewModel 
    {
        WifiNetworkContext db = new WifiNetworkContext();
        DbCommands? addCommand;
        public ObservableCollection<WifiNetwork> WifiNetworks { get; set; }
        public WifiViewModel()
        {
            db = new WifiNetworkContext();

            //Creates database if non created and perform migrations
            db.Database.Migrate();
            WifiNetworks = new ObservableCollection<WifiNetwork>();
            db.WifiNetworks.Load();
            WifiNetworks = db.WifiNetworks.Local.ToObservableCollection();
        }
        private WifiNetwork result;
        public WifiNetwork Result {  get { return result; } }

        public DbCommands AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new DbCommands((o) =>
                  {
                      db.WifiNetworks.Add(Result);
                      db.SaveChanges();
                  }));
            }
        }

        private void ScanButtonClick(object sender, RoutedEventArgs e)
        {
            Wifi wifi = new Wifi();
            IEnumerable<AccessPoint> accessPoints = wifi.GetAccessPoints();
            List<WifiNetwork> result = new List<WifiNetwork>(accessPoints.Count());
            foreach (AccessPoint ap in accessPoints)
            {
                //ap.Name = wi
                //result.Add(new WifiNetwork(ap.Name, ap.SignalStrength));
            }
            WifiNetwork best = result[0];
            foreach (WifiNetwork nw in result)
            {
                if (nw.wifiSignal > best.wifiSignal)
                {
                    best = nw;
                }
            }
        }
    }
}
