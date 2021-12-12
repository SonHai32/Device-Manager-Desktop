using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Network_Device_Manager_Desktop.API;
using Network_Device_Manager_Desktop.Models;
using Network_Device_Manager_Desktop.Utils;

namespace Network_Device_Manager_Desktop
{
    public partial class Form1 : Form
    {

        private readonly string URI = "http://localhost:44309/deviceHub";
        private HubConnection hubConnection;

        public Form1()
        {
            InitializeComponent();
            this.toggleUi();
            this.InitHubConnection();
        }

        private async void InitHubConnection()
        {
            hubConnection = new HubConnectionBuilder().WithUrl(URI).WithAutomaticReconnect().Build();

            hubConnection.Closed += (error) =>
            {

                this.Invoke((Action)(() =>
                {
                    toggleUi();
                    MessageBox.Show(error.Message);
                }));

                return this.hubConnection.StartAsync();

            };



            // Handle action change from hub server
            hubConnection.On<string, string>("DEVICE_CHANGED", (user, message) =>
            {
                this.Invoke((Action)(() => { this.getDeviceList(); }));
            });


            // Handle UI while hub is reconnecting
            hubConnection.Reconnecting += err =>
           {
               this.Invoke((Action)(() =>
               {
                   MessageBox.Show(err.Message);
                   this.toggleUi();
               }));
               return Task.CompletedTask; // always return this
           };


            // Handle Hub if reconnected 
            hubConnection.Reconnected += x =>
            {
                this.Invoke((Action)(() =>
                {
                    this.getDeviceList();

                }));
                return Task.CompletedTask; // always return this
            };


            try
            {
                await hubConnection.StartAsync();
                Console.WriteLine("Device hub connected");
                this.getDeviceList();
                this.toggleUi(true);
            }
            catch (Exception ex)
            {
                this.toggleUi();
                MessageBox.Show(ex.Message);
            }


        }

        private void setDeviceDataGrv(IEnumerable<Device> devices)
        {
            this.grvDevice.DataSource = devices;
            this.grvDevice.Refresh();
        }

        private async void getDeviceList()
        {
            try
            {
                this.toggleUi();
                this.grvDevice.Visible = false;
                var data = await DeviceAPI.GetAll();
                if (data != null)
                {
                    this.grvDevice.Visible = true;
                    this.setDeviceDataGrv(data);
                    this.toggleUi(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grvDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }
            Device dv = (Device)this.grvDevice.Rows[e.RowIndex].DataBoundItem;
            if (dv != null)
            {
                this.btnDelete.Enabled = true;
                this.setInputForm(dv);
            }
            else
            {
                this.btnDelete.Enabled = false;
            }

        }

        private void setInputForm(Device dv)
        {

            this.toggleUi(true);
            this.txtDeviceId.Text = dv.DeviceId.ToString();
            this.txtDeviceName.Text = dv.DeviceName;
            this.txtDeviceQuantity.Text = dv.DeviceQuantity.ToString();
            this.txtDevicePrice.Text = dv.DevicePrice.ToString();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            this.btnUpdate.Enabled = true;
        }

        private void txtDeviceQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Device quantity is typeof int => ignore all char is not a number
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtDevicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clearInputForm()
        {

            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            this.txtDeviceId.Text = "";
            this.txtDeviceName.Text = "";
            this.txtDeviceQuantity.Text = "";
            this.txtDevicePrice.Text = "";
        }

        private void toggleUi(bool status = false)
        {
            this.grvDevice.Visible = status;
            this.txtDeviceName.Enabled = status;
            this.txtDevicePrice.Enabled = status;
            this.txtDeviceQuantity.Enabled = status;

            this.btnAdd.Enabled = status;
            this.btnUpdate.Enabled = status;
            this.btnClear.Enabled = status;
            this.btnDelete.Enabled = status;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearInputForm();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Device device = GetDeviceInputForm(true);

                if (device != null)
                {
                    await DeviceAPI.Add(device);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Device GetDeviceInputForm(bool isNew)
        {
            string DeviceName = this.txtDeviceName.Text;
            string DeviceQuantity = this.txtDeviceQuantity.Text;
            string DevicePrice = this.txtDevicePrice.Text;

            StringValidate v = new StringValidate();

            if (!(DeviceName != ""))
            {
                MessageBox.Show("Device name can't be null");
            }
            else if (!(DeviceQuantity != ""))
            {
                MessageBox.Show("Device Quantity can't null");
            }
            else if (!(DevicePrice != ""))
            {
                MessageBox.Show("Device Price can't null");
            }
            else if (!v.IsInteger(DeviceQuantity))
            {
                MessageBox.Show("Device Quantity must be an interger");
            }
            else if (!v.IsFloat(DevicePrice))
            {
                MessageBox.Show("Device Price must be a float");
            }
            else if (!v.GreaterThan(Double.Parse(DevicePrice), -1))
            {
                MessageBox.Show("Device Price must be greater than -1");
            }
            else if (!v.GreaterThan(Double.Parse(DeviceQuantity), -1))
            {
                MessageBox.Show("Device Quantity must be greater than -1");
            }

            else
            {
                if (isNew)
                {
                    return new Device()
                    {
                        DeviceName = DeviceName,
                        DeviceQuantity = int.Parse(DeviceQuantity),
                        DevicePrice = double.Parse(DevicePrice)
                    };
                }
                return new Device()
                {
                    DeviceId = int.Parse(this.txtDeviceId.Text),
                    DeviceName = DeviceName,
                    DeviceQuantity = int.Parse(DeviceQuantity),
                    DevicePrice = double.Parse(DevicePrice)
                };

            }
            return null;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var seletedRows = this.grvDevice.SelectedRows
                                .OfType<DataGridViewRow>()
                                .Where(row => !row.IsNewRow)
                                .Select(r => ((Device)r.DataBoundItem).DeviceId);

                await DeviceAPI.Delete(seletedRows);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Device device = GetDeviceInputForm(false);

                if (device != null)
                {
                    await DeviceAPI.Update(device);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
