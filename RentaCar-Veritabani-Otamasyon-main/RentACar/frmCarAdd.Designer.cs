﻿
namespace RentACar
{
    partial class frmCarAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbSeries = new System.Windows.Forms.ComboBox();
            this.cmbFuil = new System.Windows.Forms.ComboBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtlicenseplate = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtKilometer = new System.Windows.Forms.TextBox();
            this.txtRentAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnExit3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(19, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "Bmw",
            "Mercedes",
            "Tofaş",
            "Dacia",
            "Fiat"});
            this.cmbBrand.Location = new System.Drawing.Point(88, 34);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(127, 21);
            this.cmbBrand.TabIndex = 1;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // cmbSeries
            // 
            this.cmbSeries.FormattingEnabled = true;
            this.cmbSeries.Location = new System.Drawing.Point(88, 64);
            this.cmbSeries.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSeries.Name = "cmbSeries";
            this.cmbSeries.Size = new System.Drawing.Size(127, 21);
            this.cmbSeries.TabIndex = 1;
            // 
            // cmbFuil
            // 
            this.cmbFuil.FormattingEnabled = true;
            this.cmbFuil.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Lpg",
            "Benzin/lpg"});
            this.cmbFuil.Location = new System.Drawing.Point(88, 214);
            this.cmbFuil.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFuil.Name = "cmbFuil";
            this.cmbFuil.Size = new System.Drawing.Size(127, 21);
            this.cmbFuil.TabIndex = 1;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Boş",
            "Dolu",
            ""});
            this.cmbState.Location = new System.Drawing.Point(92, 278);
            this.cmbState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(123, 21);
            this.cmbState.TabIndex = 1;
            // 
            // txtlicenseplate
            // 
            this.txtlicenseplate.Location = new System.Drawing.Point(86, 2);
            this.txtlicenseplate.Margin = new System.Windows.Forms.Padding(2);
            this.txtlicenseplate.Name = "txtlicenseplate";
            this.txtlicenseplate.Size = new System.Drawing.Size(129, 20);
            this.txtlicenseplate.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(88, 109);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(127, 20);
            this.txtModel.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(88, 145);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(127, 20);
            this.txtColor.TabIndex = 2;
            // 
            // txtKilometer
            // 
            this.txtKilometer.Location = new System.Drawing.Point(88, 180);
            this.txtKilometer.Margin = new System.Windows.Forms.Padding(2);
            this.txtKilometer.Name = "txtKilometer";
            this.txtKilometer.Size = new System.Drawing.Size(127, 20);
            this.txtKilometer.TabIndex = 2;
            // 
            // txtRentAmount
            // 
            this.txtRentAmount.Location = new System.Drawing.Point(88, 248);
            this.txtRentAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentAmount.Name = "txtRentAmount";
            this.txtRentAmount.Size = new System.Drawing.Size(127, 20);
            this.txtRentAmount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ModelYıl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(19, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(16, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kilometre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(16, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(1, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kira Ücreti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(9, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Durumu";
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.Transparent;
            this.btnSave2.BackgroundImage = global::RentACar.Properties.Resources.pngegg__2_;
            this.btnSave2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.Location = new System.Drawing.Point(92, 310);
            this.btnSave2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(123, 80);
            this.btnSave2.TabIndex = 3;
            this.btnSave2.Text = "Kaydet";
            this.btnSave2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnExit3
            // 
            this.btnExit3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit3.BackgroundImage = global::RentACar.Properties.Resources.pngegg__5_;
            this.btnExit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit3.Location = new System.Drawing.Point(9, 467);
            this.btnExit3.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(56, 55);
            this.btnExit3.TabIndex = 3;
            this.btnExit3.UseVisualStyleBackColor = false;
            this.btnExit3.Click += new System.EventHandler(this.btnExit3_Click);
            // 
            // frmCarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(514, 550);
            this.Controls.Add(this.btnExit3);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.txtRentAmount);
            this.Controls.Add(this.txtKilometer);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtlicenseplate);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.cmbFuil);
            this.Controls.Add(this.cmbSeries);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCarAdd";
            this.Text = "frmCarAdd";
            this.Load += new System.EventHandler(this.frmCarAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbSeries;
        private System.Windows.Forms.ComboBox cmbFuil;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtlicenseplate;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtKilometer;
        private System.Windows.Forms.TextBox txtRentAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnExit3;
    }
}