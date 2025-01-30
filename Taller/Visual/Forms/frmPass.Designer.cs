namespace sage.addons.Taller.Visual.Forms
{
    partial class frmPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPass));
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._oErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btDocCancelar1
            // 
            this.btDocCancelar1._PropiedadesDeEstilos._ColorUnderlineEntering = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this.btDocCancelar1._PropiedadesDeEstilos._ColorUnderlineSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btDocCancelar1.Image = ((System.Drawing.Image)(resources.GetObject("btDocCancelar1.Image")));
            this.btDocCancelar1.Location = new System.Drawing.Point(196, 123);
            this.btDocCancelar1.Click += new System.EventHandler(this.btDocCancelar1_Click);
            // 
            // btSalir1
            // 
            this.btSalir1._PropiedadesDeEstilos._ColorUnderlineEntering = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this.btSalir1._PropiedadesDeEstilos._ColorUnderlineSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btSalir1.Image = ((System.Drawing.Image)(resources.GetObject("btSalir1.Image")));
            this.btSalir1.Location = new System.Drawing.Point(-271, -37);
            this.btSalir1.Size = new System.Drawing.Size(99, 44);
            // 
            // btDocAceptar1
            // 
            this.btDocAceptar1._PropiedadesDeEstilos._ColorUnderlineEntering = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this.btDocAceptar1._PropiedadesDeEstilos._ColorUnderlineSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btDocAceptar1.Image = ((System.Drawing.Image)(resources.GetObject("btDocAceptar1.Image")));
            this.btDocAceptar1.Location = new System.Drawing.Point(71, 123);
            this.btDocAceptar1.Click += new System.EventHandler(this.btDocAceptar1_Click);
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(150, 22);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(166, 20);
            this.txtLicencia.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(150, 62);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(166, 20);
            this.txtPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Licencia";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(87, 65);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // frmPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 193);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLicencia);
            this.Name = "frmPass";
            this.Text = "frmPass";
            this.Controls.SetChildIndex(this.btSalir1, 0);
            this.Controls.SetChildIndex(this.btDocCancelar1, 0);
            this.Controls.SetChildIndex(this.btDocAceptar1, 0);
            this.Controls.SetChildIndex(this.txtLicencia, 0);
            this.Controls.SetChildIndex(this.txtPass, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Password, 0);
            ((System.ComponentModel.ISupportInitialize)(this._oErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
    }
}