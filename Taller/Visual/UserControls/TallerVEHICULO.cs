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
    public partial class TallerVEHICULO : UserControl, ITabMante
    {
        /// <summary>
        /// Objeto de Negocio responsable del tratamiento de las tarjetas
        /// </summary>
        public _ExtensionMante extensionMante;

        /// <summary>
        /// Inicializa un nueva instancia de la clase
        /// </summary>
        public TallerVEHICULO()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa un nueva instancia de la clase
        /// </summary>
        public TallerVEHICULO(_ExtensionMante _extensionMante)
        {
            InitializeComponent();

            extensionMante = _extensionMante;
        }

        /// <summary>
        /// Método para el enlace de controles y datos
        /// </summary>
        public void _Binding()
        {
            
        }

        /// <summary>
        /// Método para bloquear los controles del UserControl
        /// </summary>
        /// <param name="tlReadOnly"></param>
        public void _BloquearControles(bool tlReadOnly)
        {
         this.mantegridrev_vehiculo._ReadOnly = tlReadOnly;
   
        }

        /// <summary>
        /// Objeto del mantenimiento principal
        /// </summary>
        public ew.ewbase.ewMante _ewMante { get; set; }
        /// <summary>
        /// Objeto de Negocio asociado al usercontrol
        /// </summary>
        public ew.objetos.UserControls.Mantegrid mantegridrev_vehiculo;

        private void InitializeComponent()
        {


this.mantegridrev_vehiculo = new sage.ew.objetos.UserControls.Mantegrid();
                        this.SuspendLayout();
            // //
            // mantegridrev_vehiculo
            //
            this.mantegridrev_vehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.mantegridrev_vehiculo.Location = new System.Drawing.Point(0, 0);
            this.mantegridrev_vehiculo.Name = "mantegridrev_vehiculo";
            this.mantegridrev_vehiculo.Size = new System.Drawing.Size(511, 294);
            this.mantegridrev_vehiculo.TabIndex = 0;

            // TallerVEHICULO
            // 
            this.Name = "TallerVEHICULO";
            this.Size = new System.Drawing.Size(514, 297);
this.Controls.Add(this.mantegridrev_vehiculo);
                        this.ResumeLayout(false);


            





			
        }
		

    }
}
