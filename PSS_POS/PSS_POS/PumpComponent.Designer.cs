namespace PSS_POS
{
    partial class PumpComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_pumpid = new System.Windows.Forms.Label();
            this.lbl_fueltype = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.clsbtn = new System.Windows.Forms.Button();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_pumpid
            // 
            this.lbl_pumpid.AutoSize = true;
            this.lbl_pumpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pumpid.Location = new System.Drawing.Point(8, 5);
            this.lbl_pumpid.Name = "lbl_pumpid";
            this.lbl_pumpid.Size = new System.Drawing.Size(51, 16);
            this.lbl_pumpid.TabIndex = 0;
            this.lbl_pumpid.Text = "label1";
            // 
            // lbl_fueltype
            // 
            this.lbl_fueltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fueltype.Location = new System.Drawing.Point(24, 37);
            this.lbl_fueltype.Name = "lbl_fueltype";
            this.lbl_fueltype.Size = new System.Drawing.Size(143, 23);
            this.lbl_fueltype.TabIndex = 1;
            this.lbl_fueltype.Tag = "";
            this.lbl_fueltype.Text = "Fuel Type: Petrol";
            this.lbl_fueltype.Click += new System.EventHandler(this.lbl_fueltype_Click);
            // 
            // lbl_amount
            // 
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(173, 37);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(192, 23);
            this.lbl_amount.TabIndex = 2;
            this.lbl_amount.Tag = "";
            this.lbl_amount.Text = "Pumped Amount: 100 ltrs";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(24, 72);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(197, 23);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Tag = "";
            this.lbl_status.Text = "Status: ";
            // 
            // clsbtn
            // 
            this.clsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clsbtn.Location = new System.Drawing.Point(568, 8);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(24, 23);
            this.clsbtn.TabIndex = 4;
            this.clsbtn.Text = "X";
            this.clsbtn.UseVisualStyleBackColor = true;
            this.clsbtn.Visible = false;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            // 
            // lbl_cost
            // 
            this.lbl_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.Location = new System.Drawing.Point(371, 37);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(180, 23);
            this.lbl_cost.TabIndex = 5;
            this.lbl_cost.Tag = "";
            this.lbl_cost.Text = "Cost: $100";
            // 
            // PumpComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.clsbtn);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_fueltype);
            this.Controls.Add(this.lbl_pumpid);
            this.MaximumSize = new System.Drawing.Size(600, 100);
            this.MinimumSize = new System.Drawing.Size(600, 100);
            this.Name = "PumpComponent";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(600, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pumpid;
        private System.Windows.Forms.Label lbl_fueltype;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button clsbtn;
        private System.Windows.Forms.Label lbl_cost;
    }
}
