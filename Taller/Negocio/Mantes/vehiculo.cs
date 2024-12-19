using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

using sage.ew.global;
using sage.ew.db;
using sage.ew.ewbase;
using System.Windows.Forms;
using sage.ew.ewbase.Attributes;
using System.ComponentModel.DataAnnotations;
using static sage.ew.contabilidad.Cuenta.DatosRelacionados;

namespace sage.addons.Taller.Negocio.Mantes
{
    public partial class vehiculo : ewMante
    {
        /// <summary>
        /// Indica si el documento está en uso por otro usuario
        /// </summary>
        public bool _EnUso = false;

        /// <summary>
        /// _Matricula
        /// </summary>
		[FieldName("Matricula")]
        [DisplayName("Matrícula")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Matricula
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Matricula))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Matricula)), value);
            }
        }

        /// <summary>
        /// _Pma
        /// </summary>
		[FieldName("Pma")]
        [DisplayName("P.M.A.")]
        public decimal _Pma
        {
            get
            {
                return Convert.ToDecimal(_Campo(GetFieldName(nameof(_Pma))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Pma)), value);
            }
        }

        /// <summary>
        /// _Tara
        /// </summary>
		[FieldName("Tara")]
        [DisplayName("Tara")]
        public decimal _Tara
        {
            get
            {
                return Convert.ToDecimal(_Campo(GetFieldName(nameof(_Tara))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Tara)), value);
            }
        }

        /// <summary>
        /// _Matricula
        /// </summary>
		[FieldName("Observaciones")]
        [DisplayName("Observaciones")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Observaciones
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Observaciones))));
            }
            set
            {

                _Campo(GetFieldName(nameof(_Observaciones)), value);
            }
        }




        /// <summary>
        /// Constructor vacío
        /// </summary>
        public vehiculo()
        {
            Inicializar();
        }

        /// <summary>
        /// Constructor con código
        /// </summary>
        /// <param name="tcCodigo"></param>
        public vehiculo(string tcCodigo)
        {
            Inicializar();

            this._Codigo = tcCodigo;
            this._Load();
        }
    
        private void Inicializar()
        {
            // Asignamos las propiedades para el mantenimiento
            this._Clave = "Codigo";
            this._DataBase = "TALLER";
            this._Tabla = "vehiculo";
            this._TituloMantenimiento = "Mantenimiento de vehículos";

            this._Pantalla = "vehiculo";
            this._FormManteBaseType = typeof(Visual.Forms.frmvehiculo);

            this._Codigo = string.Empty;
        }
    }
    
    
}
