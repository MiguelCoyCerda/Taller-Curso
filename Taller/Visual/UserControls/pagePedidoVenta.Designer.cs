namespace sage.addons.Taller.Visual.UserControls
{
    partial class pagePedidoVenta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_receta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de receta:";
            // 
            // txt_receta
            // 
            this.txt_receta.Location = new System.Drawing.Point(23, 61);
            this.txt_receta.Name = "txt_receta";
            this.txt_receta.Size = new System.Drawing.Size(154, 20);
            this.txt_receta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pagePedidoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_receta);
            this.Controls.Add(this.label1);
            this.Name = "pagePedidoVenta";
            this.Size = new System.Drawing.Size(241, 173);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_receta;
        private System.Windows.Forms.Button button1;
    }
}
