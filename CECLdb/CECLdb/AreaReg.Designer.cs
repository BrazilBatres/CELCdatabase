﻿
namespace CECLdb
{
    partial class AreaReg
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.cmbAnnouncement = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblAreaName = new System.Windows.Forms.Label();
            this.txtbAreaName = new System.Windows.Forms.TextBox();
            this.bttnAddArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(43, 40);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 20);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Año";
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = true;
            this.lblAnnouncement.Location = new System.Drawing.Point(43, 141);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(97, 20);
            this.lblAnnouncement.TabIndex = 2;
            this.lblAnnouncement.Text = "Convocatoria";
            // 
            // cmbAnnouncement
            // 
            this.cmbAnnouncement.FormattingEnabled = true;
            this.cmbAnnouncement.Location = new System.Drawing.Point(43, 178);
            this.cmbAnnouncement.Name = "cmbAnnouncement";
            this.cmbAnnouncement.Size = new System.Drawing.Size(151, 28);
            this.cmbAnnouncement.TabIndex = 3;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(43, 76);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(151, 28);
            this.cmbYear.TabIndex = 4;
            // 
            // lblAreaName
            // 
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.Location = new System.Drawing.Point(43, 248);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(124, 20);
            this.lblAreaName.TabIndex = 5;
            this.lblAreaName.Text = "Nombre del Área";
            this.lblAreaName.Click += new System.EventHandler(this.lblAreaName_Click);
            // 
            // txtbAreaName
            // 
            this.txtbAreaName.Location = new System.Drawing.Point(43, 282);
            this.txtbAreaName.Name = "txtbAreaName";
            this.txtbAreaName.Size = new System.Drawing.Size(363, 27);
            this.txtbAreaName.TabIndex = 6;
            // 
            // bttnAddArea
            // 
            this.bttnAddArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddArea.Location = new System.Drawing.Point(357, 349);
            this.bttnAddArea.Name = "bttnAddArea";
            this.bttnAddArea.Size = new System.Drawing.Size(94, 30);
            this.bttnAddArea.TabIndex = 7;
            this.bttnAddArea.Text = "Agregar";
            this.bttnAddArea.UseVisualStyleBackColor = false;
            // 
            // AreaReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnAddArea);
            this.Controls.Add(this.txtbAreaName);
            this.Controls.Add(this.lblAreaName);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbAnnouncement);
            this.Controls.Add(this.lblAnnouncement);
            this.Controls.Add(this.lblYear);
            this.Name = "AreaReg";
            this.Text = "AreaReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAnnouncement;
        private System.Windows.Forms.ComboBox cmbAnnouncement;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.TextBox txtbAreaName;
        private System.Windows.Forms.Button bttnAddArea;
    }
}