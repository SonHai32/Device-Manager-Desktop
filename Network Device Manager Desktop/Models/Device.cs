using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Device_Manager_Desktop.Models
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }

        public int DeviceQuantity { get; set; }

        public double DevicePrice { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
