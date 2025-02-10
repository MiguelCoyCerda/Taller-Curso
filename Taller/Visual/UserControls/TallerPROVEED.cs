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
using sage.ew.listados.Listados;
using sage.ew.cliente;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Clase para añadir un control de usuario a una página de un mantenimiento
    /// </summary>
    public partial class TallerPROVEED : UserControl, ITabMante
    {
        /// <summary>
        /// Objeto de Negocio responsable del tratamiento de las tarjetas
        /// </summary>
        public _ExtensionMante extensionMante;

        /// <summary>
        /// Inicializa un nueva instancia de la clase
        /// </summary>
        public TallerPROVEED()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa un nueva instancia de la clase
        /// </summary>
        public TallerPROVEED(_ExtensionMante _extensionMante)
        {
            InitializeComponent();

            extensionMante = _extensionMante;
        }

        /// <summary>
        /// Método para el enlace de controles y datos
        /// </summary>
        public void _Binding()
        {
            if (txtClienteTaller.DataBindings["_Codigo"] != null)
                txtClienteTaller.DataBindings[0].ReadValue();
            else
                txtClienteTaller.DataBindings.Add("_Codigo", extensionMante, "_Cliente", true);

            
        }

        /// <summary>
        /// Método para bloquear los controles del UserControl
        /// </summary>
        /// <param name="tlReadOnly"></param>
        public void _BloquearControles(bool tlReadOnly)
        {
            txtClienteTaller._ReadOnly = tlReadOnly;
            
        }

        /// <summary>
        /// Objeto del mantenimiento principal
        /// </summary>
        public ew.ewbase.ewMante _ewMante { get; set; }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TallerPROVEED));
            this.ewlabelClienteTaller = new sage.ew.objetos.ewlabel();
            this.txtClienteTaller = new sage.ew.txtbox.UserControls.txtCliente();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ewlabelClienteTaller
            // 
            this.ewlabelClienteTaller._Localizacion = sage.ew.interficies.LocalizacionOpcion.Bottom;
            this.ewlabelClienteTaller.AutoSize = true;
            this.ewlabelClienteTaller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ewlabelClienteTaller.Location = new System.Drawing.Point(26, 62);
            this.ewlabelClienteTaller.Name = "ewlabelClienteTaller";
            this.ewlabelClienteTaller.Size = new System.Drawing.Size(71, 21);
            this.ewlabelClienteTaller.TabIndex = 1;
            this.ewlabelClienteTaller.Text = "CLIENTE:";
            // 
            // txtClienteTaller
            // 
            this.txtClienteTaller._Alto_Despleg_Combo = 106;
            this.txtClienteTaller._Ancho_Despleg_Combo = 197;
            this.txtClienteTaller._AnchoCombo = 0;
            this.txtClienteTaller._Autoload_Mante_FirstValue = false;
            this.txtClienteTaller._CaracterAncho = ' ';
            this.txtClienteTaller._ColumnasMultiLine = ((System.Collections.Generic.Dictionary<string, int>)(resources.GetObject("txtClienteTaller._ColumnasMultiLine")));
            this.txtClienteTaller._Consultar_Usuario_Seleccion_Multiple = true;
            this.txtClienteTaller._CrearManteSiCodigoNoExiste = true;
            this.txtClienteTaller._DesactivarRespuestasAutomaticas = false;
            this.txtClienteTaller._DescripcionError = "";
            this.txtClienteTaller._DescripcionOpcional = null;
            this.txtClienteTaller._Documento = null;
            this.txtClienteTaller._EditMode = false;
            this.txtClienteTaller._EsOpcionalConfigUser = false;
            this.txtClienteTaller._Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtClienteTaller._ListaTodosCodigos = ((System.Collections.Generic.List<string>)(resources.GetObject("txtClienteTaller._ListaTodosCodigos")));
            this.txtClienteTaller._MensajeNoSePuedeCrear = "El código no es válido.";
            this.txtClienteTaller._Mostrar_Mensaje = true;
            this.txtClienteTaller._PermitirConfigUser = true;
            this.txtClienteTaller._PermitirFiltradoAutomaticoTextoParcial = true;
            this.txtClienteTaller._Tipo_Visual = sage.ew.txtbox.UserControls.ewtxtcodlabel._Tipos_Visuales.Estandar;
            this.txtClienteTaller._UsuarioPermiteConfigUser = false;
            this.txtClienteTaller.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtClienteTaller.Location = new System.Drawing.Point(126, 59);
            this.txtClienteTaller.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteTaller.Name = "txtClienteTaller";
            this.txtClienteTaller.Size = new System.Drawing.Size(318, 30);
            this.txtClienteTaller.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Asignar proveedor a cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TallerPROVEED
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ewlabelClienteTaller);
            this.Controls.Add(this.txtClienteTaller);
            this.Name = "TallerPROVEED";
            this.Size = new System.Drawing.Size(514, 297);
            this.Load += new System.EventHandler(this.TallerPROVEED_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		
        private sage.ew.objetos.ewlabel ewlabelClienteTaller;
        private Button button1;
        private sage.ew.txtbox.UserControls.txtCliente txtClienteTaller;

        private void button1_Click(object sender, EventArgs e)
        {
           Cliente ocliente = new Cliente();
           ocliente._Codigo = txtClienteTaller._Codigo;
            ocliente._Observaciones = "Proveedor asignado";
            bool ok =ocliente._Save();
            if (ok)
            {

               FUNCTIONS._MessageBox("Proveedor asignado correctamente");
            }
            else
            {
                FUNCTIONS._MessageBox("Error al asignar proveedor");
            }


        }

        private void TallerPROVEED_Load(object sender, EventArgs e)
        {
            FUNCTIONS._MessageBox("Cargado");
        }
    }
}
