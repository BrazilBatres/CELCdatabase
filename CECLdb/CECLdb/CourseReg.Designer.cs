﻿
namespace CECLdb
{
    partial class CourseReg
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
            this.lblSelectAreaCourse = new System.Windows.Forms.Label();
            this.cmbSelectArea = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtbCourseName = new System.Windows.Forms.TextBox();
            this.bttnAddCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectAreaCourse
            // 
            this.lblSelectAreaCourse.AutoSize = true;
            this.lblSelectAreaCourse.Location = new System.Drawing.Point(52, 64);
            this.lblSelectAreaCourse.Name = "lblSelectAreaCourse";
            this.lblSelectAreaCourse.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaCourse.TabIndex = 0;
            this.lblSelectAreaCourse.Text = "Área a la que pertenece";
            this.lblSelectAreaCourse.Click += new System.EventHandler(this.lblSelectArea_Click);
            // 
            // cmbSelectArea
            // 
            this.cmbSelectArea.FormattingEnabled = true;
            this.cmbSelectArea.Location = new System.Drawing.Point(52, 108);
            this.cmbSelectArea.Name = "cmbSelectArea";
            this.cmbSelectArea.Size = new System.Drawing.Size(367, 28);
            this.cmbSelectArea.TabIndex = 1;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(47, 202);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(128, 20);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Nombre del curso";
            // 
            // txtbCourseName
            // 
            this.txtbCourseName.Location = new System.Drawing.Point(52, 246);
            this.txtbCourseName.Name = "txtbCourseName";
            this.txtbCourseName.Size = new System.Drawing.Size(358, 27);
            this.txtbCourseName.TabIndex = 3;
            // 
            // bttnAddCourse
            // 
            this.bttnAddCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddCourse.Location = new System.Drawing.Point(351, 337);
            this.bttnAddCourse.Name = "bttnAddCourse";
            this.bttnAddCourse.Size = new System.Drawing.Size(108, 28);
            this.bttnAddCourse.TabIndex = 4;
            this.bttnAddCourse.Text = "Agregar";
            this.bttnAddCourse.UseVisualStyleBackColor = false;
            // 
            // CourseReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnAddCourse);
            this.Controls.Add(this.txtbCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.cmbSelectArea);
            this.Controls.Add(this.lblSelectAreaCourse);
            this.Name = "CourseReg";
            this.Text = "CourseReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAreaCourse;
        private System.Windows.Forms.ComboBox cmbSelectArea;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtbCourseName;
        private System.Windows.Forms.Button bttnAddCourse;
    }
}