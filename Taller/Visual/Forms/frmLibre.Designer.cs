namespace sage.addons.Taller.Visual.Forms
{
    partial class frmLibre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibre));
            this.txtvehiculo1 = new sage.addons.Taller.Visual.UserControls.txtvehiculo();
            this.txtconductores1 = new sage.addons.Taller.Visual.UserControls.txtconductores();
            this.lblPruebaLibre = new sage.ew.objetos.ewlabel();
            this.SuspendLayout();
            // 
            // txtvehiculo1
            // 
            this.txtvehiculo1._Alto_Despleg_Combo = 106;
            this.txtvehiculo1._Ancho_Despleg_Combo = 197;
            this.txtvehiculo1._AnchoCombo = 0;
            this.txtvehiculo1._Autoload_Mante_FirstValue = false;
            this.txtvehiculo1._CaracterAncho = ' ';
            this.txtvehiculo1._ColumnasMultiLine = ((System.Collections.Generic.Dictionary<string, int>)(resources.GetObject("txtvehiculo1._ColumnasMultiLine")));
            this.txtvehiculo1._Consultar_Usuario_Seleccion_Multiple = true;
            this.txtvehiculo1._CrearManteSiCodigoNoExiste = true;
            this.txtvehiculo1._DesactivarRespuestasAutomaticas = false;
            this.txtvehiculo1._DescripcionError = "";
            this.txtvehiculo1._DescripcionOpcional = null;
            this.txtvehiculo1._EditMode = false;
            this.txtvehiculo1._EsOpcionalConfigUser = false;
            this.txtvehiculo1._Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtvehiculo1._ListaTodosCodigos = ((System.Collections.Generic.List<string>)(resources.GetObject("txtvehiculo1._ListaTodosCodigos")));
            this.txtvehiculo1._MensajeNoSePuedeCrear = "El código no es válido.";
            this.txtvehiculo1._Mostrar_Mensaje = true;
            this.txtvehiculo1._PermitirConfigUser = true;
            this.txtvehiculo1._PermitirFiltradoAutomaticoTextoParcial = true;
            this.txtvehiculo1._Tipo_Visual = sage.ew.txtbox.UserControls.ewtxtcodlabel._Tipos_Visuales.Estandar;
            this.txtvehiculo1._UsuarioPermiteConfigUser = false;
            this.txtvehiculo1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtvehiculo1.Location = new System.Drawing.Point(25, 94);
            this.txtvehiculo1.Margin = new System.Windows.Forms.Padding(2);
            this.txtvehiculo1.Name = "txtvehiculo1";
            this.txtvehiculo1.Size = new System.Drawing.Size(330, 25);
            this.txtvehiculo1.TabIndex = 0;
            // 
            // txtconductores1
            // 
            this.txtconductores1._Alto_Despleg_Combo = 106;
            this.txtconductores1._Ancho_Despleg_Combo = 197;
            this.txtconductores1._AnchoCombo = 0;
            this.txtconductores1._Autoload_Mante_FirstValue = false;
            this.txtconductores1._CaracterAncho = ' ';
            this.txtconductores1._ColumnasMultiLine = ((System.Collections.Generic.Dictionary<string, int>)(resources.GetObject("txtconductores1._ColumnasMultiLine")));
            this.txtconductores1._Consultar_Usuario_Seleccion_Multiple = true;
            this.txtconductores1._CrearManteSiCodigoNoExiste = true;
            this.txtconductores1._DesactivarRespuestasAutomaticas = false;
            this.txtconductores1._DescripcionError = "";
            this.txtconductores1._DescripcionOpcional = null;
            this.txtconductores1._EditMode = false;
            this.txtconductores1._EsOpcionalConfigUser = false;
            this.txtconductores1._Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtconductores1._ListaTodosCodigos = ((System.Collections.Generic.List<string>)(resources.GetObject("txtconductores1._ListaTodosCodigos")));
            this.txtconductores1._MensajeNoSePuedeCrear = "El código no es válido.";
            this.txtconductores1._Mostrar_Mensaje = true;
            this.txtconductores1._PermitirConfigUser = true;
            this.txtconductores1._PermitirFiltradoAutomaticoTextoParcial = true;
            this.txtconductores1._Tipo_Visual = sage.ew.txtbox.UserControls.ewtxtcodlabel._Tipos_Visuales.Estandar;
            this.txtconductores1._UsuarioPermiteConfigUser = false;
            this.txtconductores1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtconductores1.Location = new System.Drawing.Point(25, 156);
            this.txtconductores1.Margin = new System.Windows.Forms.Padding(2);
            this.txtconductores1.Name = "txtconductores1";
            this.txtconductores1.Size = new System.Drawing.Size(330, 25);
            this.txtconductores1.TabIndex = 1;
            // 
            // lblPruebaLibre
            // 
            this.lblPruebaLibre._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.lblPruebaLibre.AutoSize = true;
            this.lblPruebaLibre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPruebaLibre.Location = new System.Drawing.Point(25, 29);
            this.lblPruebaLibre.Name = "lblPruebaLibre";
            this.lblPruebaLibre.Size = new System.Drawing.Size(82, 17);
            this.lblPruebaLibre.TabIndex = 2;
            this.lblPruebaLibre.Text = "Prueba Libre";
            // 
            // frmLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.lblPruebaLibre);
            this.Controls.Add(this.txtconductores1);
            this.Controls.Add(this.txtvehiculo1);
            this.Name = "frmLibre";
            this.Text = "frmLibre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.txtvehiculo txtvehiculo1;
        private UserControls.txtconductores txtconductores1;
        private ew.objetos.ewlabel lblPruebaLibre;
    }
}