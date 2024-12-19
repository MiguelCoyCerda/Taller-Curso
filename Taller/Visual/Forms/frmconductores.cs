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
    public partial class frmconductores : FormMante
    {
	    /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public frmconductores()
        {
            InitializeComponent();
        }
		
        /// <summary>
        /// Bindear objetos específicos
        /// </summary>
        protected override void _Binding()
        {
            base._Binding();

            if (ewtextboxTelefono.DataBindings["Text"] != null)
                ewtextboxTelefono.DataBindings[0].ReadValue();
            else
                ewtextboxTelefono.DataBindings.Add("Text", _ewMante, "_Telefono", true);

            if (ewdatetimeFecha_Carnet.DataBindings["Value"] != null)
                ewdatetimeFecha_Carnet.DataBindings[0].ReadValue();
            else
                ewdatetimeFecha_Carnet.DataBindings.Add("Value", _ewMante, "_Fecha_Carnet", true);

            if (ewtextboxObservaciones.DataBindings["Text"] != null)
                ewtextboxObservaciones.DataBindings[0].ReadValue();
            else
                ewtextboxObservaciones.DataBindings.Add("Text", _ewMante, "_Observaciones", true);


            if (txtCarnet.DataBindings["Text"] != null)
                txtCarnet.DataBindings[0].ReadValue();
            else
                txtCarnet.DataBindings.Add("Text", _ewMante, "_Tipo_Carnet", true);

            if (datetimeFechaNacimento.DataBindings["Value"] != null)
                datetimeFechaNacimento.DataBindings[0].ReadValue();
            else
                datetimeFechaNacimento.DataBindings.Add("Value", _ewMante, "_Fecha_Nacimiento", true);

            if (txtEmail.DataBindings["Text"] != null)
                txtEmail.DataBindings[0].ReadValue();
            else
                txtEmail.DataBindings.Add("Text", _ewMante, "_Email", true);


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

            ewtextboxTelefono.ReadOnly = bloquearControles;
            ewdatetimeFecha_Carnet.Enabled = !bloquearControles;
            ewtextboxObservaciones.ReadOnly = bloquearControles;

            txtCarnet.ReadOnly = bloquearControles;
            datetimeFechaNacimento.Enabled = !bloquearControles;
            txtEmail.ReadOnly = bloquearControles;

        }
    }
}
