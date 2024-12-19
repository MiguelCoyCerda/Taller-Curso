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

namespace sage.addons.Taller.Negocio.Mantes
{
    public partial class revision : ewMante
    {
        /// <summary>
        /// Indica si el documento está en uso por otro usuario
        /// </summary>
        public bool _EnUso = false;

        /// <summary>
        /// _Observaciones
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
        /// _Vehiculo
        /// </summary>
		[FieldName("Vehiculo")]
        [DisplayName("Vehículo")]
        public string _Vehiculo
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Vehiculo))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Vehiculo)), value);
            }
        }



        
        /// <summary>
        /// Constructor vacío
        /// </summary>
        public revision()
        {
            Inicializar();
        }

        /// <summary>
        /// Constructor con código
        /// </summary>
        /// <param name="tcCodigo"></param>
        public revision(string tcCodigo)
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
            this._Tabla = "revision";
            this._TituloMantenimiento = "Mantenimiento de revisiones";

            this._Pantalla = "revision";
            this._FormManteBaseType = typeof(Visual.Forms.frmrevision);

            this._Codigo = string.Empty;
        }
    }
    
    
}
