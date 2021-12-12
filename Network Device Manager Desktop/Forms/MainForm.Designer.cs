namespace Network_Device_Manager_Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_data_grv = new System.Windows.Forms.Panel();
            this.grvDevice = new System.Windows.Forms.DataGridView();
            this.deviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDataStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeviceQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDevicePrice = new System.Windows.Forms.TextBox();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_data_grv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDevice)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1345, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEVICE LIST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_data_grv);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel_footer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 750);
            this.panel2.TabIndex = 1;
            // 
            // panel_data_grv
            // 
            this.panel_data_grv.BackColor = System.Drawing.Color.White;
            this.panel_data_grv.Controls.Add(this.grvDevice);
            this.panel_data_grv.Controls.Add(this.lblDataStatus);
            this.panel_data_grv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_data_grv.Location = new System.Drawing.Point(267, 0);
            this.panel_data_grv.Name = "panel_data_grv";
            this.panel_data_grv.Padding = new System.Windows.Forms.Padding(20);
            this.panel_data_grv.Size = new System.Drawing.Size(1078, 594);
            this.panel_data_grv.TabIndex = 2;
            // 
            // grvDevice
            // 
            this.grvDevice.AllowUserToAddRows = false;
            this.grvDevice.AllowUserToDeleteRows = false;
            this.grvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDevice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.grvDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceID,
            this.deviceName,
            this.deviceQuantity,
            this.devicePrice});
            this.grvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDevice.Location = new System.Drawing.Point(20, 20);
            this.grvDevice.Name = "grvDevice";
            this.grvDevice.ReadOnly = true;
            this.grvDevice.RowHeadersWidth = 51;
            this.grvDevice.RowTemplate.Height = 24;
            this.grvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDevice.Size = new System.Drawing.Size(1038, 554);
            this.grvDevice.TabIndex = 3;
            this.grvDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDevice_CellClick);
            // 
            // deviceID
            // 
            this.deviceID.DataPropertyName = "DeviceId";
            this.deviceID.HeaderText = "ID";
            this.deviceID.MinimumWidth = 6;
            this.deviceID.Name = "deviceID";
            this.deviceID.ReadOnly = true;
            // 
            // deviceName
            // 
            this.deviceName.DataPropertyName = "DeviceName";
            this.deviceName.HeaderText = "Name";
            this.deviceName.MinimumWidth = 6;
            this.deviceName.Name = "deviceName";
            this.deviceName.ReadOnly = true;
            // 
            // deviceQuantity
            // 
            this.deviceQuantity.DataPropertyName = "DeviceQuantity";
            this.deviceQuantity.HeaderText = "Quantity";
            this.deviceQuantity.MinimumWidth = 6;
            this.deviceQuantity.Name = "deviceQuantity";
            this.deviceQuantity.ReadOnly = true;
            // 
            // devicePrice
            // 
            this.devicePrice.DataPropertyName = "DevicePrice";
            this.devicePrice.HeaderText = "Price";
            this.devicePrice.MinimumWidth = 6;
            this.devicePrice.Name = "devicePrice";
            this.devicePrice.ReadOnly = true;
            // 
            // lblDataStatus
            // 
            this.lblDataStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataStatus.Font = new System.Drawing.Font("JetBrains Mono Medium", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataStatus.Location = new System.Drawing.Point(20, 20);
            this.lblDataStatus.Name = "lblDataStatus";
            this.lblDataStatus.Size = new System.Drawing.Size(1038, 554);
            this.lblDataStatus.TabIndex = 0;
            this.lblDataStatus.Text = "Loading ...";
            this.lblDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtDeviceId);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtDeviceName);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtDeviceQuantity);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txtDevicePrice);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 100, 20, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 594);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Device ID";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txtDeviceId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeviceId.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDeviceId.Enabled = false;
            this.txtDeviceId.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceId.Location = new System.Drawing.Point(23, 129);
            this.txtDeviceId.Multiline = true;
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.ReadOnly = true;
            this.txtDeviceId.Size = new System.Drawing.Size(216, 45);
            this.txtDeviceId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Device Name";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txtDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeviceName.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDeviceName.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(23, 206);
            this.txtDeviceName.Multiline = true;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(216, 45);
            this.txtDeviceName.TabIndex = 3;
            this.txtDeviceName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Device Quantity";
            // 
            // txtDeviceQuantity
            // 
            this.txtDeviceQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txtDeviceQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeviceQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDeviceQuantity.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceQuantity.Location = new System.Drawing.Point(23, 283);
            this.txtDeviceQuantity.Multiline = true;
            this.txtDeviceQuantity.Name = "txtDeviceQuantity";
            this.txtDeviceQuantity.Size = new System.Drawing.Size(216, 45);
            this.txtDeviceQuantity.TabIndex = 5;
            this.txtDeviceQuantity.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtDeviceQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeviceQuantity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Device Price";
            // 
            // txtDevicePrice
            // 
            this.txtDevicePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txtDevicePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevicePrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDevicePrice.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevicePrice.Location = new System.Drawing.Point(23, 360);
            this.txtDevicePrice.Multiline = true;
            this.txtDevicePrice.Name = "txtDevicePrice";
            this.txtDevicePrice.Size = new System.Drawing.Size(216, 45);
            this.txtDevicePrice.TabIndex = 7;
            this.txtDevicePrice.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtDevicePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDevicePrice_KeyPress);
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.White;
            this.panel_footer.Controls.Add(this.btnClear);
            this.panel_footer.Controls.Add(this.btnDelete);
            this.panel_footer.Controls.Add(this.btnUpdate);
            this.panel_footer.Controls.Add(this.btnAdd);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 594);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1345, 156);
            this.panel_footer.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(915, 47);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(216, 70);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(680, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 70);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(445, 47);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(216, 70);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(210, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(216, 70);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 850);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_data_grv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDevice)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_data_grv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeviceQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDevicePrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDataStatus;
        private System.Windows.Forms.DataGridView grvDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicePrice;
    }
}

