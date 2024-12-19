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
    public partial class frmvehiculo : FormMante
    {
	    /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public frmvehiculo()
        {
            InitializeComponent();
        }
		
        /// <summary>
        /// Bindear objetos específicos
        /// </summary>
        protected override void _Binding()
        {
            base._Binding();

            if (ewtextboxMatricula.DataBindings["Text"] != null)
                ewtextboxMatricula.DataBindings[0].ReadValue();
            else
                ewtextboxMatricula.DataBindings.Add("Text", _ewMante, "_Matricula", true);

            if (ewnumericupdownPma.DataBindings["Value"] != null)
                ewnumericupdownPma.DataBindings[0].ReadValue();
            else
                ewnumericupdownPma.DataBindings.Add("Value", _ewMante, "_Pma", true);

            if (ewnumericupdownTara.DataBindings["Value"] != null)
                ewnumericupdownTara.DataBindings[0].ReadValue();
            else
                ewnumericupdownTara.DataBindings.Add("Value", _ewMante, "_Tara", true);

            //Observaciones añadido a posteriori
            if (txtObservaciones.DataBindings["Text"] != null)
                txtObservaciones.DataBindings[0].ReadValue();
            else
                txtObservaciones.DataBindings.Add("Text", _ewMante, "_Observaciones", true);


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

            ewtextboxMatricula.ReadOnly = bloquearControles;
            ewnumericupdownPma.ReadOnly = bloquearControles;
            ewnumericupdownTara.ReadOnly = bloquearControles;
            txtObservaciones.ReadOnly = bloquearControles;

        }
    }
}
