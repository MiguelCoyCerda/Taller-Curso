using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

using sage.ew.interficies;
using sage.ew.ewbase;
using sage.ew.db;
using sage.ew.functions;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Clase para añadir un control de usuario a una página de un mantenimiento
    /// </summary>
    public partial class TallerARTICULO : UserControl, ITabMante
    {
        /// <summary>
        /// Objeto de Negocio responsable del tratamiento de las tarjetas
        /// </summary>
        public _ExtensionMante extensionMante;

        /// <summary>
        /// Inicializa un nueva instancia de la clase
        /// </summary>
        public TallerARTICULO()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa un nueva instancia de la clase
        /// </summary>
        public TallerARTICULO(_ExtensionMante _extensionMante)
        {
            InitializeComponent();

            extensionMante = _extensionMante;
        }

        /// <summary>
        /// Método para el enlace de controles y datos
        /// </summary>
        public void _Binding()
        {
            if (txtRevisionTaller.DataBindings["_Codigo"] != null)
                txtRevisionTaller.DataBindings[0].ReadValue();
            else
                txtRevisionTaller.DataBindings.Add("_Codigo", extensionMante, "_Revision", true);

            if (ewtextboxLibre1Taller.DataBindings["Text"] != null)
                ewtextboxLibre1Taller.DataBindings[0].ReadValue();
            else
                ewtextboxLibre1Taller.DataBindings.Add("Text", extensionMante, "_Libre1", true);

            if (ewtextboxLibre2Taller.DataBindings["Text"] != null)
                ewtextboxLibre2Taller.DataBindings[0].ReadValue();
            else
                ewtextboxLibre2Taller.DataBindings.Add("Text", extensionMante, "_Libre2", true);

            
        }

        /// <summary>
        /// Método para bloquear los controles del UserControl
        /// </summary>
        /// <param name="tlReadOnly"></param>
        public void _BloquearControles(bool tlReadOnly)
        {
            txtRevisionTaller._ReadOnly = tlReadOnly;
            ewtextboxLibre1Taller.ReadOnly = tlReadOnly;
            ewtextboxLibre2Taller.ReadOnly = tlReadOnly;
            
        }

        /// <summary>
        /// Objeto del mantenimiento principal
        /// </summary>
        public ew.ewbase.ewMante _ewMante { get; set; }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TallerARTICULO));
            this.ewlabelRevisionTaller = new sage.ew.objetos.ewlabel();
            this.txtRevisionTaller = new sage.addons.Taller.Visual.UserControls.txtrevision();
            this.ewlabelLibre1Taller = new sage.ew.objetos.ewlabel();
            this.ewtextboxLibre1Taller = new sage.ew.objetos.ewtextbox();
            this.ewlabelLibre2Taller = new sage.ew.objetos.ewlabel();
            this.ewtextboxLibre2Taller = new sage.ew.objetos.ewtextbox();
            this.ewbutton1 = new sage.ew.objetos.ewbutton();
            this.SuspendLayout();
            // 
            // ewlabelRevisionTaller
            // 
            this.ewlabelRevisionTaller._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewlabelRevisionTaller.AutoSize = true;
            this.ewlabelRevisionTaller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewlabelRevisionTaller.Location = new System.Drawing.Point(37, 79);
            this.ewlabelRevisionTaller.Name = "ewlabelRevisionTaller";
            this.ewlabelRevisionTaller.Size = new System.Drawing.Size(72, 21);
            this.ewlabelRevisionTaller.TabIndex = 1;
            this.ewlabelRevisionTaller.Text = "Revisión:";
            // 
            // txtRevisionTaller
            // 
            this.txtRevisionTaller._Alto_Despleg_Combo = 106;
            this.txtRevisionTaller._Ancho_Despleg_Combo = 197;
            this.txtRevisionTaller._AnchoCombo = 0;
            this.txtRevisionTaller._Autoload_Mante_FirstValue = false;
            this.txtRevisionTaller._CaracterAncho = ' ';
            this.txtRevisionTaller._ColumnasMultiLine = ((System.Collections.Generic.Dictionary<string, int>)(resources.GetObject("txtRevisionTaller._ColumnasMultiLine")));
            this.txtRevisionTaller._Consultar_Usuario_Seleccion_Multiple = true;
            this.txtRevisionTaller._CrearManteSiCodigoNoExiste = true;
            this.txtRevisionTaller._DesactivarRespuestasAutomaticas = false;
            this.txtRevisionTaller._DescripcionError = "";
            this.txtRevisionTaller._DescripcionOpcional = null;
            this.txtRevisionTaller._EditMode = false;
            this.txtRevisionTaller._EsOpcionalConfigUser = false;
            this.txtRevisionTaller._Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRevisionTaller._ListaTodosCodigos = ((System.Collections.Generic.List<string>)(resources.GetObject("txtRevisionTaller._ListaTodosCodigos")));
            this.txtRevisionTaller._MensajeNoSePuedeCrear = "El código no es válido.";
            this.txtRevisionTaller._Mostrar_Mensaje = true;
            this.txtRevisionTaller._PermitirConfigUser = true;
            this.txtRevisionTaller._PermitirFiltradoAutomaticoTextoParcial = true;
            this.txtRevisionTaller._Tipo_Visual = sage.ew.txtbox.UserControls.ewtxtcodlabel._Tipos_Visuales.Estandar;
            this.txtRevisionTaller._UsuarioPermiteConfigUser = false;
            this.txtRevisionTaller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRevisionTaller.Location = new System.Drawing.Point(137, 75);
            this.txtRevisionTaller.Margin = new System.Windows.Forms.Padding(2);
            this.txtRevisionTaller.Name = "txtRevisionTaller";
            this.txtRevisionTaller.Size = new System.Drawing.Size(355, 30);
            this.txtRevisionTaller.TabIndex = 2;
            // 
            // ewlabelLibre1Taller
            // 
            this.ewlabelLibre1Taller._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewlabelLibre1Taller.AutoSize = true;
            this.ewlabelLibre1Taller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewlabelLibre1Taller.Location = new System.Drawing.Point(37, 216);
            this.ewlabelLibre1Taller.Name = "ewlabelLibre1Taller";
            this.ewlabelLibre1Taller.Size = new System.Drawing.Size(61, 21);
            this.ewlabelLibre1Taller.TabIndex = 3;
            this.ewlabelLibre1Taller.Text = "LIBRE1:";
            this.ewlabelLibre1Taller.Visible = false;
            // 
            // ewtextboxLibre1Taller
            // 
            this.ewtextboxLibre1Taller._CanChangeStyle = false;
            this.ewtextboxLibre1Taller._DescripcionError = "";
            this.ewtextboxLibre1Taller._DescripcionOpcional = null;
            this.ewtextboxLibre1Taller._EditMode = false;
            this.ewtextboxLibre1Taller._ErrorValidation = false;
            this.ewtextboxLibre1Taller._EsOpcionalConfigUser = false;
            this.ewtextboxLibre1Taller._NoMostrarTecladoTactil = false;
            this.ewtextboxLibre1Taller._PasswordChar = '\0';
            this.ewtextboxLibre1Taller._PermitirConfigUser = true;
            this.ewtextboxLibre1Taller._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.ewtextboxLibre1Taller._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ewtextboxLibre1Taller._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewtextboxLibre1Taller._SoloNumeros = false;
            this.ewtextboxLibre1Taller._Tactil_Teclat_Numeric = false;
            this.ewtextboxLibre1Taller._Tooltip = "";
            this.ewtextboxLibre1Taller._UsuarioPermiteConfigUser = false;
            this.ewtextboxLibre1Taller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewtextboxLibre1Taller.Location = new System.Drawing.Point(137, 213);
            this.ewtextboxLibre1Taller.MaxLength = 0;
            this.ewtextboxLibre1Taller.Name = "ewtextboxLibre1Taller";
            this.ewtextboxLibre1Taller.Size = new System.Drawing.Size(100, 29);
            this.ewtextboxLibre1Taller.TabIndex = 4;
            this.ewtextboxLibre1Taller.Visible = false;
            // 
            // ewlabelLibre2Taller
            // 
            this.ewlabelLibre2Taller._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewlabelLibre2Taller.AutoSize = true;
            this.ewlabelLibre2Taller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewlabelLibre2Taller.Location = new System.Drawing.Point(37, 246);
            this.ewlabelLibre2Taller.Name = "ewlabelLibre2Taller";
            this.ewlabelLibre2Taller.Size = new System.Drawing.Size(61, 21);
            this.ewlabelLibre2Taller.TabIndex = 5;
            this.ewlabelLibre2Taller.Text = "LIBRE2:";
            this.ewlabelLibre2Taller.Visible = false;
            // 
            // ewtextboxLibre2Taller
            // 
            this.ewtextboxLibre2Taller._CanChangeStyle = false;
            this.ewtextboxLibre2Taller._DescripcionError = "";
            this.ewtextboxLibre2Taller._DescripcionOpcional = null;
            this.ewtextboxLibre2Taller._EditMode = false;
            this.ewtextboxLibre2Taller._ErrorValidation = false;
            this.ewtextboxLibre2Taller._EsOpcionalConfigUser = false;
            this.ewtextboxLibre2Taller._NoMostrarTecladoTactil = false;
            this.ewtextboxLibre2Taller._PasswordChar = '\0';
            this.ewtextboxLibre2Taller._PermitirConfigUser = true;
            this.ewtextboxLibre2Taller._PropiedadesDeEstilos._ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(148)))));
            this.ewtextboxLibre2Taller._PropiedadesDeEstilos._ColorBorderError = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ewtextboxLibre2Taller._PropiedadesDeEstilos._ColorBorderFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewtextboxLibre2Taller._SoloNumeros = false;
            this.ewtextboxLibre2Taller._Tactil_Teclat_Numeric = false;
            this.ewtextboxLibre2Taller._Tooltip = "";
            this.ewtextboxLibre2Taller._UsuarioPermiteConfigUser = false;
            this.ewtextboxLibre2Taller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewtextboxLibre2Taller.Location = new System.Drawing.Point(137, 243);
            this.ewtextboxLibre2Taller.MaxLength = 0;
            this.ewtextboxLibre2Taller.Name = "ewtextboxLibre2Taller";
            this.ewtextboxLibre2Taller.Size = new System.Drawing.Size(100, 29);
            this.ewtextboxLibre2Taller.TabIndex = 6;
            this.ewtextboxLibre2Taller.Visible = false;
            // 
            // ewbutton1
            // 
            this.ewbutton1._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewbutton1._PropiedadesDeEstilos._ColorUnderlineEntering = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this.ewbutton1._PropiedadesDeEstilos._ColorUnderlineSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.ewbutton1._Tooltip = "";
            this.ewbutton1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewbutton1.Location = new System.Drawing.Point(41, 128);
            this.ewbutton1.Name = "ewbutton1";
            this.ewbutton1.Size = new System.Drawing.Size(196, 33);
            this.ewbutton1.TabIndex = 7;
            this.ewbutton1.Text = "ejecutar proceso";
            this.ewbutton1.UseVisualStyleBackColor = true;
            this.ewbutton1.Click += new System.EventHandler(this.ewbutton1_Click);
            // 
            // TallerARTICULO
            // 
            this.Controls.Add(this.ewbutton1);
            this.Controls.Add(this.ewlabelRevisionTaller);
            this.Controls.Add(this.txtRevisionTaller);
            this.Controls.Add(this.ewlabelLibre1Taller);
            this.Controls.Add(this.ewtextboxLibre1Taller);
            this.Controls.Add(this.ewlabelLibre2Taller);
            this.Controls.Add(this.ewtextboxLibre2Taller);
            this.Name = "TallerARTICULO";
            this.Size = new System.Drawing.Size(514, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		
        private sage.ew.objetos.ewlabel ewlabelRevisionTaller;
        private sage.addons.Taller.Visual.UserControls.txtrevision txtRevisionTaller;
        private sage.ew.objetos.ewlabel ewlabelLibre1Taller;
        private sage.ew.objetos.ewtextbox ewtextboxLibre1Taller;
        private sage.ew.objetos.ewlabel ewlabelLibre2Taller;
        private ew.objetos.ewbutton ewbutton1;
        private sage.ew.objetos.ewtextbox ewtextboxLibre2Taller;

        private void ewbutton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRevisionTaller._Codigo))
            {
                string sql = $"insert into {DB.SQLDatabase("taller", "prueba")} (NUEVOCAMPO1) values ('{txtRevisionTaller._Codigo}')";
                bool ok = DB.SQLExec(sql);

                if (ok) {
                    FUNCTIONS._MessageBox("Proceso ejecurtado correctamente.");
                }
                else
                {
                    FUNCTIONS._MessageBox("Error al ejecutar el proceso.");
                }
            }
            else
            {

               FUNCTIONS._MessageBox("Debe seleccionar un código.");
            }                     
        }
    }
}
