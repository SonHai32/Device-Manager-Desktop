using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network_Device_Manager_Desktop.Models;
using System.Net.Http;

namespace Network_Device_Manager_Desktop.API
{
    public static class DeviceAPI
    {
        private static readonly string url = "http://localhost:44309/api/Device";

        public static async Task<IEnumerable<Device>> GetAll()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var reponse = await httpClient.GetAsync(url + "/Get");
                    string dataAsString = await reponse.Content.ReadAsStringAsync();
                    var deviceList = JsonConvert.DeserializeObject<IEnumerable<Device>>(dataAsString);
                    return deviceList;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<string> Add(Device device)
        {
            try
            {

                using (var httpClient = new HttpClient())
                {
                    var reponse = await httpClient.PostAsync(url + "/AddNew", new StringContent(device.ToString(), Encoding.UTF8, "application/json"));
                    string message = await reponse.Content.ReadAsStringAsync();
                    return message;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<string> Update(Device device)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var reponse = await httpClient.PutAsync(url + "/Update", new StringContent(device.ToString(), Encoding.UTF8, "application/json"));
                    string message = await reponse.Content.ReadAsStringAsync();
                    return message;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<string> Delete(IEnumerable<int> listID)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.SendAsync(new
                        HttpRequestMessage(HttpMethod.Delete, url + "/Delete")
                    {
                        Content =
                            new StringContent(
                                JsonConvert.SerializeObject(listID),
                                Encoding.UTF8,
                                "application/json"
                                )
                    });
                    string message = await response.Content.ReadAsStringAsync();
                    return message;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
