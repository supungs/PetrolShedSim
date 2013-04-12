namespace PSS_POS
{
    partial class PosForm
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
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cnctBtn = new System.Windows.Forms.Button();
            this.txtPosId = new System.Windows.Forms.TextBox();
            this.lbl_posId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grppayment = new System.Windows.Forms.GroupBox();
            this.btnpay = new System.Windows.Forms.Button();
            this.txtpay = new System.Windows.Forms.TextBox();
            this.cmbofuel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpconn = new System.Windows.Forms.GroupBox();
            this.grppayment.SuspendLayout();
            this.grpconn.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flPanel.Location = new System.Drawing.Point(5, 5);
            this.flPanel.Name = "flPanel";
            this.flPanel.Padding = new System.Windows.Forms.Padding(5);
            this.flPanel.Size = new System.Drawing.Size(633, 396);
            this.flPanel.TabIndex = 0;
            // 
            // cnctBtn
            // 
            this.cnctBtn.Location = new System.Drawing.Point(122, 75);
            this.cnctBtn.Name = "cnctBtn";
            this.cnctBtn.Size = new System.Drawing.Size(100, 30);
            this.cnctBtn.TabIndex = 1;
            this.cnctBtn.Text = "Connect";
            this.cnctBtn.UseVisualStyleBackColor = true;
            this.cnctBtn.Click += new System.EventHandler(this.cnctBtn_Click);
            // 
            // txtPosId
            // 
            this.txtPosId.Location = new System.Drawing.Point(94, 20);
            this.txtPosId.Name = "txtPosId";
            this.txtPosId.Size = new System.Drawing.Size(100, 20);
            this.txtPosId.TabIndex = 2;
            this.txtPosId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosId_KeyPress);
            // 
            // lbl_posId
            // 
            this.lbl_posId.AutoSize = true;
            this.lbl_posId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_posId.Location = new System.Drawing.Point(8, 21);
            this.lbl_posId.Name = "lbl_posId";
            this.lbl_posId.Size = new System.Drawing.Size(53, 15);
            this.lbl_posId.TabIndex = 3;
            this.lbl_posId.Text = "POS ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grppayment
            // 
            this.grppayment.Controls.Add(this.btnpay);
            this.grppayment.Controls.Add(this.txtpay);
            this.grppayment.Controls.Add(this.cmbofuel);
            this.grppayment.Controls.Add(this.label2);
            this.grppayment.Controls.Add(this.label1);
            this.grppayment.Enabled = false;
            this.grppayment.Location = new System.Drawing.Point(645, 139);
            this.grppayment.Name = "grppayment";
            this.grppayment.Size = new System.Drawing.Size(241, 175);
            this.grppayment.TabIndex = 5;
            this.grppayment.TabStop = false;
            this.grppayment.Text = "Payments";
            // 
            // btnpay
            // 
            this.btnpay.Location = new System.Drawing.Point(122, 121);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(100, 30);
            this.btnpay.TabIndex = 4;
            this.btnpay.Text = " Record Payment";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // txtpay
            // 
            this.txtpay.Location = new System.Drawing.Point(94, 65);
            this.txtpay.Name = "txtpay";
            this.txtpay.Size = new System.Drawing.Size(121, 20);
            this.txtpay.TabIndex = 3;
            this.txtpay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpay_KeyPress);
            // 
            // cmbofuel
            // 
            this.cmbofuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbofuel.FormattingEnabled = true;
            this.cmbofuel.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.cmbofuel.Location = new System.Drawing.Point(94, 33);
            this.cmbofuel.Name = "cmbofuel";
            this.cmbofuel.Size = new System.Drawing.Size(121, 21);
            this.cmbofuel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fuel Type";
            // 
            // grpconn
            // 
            this.grpconn.Controls.Add(this.txtPosId);
            this.grpconn.Controls.Add(this.cnctBtn);
            this.grpconn.Controls.Add(this.lbl_posId);
            this.grpconn.Location = new System.Drawing.Point(645, 8);
            this.grpconn.Name = "grpconn";
            this.grpconn.Size = new System.Drawing.Size(240, 125);
            this.grpconn.TabIndex = 6;
            this.grpconn.TabStop = false;
            this.grpconn.Text = "Connection";
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 406);
            this.Controls.Add(this.grpconn);
            this.Controls.Add(this.grppayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flPanel);
            this.Name = "PosForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.grppayment.ResumeLayout(false);
            this.grppayment.PerformLayout();
            this.grpconn.ResumeLayout(false);
            this.grpconn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.Button cnctBtn;
        private System.Windows.Forms.TextBox txtPosId;
        private System.Windows.Forms.Label lbl_posId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grppayment;
        private System.Windows.Forms.TextBox txtpay;
        private System.Windows.Forms.ComboBox cmbofuel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.GroupBox grpconn;
    }
}

