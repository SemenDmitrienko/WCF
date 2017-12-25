namespace CarClient
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxVendor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetCar = new System.Windows.Forms.Button();
            this.btnGetCar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(93, 13);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(203, 20);
            this.tbxId.TabIndex = 1;
            // 
            // tbxVendor
            // 
            this.tbxVendor.Location = new System.Drawing.Point(93, 36);
            this.tbxVendor.Name = "tbxVendor";
            this.tbxVendor.Size = new System.Drawing.Size(203, 20);
            this.tbxVendor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(93, 59);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(203, 20);
            this.tbxModel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(93, 82);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(203, 20);
            this.tbxYear.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetCar
            // 
            this.btnSetCar.Location = new System.Drawing.Point(93, 156);
            this.btnSetCar.Name = "btnSetCar";
            this.btnSetCar.Size = new System.Drawing.Size(75, 23);
            this.btnSetCar.TabIndex = 8;
            this.btnSetCar.Text = "Set Car";
            this.btnSetCar.UseVisualStyleBackColor = true;
            this.btnSetCar.Click += new System.EventHandler(this.btnSetCar_Click);
            // 
            // btnGetCar
            // 
            this.btnGetCar.Location = new System.Drawing.Point(174, 156);
            this.btnGetCar.Name = "btnGetCar";
            this.btnGetCar.Size = new System.Drawing.Size(75, 23);
            this.btnGetCar.TabIndex = 9;
            this.btnGetCar.Text = "Get Car";
            this.btnGetCar.UseVisualStyleBackColor = true;
            this.btnGetCar.Click += new System.EventHandler(this.btnGetCar_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxType
            // 
            this.cbxType.DisplayMember = "0";
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Passenger"});
            this.cbxType.Location = new System.Drawing.Point(94, 105);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(202, 21);
            this.cbxType.TabIndex = 11;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(93, 130);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(203, 20);
            this.tbxType.TabIndex = 13;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(13, 130);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 20);
            this.lblType.TabIndex = 12;
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 185);
            this.Controls.Add(this.tbxType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetCar);
            this.Controls.Add(this.btnSetCar);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxVendor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetCar;
        private System.Windows.Forms.Button btnGetCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label lblType;
    }
}