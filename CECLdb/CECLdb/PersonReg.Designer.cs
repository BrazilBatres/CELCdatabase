
namespace CECLdb
{
    partial class PersonReg
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblTelNumber = new System.Windows.Forms.Label();
            this.txtbTelNumber = new System.Windows.Forms.TextBox();
            this.bttnAddPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbName
            // 
            this.txtbName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbName.Location = new System.Drawing.Point(46, 76);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(439, 27);
            this.txtbName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 151);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Correo";
            // 
            // txtbEmail
            // 
            this.txtbEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbEmail.Location = new System.Drawing.Point(46, 191);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(439, 27);
            this.txtbEmail.TabIndex = 3;
            // 
            // lblTelNumber
            // 
            this.lblTelNumber.AutoSize = true;
            this.lblTelNumber.Location = new System.Drawing.Point(46, 271);
            this.lblTelNumber.Name = "lblTelNumber";
            this.lblTelNumber.Size = new System.Drawing.Size(67, 20);
            this.lblTelNumber.TabIndex = 4;
            this.lblTelNumber.Text = "Teléfono";
            // 
            // txtbTelNumber
            // 
            this.txtbTelNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbTelNumber.Location = new System.Drawing.Point(46, 309);
            this.txtbTelNumber.Name = "txtbTelNumber";
            this.txtbTelNumber.Size = new System.Drawing.Size(439, 27);
            this.txtbTelNumber.TabIndex = 5;
            // 
            // bttnAddPerson
            // 
            this.bttnAddPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAddPerson.Location = new System.Drawing.Point(369, 380);
            this.bttnAddPerson.Name = "bttnAddPerson";
            this.bttnAddPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnAddPerson.TabIndex = 6;
            this.bttnAddPerson.Text = "Agregar";
            this.bttnAddPerson.UseVisualStyleBackColor = false;
            // 
            // PersonReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnAddPerson);
            this.Controls.Add(this.txtbTelNumber);
            this.Controls.Add(this.lblTelNumber);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblName);
            this.Name = "PersonReg";
            this.Text = "PersonReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblTelNumber;
        private System.Windows.Forms.TextBox txtbTelNumber;
        private System.Windows.Forms.Button bttnAddPerson;
    }
}