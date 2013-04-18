namespace PSS_Manager
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnprice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfuel = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnprofit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fuelOrder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fuelLevel = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(418, 314);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fuel Type";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 100;
            // 
            // btnprice
            // 
            this.btnprice.Location = new System.Drawing.Point(192, 34);
            this.btnprice.Name = "btnprice";
            this.btnprice.Size = new System.Drawing.Size(75, 33);
            this.btnprice.TabIndex = 2;
            this.btnprice.Text = "Set";
            this.btnprice.UseVisualStyleBackColor = true;
            this.btnprice.Click += new System.EventHandler(this.btnprice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbfuel);
            this.groupBox2.Controls.Add(this.btnprice);
            this.groupBox2.Location = new System.Drawing.Point(441, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuel Price";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(67, 62);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 5;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fuel Type\r\n\r\nPrice";
            // 
            // cmbfuel
            // 
            this.cmbfuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfuel.FormattingEnabled = true;
            this.cmbfuel.Items.AddRange(new object[] {
            "Unleaded",
            "Diesel"});
            this.cmbfuel.Location = new System.Drawing.Point(67, 34);
            this.cmbfuel.Name = "cmbfuel";
            this.cmbfuel.Size = new System.Drawing.Size(100, 21);
            this.cmbfuel.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncust);
            this.groupBox3.Controls.Add(this.btnprofit);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.fuelOrder);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.fuelLevel);
            this.groupBox3.Location = new System.Drawing.Point(441, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 184);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reports";
            // 
            // btnprofit
            // 
            this.btnprofit.Location = new System.Drawing.Point(192, 31);
            this.btnprofit.Name = "btnprofit";
            this.btnprofit.Size = new System.Drawing.Size(74, 33);
            this.btnprofit.TabIndex = 6;
            this.btnprofit.Text = "Profit";
            this.btnprofit.UseVisualStyleBackColor = true;
            this.btnprofit.Click += new System.EventHandler(this.btnprofit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sales";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fuelOrder
            // 
            this.fuelOrder.Location = new System.Drawing.Point(99, 31);
            this.fuelOrder.Name = "fuelOrder";
            this.fuelOrder.Size = new System.Drawing.Size(74, 33);
            this.fuelOrder.TabIndex = 5;
            this.fuelOrder.Text = "Fuel Orders";
            this.fuelOrder.UseVisualStyleBackColor = true;
            this.fuelOrder.Click += new System.EventHandler(this.fuelOrder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // fuelLevel
            // 
            this.fuelLevel.Location = new System.Drawing.Point(6, 31);
            this.fuelLevel.Name = "fuelLevel";
            this.fuelLevel.Size = new System.Drawing.Size(75, 33);
            this.fuelLevel.TabIndex = 3;
            this.fuelLevel.Text = "Fuel Levels";
            this.fuelLevel.UseVisualStyleBackColor = true;
            this.fuelLevel.Click += new System.EventHandler(this.fuelLevel_Click);
            // 
            // btncust
            // 
            this.btncust.Location = new System.Drawing.Point(6, 145);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(75, 33);
            this.btncust.TabIndex = 5;
            this.btncust.Text = "Customers";
            this.btncust.UseVisualStyleBackColor = true;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 334);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnprice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbfuel;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnprofit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button fuelOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button fuelLevel;
        private System.Windows.Forms.Button btncust;
    }
}

