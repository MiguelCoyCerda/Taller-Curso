namespace sage.addons.Taller.Visual.Forms
{
    partial class frmvehiculo
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
            this.tpPagina2 = new sage.ew.objetos.ewTabPage();
            this.tpPagina3 = new sage.ew.objetos.ewTabPage();
            this.ewlabelMatricula = new sage.ew.objetos.ewlabel();
            this.ewtextboxMatricula = new sage.ew.objetos.ewtextbox();
            this.ewlabelPma = new sage.ew.objetos.ewlabel();
            this.ewnumericupdownPma = new sage.ew.objetos.ewnumericupdown();
            this.ewlabelTara = new sage.ew.objetos.ewlabel();
            this.ewnumericupdownTara = new sage.ew.objetos.ewnumericupdown();
            this.lblObservaciones = new sage.ew.objetos.ewlabel();
            this.txtObservaciones = new sage.ew.objetos.ewtextbox();
            this.mantegridRevisiones = new sage.ew.objetos.UserControls.Mantegrid();
            this.ewtcCodigoNombre.SuspendLayout();
            this.tabPageCodigoNombre.SuspendLayout();
            this.ewtcPaginas.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this._oToolStripContainer.SuspendLayout();
            this.ewPanelTituloLineaDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._oErrorProvider)).BeginInit();
            this.tpPagina3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ewnumericupdownPma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewnumericupdownTara)).BeginInit();
            this.SuspendLayout();
            // 
            // _btBrowser
            // 
            this._btBrowser._PropiedadesDeEstilos._AplicarEstilos = false;
            this._btBrowser._PropiedadesDeEstilos._ColorUnderlineEntering = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this._btBrowser._PropiedadesDeEstilos._ColorUnderlineSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this._btBrowser._UsarExtensiones = sage.ew.enumerations.eUsarExtensionesBrowser.Default;
            this._btBrowser.FlatAppearance.BorderSize = 0;
            // 
            // ewtextboxNombre
            // 
            this.ewtextboxNombre._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.ewtextboxNombre._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ewtextboxNombre._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            // 
            // ewtextboxCodigo
            // 
            this.ewtextboxCodigo._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.ewtextboxCodigo._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ewtextboxCodigo._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            // 
            // ewtcCodigoNombre
            // 
            this.ewtcCodigoNombre._PropiedadesDeEstilos._ColorUnderlineEntering = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this.ewtcCodigoNombre._PropiedadesDeEstilos._ColorUnderlineSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewtcCodigoNombre.Size = new System.Drawing.Size(584, 120);
            // 
            // tabPageCodigoNombre
            // 
            this.tabPageCodigoNombre.Size = new System.Drawing.Size(576, 88);
            // 
            // ewtcPaginas
            // 
            this.ewtcPaginas._PropiedadesDeEstilos._ColorUnderlineEntering = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this.ewtcPaginas._PropiedadesDeEstilos._ColorUnderlineSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewtcPaginas.Controls.Add(this.tpPagina3);
            this.ewtcPaginas.Controls.Add(this.tpPagina2);
            this.ewtcPaginas.Size = new System.Drawing.Size(584, 373);
            this.ewtcPaginas.Controls.SetChildIndex(this.tpGeneral, 0);
            this.ewtcPaginas.Controls.SetChildIndex(this.tpPagina2, 0);
            this.ewtcPaginas.Controls.SetChildIndex(this.tpPagina3, 0);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.txtObservaciones);
            this.tpGeneral.Controls.Add(this.lblObservaciones);
            this.tpGeneral.Controls.Add(this.ewlabelMatricula);
            this.tpGeneral.Controls.Add(this.ewtextboxMatricula);
            this.tpGeneral.Controls.Add(this.ewlabelPma);
            this.tpGeneral.Controls.Add(this.ewnumericupdownPma);
            this.tpGeneral.Controls.Add(this.ewlabelTara);
            this.tpGeneral.Controls.Add(this.ewnumericupdownTara);
            this.tpGeneral.Size = new System.Drawing.Size(576, 341);
            this.tpGeneral.Text = "Detalles";
            // 
            // _oToolStripContainer
            // 
            // 
            // _oToolStripContainer.ContentPanel
            // 
            this._oToolStripContainer.ContentPanel.Size = new System.Drawing.Size(584, 545);
            this._oToolStripContainer.Size = new System.Drawing.Size(584, 545);
            // 
            // ewPanelTituloLineaDetalles
            // 
            // 
            // ewPanelTituloLineaDetalles._Panel
            // 
            this.ewPanelTituloLineaDetalles._Panel.Size = new System.Drawing.Size(411, 26);
            this.ewPanelTituloLineaDetalles.Size = new System.Drawing.Size(411, 26);
            // 
            // ewLinea1
            // 
            this.ewLinea1.Size = new System.Drawing.Size(425, 1);
            // 
            // tpPagina2
            // 
            this.tpPagina2.BackColor = System.Drawing.SystemColors.Control;
            this.tpPagina2.Font = new System.Drawing.Font("Arial", 9.5F);
            this.tpPagina2.Location = new System.Drawing.Point(4, 28);
            this.tpPagina2.Name = "tpPagina2";
            this.tpPagina2.Size = new System.Drawing.Size(629, 197);
            this.tpPagina2.TabIndex = 1;
            this.tpPagina2.Text = "Conductores";
            // 
            // tpPagina3
            // 
            this.tpPagina3.BackColor = System.Drawing.SystemColors.Control;
            this.tpPagina3.Controls.Add(this.mantegridRevisiones);
            this.tpPagina3.Font = new System.Drawing.Font("Arial", 9.5F);
            this.tpPagina3.Location = new System.Drawing.Point(4, 28);
            this.tpPagina3.Name = "tpPagina3";
            this.tpPagina3.Size = new System.Drawing.Size(576, 341);
            this.tpPagina3.TabIndex = 2;
            this.tpPagina3.Text = "Revisiones";
            // 
            // ewlabelMatricula
            // 
            this.ewlabelMatricula._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewlabelMatricula.AutoSize = true;
            this.ewlabelMatricula.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewlabelMatricula.Location = new System.Drawing.Point(37, 13);
            this.ewlabelMatricula.Name = "ewlabelMatricula";
            this.ewlabelMatricula.Size = new System.Drawing.Size(65, 17);
            this.ewlabelMatricula.TabIndex = 3;
            this.ewlabelMatricula.Text = "Matrícula:";
            // 
            // ewtextboxMatricula
            // 
            this.ewtextboxMatricula._CanChangeStyle = false;
            this.ewtextboxMatricula._DescripcionError = "";
            this.ewtextboxMatricula._DescripcionOpcional = null;
            this.ewtextboxMatricula._EditMode = false;
            this.ewtextboxMatricula._ErrorValidation = false;
            this.ewtextboxMatricula._EsOpcionalConfigUser = false;
            this.ewtextboxMatricula._NoMostrarTecladoTactil = false;
            this.ewtextboxMatricula._PasswordChar = '\0';
            this.ewtextboxMatricula._PermitirConfigUser = true;
            this.ewtextboxMatricula._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.ewtextboxMatricula._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ewtextboxMatricula._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewtextboxMatricula._SoloNumeros = false;
            this.ewtextboxMatricula._Tactil_Teclat_Numeric = false;
            this.ewtextboxMatricula._Tooltip = "";
            this.ewtextboxMatricula._UsuarioPermiteConfigUser = false;
            this.ewtextboxMatricula.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewtextboxMatricula.Location = new System.Drawing.Point(137, 10);
            this.ewtextboxMatricula.MaxLength = 0;
            this.ewtextboxMatricula.Name = "ewtextboxMatricula";
            this.ewtextboxMatricula.Size = new System.Drawing.Size(333, 24);
            this.ewtextboxMatricula.TabIndex = 4;
            // 
            // ewlabelPma
            // 
            this.ewlabelPma._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewlabelPma.AutoSize = true;
            this.ewlabelPma.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewlabelPma.Location = new System.Drawing.Point(37, 48);
            this.ewlabelPma.Name = "ewlabelPma";
            this.ewlabelPma.Size = new System.Drawing.Size(47, 17);
            this.ewlabelPma.TabIndex = 5;
            this.ewlabelPma.Text = "P.M.A.:";
            // 
            // ewnumericupdownPma
            // 
            this.ewnumericupdownPma._DescripcionError = "";
            this.ewnumericupdownPma._DescripcionOpcional = null;
            this.ewnumericupdownPma._EditMode = false;
            this.ewnumericupdownPma._ErrorValidation = false;
            this.ewnumericupdownPma._EsOpcionalConfigUser = false;
            this.ewnumericupdownPma._PermitirConfigUser = true;
            this.ewnumericupdownPma._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.ewnumericupdownPma._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ewnumericupdownPma._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewnumericupdownPma._ReadOnly = false;
            this.ewnumericupdownPma._SelectOnEntry = false;
            this.ewnumericupdownPma._Tooltip = "";
            this.ewnumericupdownPma._UsuarioPermiteConfigUser = false;
            this.ewnumericupdownPma.BackColor = System.Drawing.SystemColors.Window;
            this.ewnumericupdownPma.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewnumericupdownPma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ewnumericupdownPma.Location = new System.Drawing.Point(137, 45);
            this.ewnumericupdownPma.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ewnumericupdownPma.Name = "ewnumericupdownPma";
            this.ewnumericupdownPma.Size = new System.Drawing.Size(100, 24);
            this.ewnumericupdownPma.TabIndex = 6;
            this.ewnumericupdownPma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ewnumericupdownPma.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ewlabelTara
            // 
            this.ewlabelTara._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewlabelTara.AutoSize = true;
            this.ewlabelTara.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewlabelTara.Location = new System.Drawing.Point(270, 47);
            this.ewlabelTara.Name = "ewlabelTara";
            this.ewlabelTara.Size = new System.Drawing.Size(36, 17);
            this.ewlabelTara.TabIndex = 7;
            this.ewlabelTara.Text = "Tara:";
            // 
            // ewnumericupdownTara
            // 
            this.ewnumericupdownTara._DescripcionError = "";
            this.ewnumericupdownTara._DescripcionOpcional = null;
            this.ewnumericupdownTara._EditMode = false;
            this.ewnumericupdownTara._ErrorValidation = false;
            this.ewnumericupdownTara._EsOpcionalConfigUser = false;
            this.ewnumericupdownTara._PermitirConfigUser = true;
            this.ewnumericupdownTara._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.ewnumericupdownTara._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ewnumericupdownTara._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewnumericupdownTara._ReadOnly = false;
            this.ewnumericupdownTara._SelectOnEntry = false;
            this.ewnumericupdownTara._Tooltip = "";
            this.ewnumericupdownTara._UsuarioPermiteConfigUser = false;
            this.ewnumericupdownTara.BackColor = System.Drawing.SystemColors.Window;
            this.ewnumericupdownTara.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewnumericupdownTara.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ewnumericupdownTara.Location = new System.Drawing.Point(370, 44);
            this.ewnumericupdownTara.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ewnumericupdownTara.Name = "ewnumericupdownTara";
            this.ewnumericupdownTara.Size = new System.Drawing.Size(100, 24);
            this.ewnumericupdownTara.TabIndex = 8;
            this.ewnumericupdownTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ewnumericupdownTara.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lblObservaciones
            // 
            this.lblObservaciones._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblObservaciones.Location = new System.Drawing.Point(37, 102);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(97, 17);
            this.lblObservaciones.TabIndex = 9;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones._CanChangeStyle = false;
            this.txtObservaciones._DescripcionError = "";
            this.txtObservaciones._DescripcionOpcional = null;
            this.txtObservaciones._EditMode = false;
            this.txtObservaciones._ErrorValidation = false;
            this.txtObservaciones._EsOpcionalConfigUser = false;
            this.txtObservaciones._NoMostrarTecladoTactil = false;
            this.txtObservaciones._PasswordChar = '\0';
            this.txtObservaciones._PermitirConfigUser = true;
            this.txtObservaciones._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.txtObservaciones._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.txtObservaciones._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.txtObservaciones._SoloNumeros = false;
            this.txtObservaciones._Tactil_Teclat_Numeric = false;
            this.txtObservaciones._Tooltip = "";
            this.txtObservaciones._UsuarioPermiteConfigUser = false;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtObservaciones.Location = new System.Drawing.Point(40, 136);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(430, 155);
            this.txtObservaciones.TabIndex = 10;
            // 
            // mantegridRevisiones
            // 
            this.mantegridRevisiones._Anadir_Location = new System.Drawing.Point(0, 0);
            this.mantegridRevisiones._Anadir_Text = "Añadir";
            this.mantegridRevisiones._Anadir_Tooltip = "";
            this.mantegridRevisiones._Borrar_Location = new System.Drawing.Point(82, 221);
            this.mantegridRevisiones._Borrar_Text = "Borrar";
            this.mantegridRevisiones._Borrar_Tooltip = "";
            this.mantegridRevisiones._CurrentCel = null;
            this.mantegridRevisiones._Insertar_Text = "Insertar";
            this.mantegridRevisiones._Insertar_Tooltip = "";
            this.mantegridRevisiones._InsertarConIntro = true;
            this.mantegridRevisiones._ManteTRel = null;
            this.mantegridRevisiones._MostrarBrowMante = false;
            this.mantegridRevisiones._PrintTitle = null;
            this.mantegridRevisiones._ReadOnly = false;
            this.mantegridRevisiones._RecuadroVisible = true;
            this.mantegridRevisiones._Tactil = false;
            this.mantegridRevisiones._Texto_Borrar_Registro = "";
            this.mantegridRevisiones.Location = new System.Drawing.Point(8, 14);
            this.mantegridRevisiones.Name = "mantegridRevisiones";
            this.mantegridRevisiones.Size = new System.Drawing.Size(560, 308);
            this.mantegridRevisiones.TabIndex = 0;
            // 
            // frmvehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 578);
            this.Name = "frmvehiculo";
            this.Text = "Mantenimiento de vehículos";
            this.Controls.SetChildIndex(this._oToolStripContainer, 0);
            this.ewtcCodigoNombre.ResumeLayout(false);
            this.tabPageCodigoNombre.ResumeLayout(false);
            this.tabPageCodigoNombre.PerformLayout();
            this.ewtcPaginas.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this._oToolStripContainer.ResumeLayout(false);
            this._oToolStripContainer.PerformLayout();
            this.ewPanelTituloLineaDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._oErrorProvider)).EndInit();
            this.tpPagina3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ewnumericupdownPma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewnumericupdownTara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sage.ew.objetos.ewTabPage tpPagina2;
        private sage.ew.objetos.ewTabPage tpPagina3;
        private sage.ew.objetos.ewlabel ewlabelMatricula;
        private sage.ew.objetos.ewtextbox ewtextboxMatricula;
        private sage.ew.objetos.ewlabel ewlabelPma;
        private sage.ew.objetos.ewnumericupdown ewnumericupdownPma;
        private sage.ew.objetos.ewlabel ewlabelTara;
        private sage.ew.objetos.ewnumericupdown ewnumericupdownTara;
        private ew.objetos.ewtextbox txtObservaciones;
        private ew.objetos.ewlabel lblObservaciones;
        private ew.objetos.UserControls.Mantegrid mantegridRevisiones;
    }
}