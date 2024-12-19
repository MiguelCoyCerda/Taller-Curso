using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sage.ew.formul.Forms;

namespace sage.addons.Taller.Visual.Forms
{
    public partial class frmrevision : FormMante
    {
	    /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public frmrevision()
        {
            InitializeComponent();
        }
		
        /// <summary>
        /// Bindear objetos específicos
        /// </summary>
        protected override void _Binding()
        {
            base._Binding();

            if (ewtextboxObservaciones.DataBindings["Text"] != null)
                ewtextboxObservaciones.DataBindings[0].ReadValue();
            else
                ewtextboxObservaciones.DataBindings.Add("Text", _ewMante, "_Observaciones", true);

            if (txtVehiculo.DataBindings["_Codigo"] != null)
                txtVehiculo.DataBindings[0].ReadValue();
            else
                txtVehiculo.DataBindings.Add("_Codigo", _ewMante, "_Vehiculo", true);

            //comentario


        }
		
        /// <summary>
        /// Bloquear / desbloquear controles específicos
        /// </summary>
        protected override void _BloquearControles()
        {
            base._BloquearControles();

            // Variable para recoger el valor de bloqueo
            bool bloquearControles = false;

            // Bloquear según el estado del mantenimiento
            switch (_ewMante._Estado)
            {
                case sage.ew.ewbase.ewMante._EstadosMantenimiento.EditandoRegistro:
                case sage.ew.ewbase.ewMante._EstadosMantenimiento.EntrandoNuevo:
                    bloquearControles = false;
                    break;

                case sage.ew.ewbase.ewMante._EstadosMantenimiento.EsperandoCodigo:
                case sage.ew.ewbase.ewMante._EstadosMantenimiento.MostrandoRegistro:
                    bloquearControles = true;
                    break;
                    
                default:
                    bloquearControles = false;
                    break;
            }

            ewtextboxObservaciones.ReadOnly = bloquearControles;
            txtVehiculo._ReadOnly = bloquearControles;

        }
    }
}
