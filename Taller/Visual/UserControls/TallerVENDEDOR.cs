using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

using sage.ew.interficies;
using sage.ew.ewbase;
using sage.ew.db;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Clase para añadir un control de usuario a una página de un mantenimiento
    /// </summary>
    public partial class TallerVENDEDOR : UserControl, ITabMante
    {
        /// <summary>
        /// Objeto de Negocio responsable del tratamiento de las tarjetas
        /// </summary>
        public _ExtensionMante extensionMante;

        /// <summary>
        /// Inicializa un nueva instancia de la clase
        /// </summary>
        public TallerVENDEDOR()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa un nueva instancia de la clase
        /// </summary>
        public TallerVENDEDOR(_ExtensionMante _extensionMante)
        {
            InitializeComponent();

            extensionMante = _extensionMante;
        }

        /// <summary>
        /// Método para el enlace de controles y datos
        /// </summary>
        public void _Binding()
        {
            if (ewtextboxNuevocampo1Taller.DataBindings["Text"] != null)
                ewtextboxNuevocampo1Taller.DataBindings[0].ReadValue();
            else
                ewtextboxNuevocampo1Taller.DataBindings.Add("Text", extensionMante, "_Nuevocampo1", true);

            if (ewtextboxNuevocampo2Taller.DataBindings["Text"] != null)
                ewtextboxNuevocampo2Taller.DataBindings[0].ReadValue();
            else
                ewtextboxNuevocampo2Taller.DataBindings.Add("Text", extensionMante, "_Nuevocampo2", true);

            
        }

        /// <summary>
        /// Método para bloquear los controles del UserControl
        /// </summary>
        /// <param name="tlReadOnly"></param>
        public void _BloquearControles(bool tlReadOnly)
        {
            ewtextboxNuevocampo1Taller.ReadOnly = tlReadOnly;
            ewtextboxNuevocampo2Taller.ReadOnly = tlReadOnly;
            
        }

        /// <summary>
        /// Objeto del mantenimiento principal
        /// </summary>
        public ew.ewbase.ewMante _ewMante { get; set; }

        private void InitializeComponent()
        {
            this.ewlabelNuevocampo1Taller = new sage.ew.objetos.ewlabel();
            this.ewtextboxNuevocampo1Taller = new sage.ew.objetos.ewtextbox();
            this.ewlabelNuevocampo2Taller = new sage.ew.objetos.ewlabel();
            this.ewtextboxNuevocampo2Taller = new sage.ew.objetos.ewtextbox();
            this.SuspendLayout();
            // 
            // ewlabelNuevocampo1Taller
            // 
            this.ewlabelNuevocampo1Taller._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewlabelNuevocampo1Taller.AutoSize = true;
            this.ewlabelNuevocampo1Taller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewlabelNuevocampo1Taller.Location = new System.Drawing.Point(37, 22);
            this.ewlabelNuevocampo1Taller.Name = "ewlabelNuevocampo1Taller";
            this.ewlabelNuevocampo1Taller.Size = new System.Drawing.Size(130, 21);
            this.ewlabelNuevocampo1Taller.TabIndex = 1;
            this.ewlabelNuevocampo1Taller.Text = "NUEVOCAMPO1:";
            // 
            // ewtextboxNuevocampo1Taller
            // 
            this.ewtextboxNuevocampo1Taller._CanChangeStyle = false;
            this.ewtextboxNuevocampo1Taller._DescripcionError = "";
            this.ewtextboxNuevocampo1Taller._DescripcionOpcional = null;
            this.ewtextboxNuevocampo1Taller._EditMode = false;
            this.ewtextboxNuevocampo1Taller._ErrorValidation = false;
            this.ewtextboxNuevocampo1Taller._EsOpcionalConfigUser = false;
            this.ewtextboxNuevocampo1Taller._NoMostrarTecladoTactil = false;
            this.ewtextboxNuevocampo1Taller._PasswordChar = '\0';
            this.ewtextboxNuevocampo1Taller._PermitirConfigUser = true;
            this.ewtextboxNuevocampo1Taller._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.ewtextboxNuevocampo1Taller._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ewtextboxNuevocampo1Taller._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewtextboxNuevocampo1Taller._SoloNumeros = false;
            this.ewtextboxNuevocampo1Taller._Tactil_Teclat_Numeric = false;
            this.ewtextboxNuevocampo1Taller._Tooltip = "";
            this.ewtextboxNuevocampo1Taller._UsuarioPermiteConfigUser = false;
            this.ewtextboxNuevocampo1Taller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewtextboxNuevocampo1Taller.Location = new System.Drawing.Point(183, 19);
            this.ewtextboxNuevocampo1Taller.MaxLength = 0;
            this.ewtextboxNuevocampo1Taller.Name = "ewtextboxNuevocampo1Taller";
            this.ewtextboxNuevocampo1Taller.Size = new System.Drawing.Size(283, 29);
            this.ewtextboxNuevocampo1Taller.TabIndex = 2;
            // 
            // ewlabelNuevocampo2Taller
            // 
            this.ewlabelNuevocampo2Taller._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewlabelNuevocampo2Taller.AutoSize = true;
            this.ewlabelNuevocampo2Taller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewlabelNuevocampo2Taller.Location = new System.Drawing.Point(37, 52);
            this.ewlabelNuevocampo2Taller.Name = "ewlabelNuevocampo2Taller";
            this.ewlabelNuevocampo2Taller.Size = new System.Drawing.Size(130, 21);
            this.ewlabelNuevocampo2Taller.TabIndex = 3;
            this.ewlabelNuevocampo2Taller.Text = "NUEVOCAMPO2:";
            // 
            // ewtextboxNuevocampo2Taller
            // 
            this.ewtextboxNuevocampo2Taller._CanChangeStyle = false;
            this.ewtextboxNuevocampo2Taller._DescripcionError = "";
            this.ewtextboxNuevocampo2Taller._DescripcionOpcional = null;
            this.ewtextboxNuevocampo2Taller._EditMode = false;
            this.ewtextboxNuevocampo2Taller._ErrorValidation = false;
            this.ewtextboxNuevocampo2Taller._EsOpcionalConfigUser = false;
            this.ewtextboxNuevocampo2Taller._NoMostrarTecladoTactil = false;
            this.ewtextboxNuevocampo2Taller._PasswordChar = '\0';
            this.ewtextboxNuevocampo2Taller._PermitirConfigUser = true;
            this.ewtextboxNuevocampo2Taller._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.ewtextboxNuevocampo2Taller._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ewtextboxNuevocampo2Taller._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewtextboxNuevocampo2Taller._SoloNumeros = false;
            this.ewtextboxNuevocampo2Taller._Tactil_Teclat_Numeric = false;
            this.ewtextboxNuevocampo2Taller._Tooltip = "";
            this.ewtextboxNuevocampo2Taller._UsuarioPermiteConfigUser = false;
            this.ewtextboxNuevocampo2Taller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewtextboxNuevocampo2Taller.Location = new System.Drawing.Point(183, 49);
            this.ewtextboxNuevocampo2Taller.MaxLength = 0;
            this.ewtextboxNuevocampo2Taller.Name = "ewtextboxNuevocampo2Taller";
            this.ewtextboxNuevocampo2Taller.Size = new System.Drawing.Size(283, 29);
            this.ewtextboxNuevocampo2Taller.TabIndex = 4;
            // 
            // TallerVENDEDOR
            // 
            this.Controls.Add(this.ewlabelNuevocampo1Taller);
            this.Controls.Add(this.ewtextboxNuevocampo1Taller);
            this.Controls.Add(this.ewlabelNuevocampo2Taller);
            this.Controls.Add(this.ewtextboxNuevocampo2Taller);
            this.Name = "TallerVENDEDOR";
            this.Size = new System.Drawing.Size(514, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		
        private sage.ew.objetos.ewlabel ewlabelNuevocampo1Taller;
        private sage.ew.objetos.ewtextbox ewtextboxNuevocampo1Taller;
        private sage.ew.objetos.ewlabel ewlabelNuevocampo2Taller;
        private sage.ew.objetos.ewtextbox ewtextboxNuevocampo2Taller;

    }
}
