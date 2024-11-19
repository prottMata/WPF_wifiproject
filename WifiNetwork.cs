using SimpleWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp1
{
    public class WifiNetwork
    {
        public WifiNetwork(string wifiName, uint wifiSignal) 
        {
            this.wifiName = wifiName;
            this.wifiSignal = wifiSignal;
        }
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string wifiName { get; set; }
        public uint wifiSignal { get; set; }

    }
}
