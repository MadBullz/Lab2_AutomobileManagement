
namespace AutomobileManagement
{
    partial class fUpdateCar
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
            this.mtxtPrice = new System.Windows.Forms.MaskedTextBox();
            this.cbManu = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtPrice
            // 
            this.mtxtPrice.Location = new System.Drawing.Point(156, 180);
            this.mtxtPrice.Mask = "00000";
            this.mtxtPrice.Name = "mtxtPrice";
            this.mtxtPrice.Size = new System.Drawing.Size(226, 27);
            this.mtxtPrice.TabIndex = 25;
            this.mtxtPrice.ValidatingType = typeof(int);
            // 
            // cbManu
            // 
            this.cbManu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManu.FormattingEnabled = true;
            this.cbManu.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Ford",
            "Honda Motor Company",
            "Hyundai",
            "Kia",
            "Suzuki",
            "Toyota"});
            this.cbManu.Location = new System.Drawing.Point(156, 136);
            this.cbManu.Name = "cbManu";
            this.cbManu.Size = new System.Drawing.Size(226, 28);
            this.cbManu.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(156, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(156, 225);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(226, 27);
            this.txtYear.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Released Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Manufacturer";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 27);
            this.txtName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Car Name";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(156, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(226, 27);
            this.txtID.TabIndex = 15;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(43, 48);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(50, 20);
            this.lbID.TabIndex = 14;
            this.lbID.Text = "Car ID";
            // 
            // fUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 364);
            this.Controls.Add(this.mtxtPrice);
            this.Controls.Add(this.cbManu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Name = "fUpdateCar";
            this.Text = "fUpdateCar";
            this.Load += new System.EventHandler(this.fUpdateCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtPrice;
        private System.Windows.Forms.ComboBox cbManu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
    }
}