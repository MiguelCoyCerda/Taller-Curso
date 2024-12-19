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
    public partial class conductores : ewMante
    {
        /// <summary>
        /// Indica si el documento está en uso por otro usuario
        /// </summary>
        public bool _EnUso = false;

        /// <summary>
        /// _Telefono
        /// </summary>
		[FieldName("Telefono")]
        [DisplayName("TELEFONO")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Telefono
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Telefono))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Telefono)), value);
            }
        }

        /// <summary>
        /// _Fecha_Carnet
        /// </summary>
		[FieldName("Fecha_Carnet")]
        [DisplayName("FECHA_CARNET")]
        public DateTime _Fecha_Carnet
        {
            get
            {
                return Convert.ToDateTime(_Campo(GetFieldName(nameof(_Fecha_Carnet))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Fecha_Carnet)), value);
            }
        }

        /// <summary>
        /// _Observaciones
        /// </summary>
		[FieldName("Observaciones")]
        [DisplayName("OBSERVACIONES")]
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



        //

        /// <summary>
        /// _Telefono
        /// </summary>
		[FieldName("Email")]
        [DisplayName("EMAIL")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Email
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Email))));
            }
            set
            {

                _Campo(GetFieldName(nameof(_Email)), value);
            }
        }

        /// <summary>
        /// _Fecha_Carnet
        /// </summary>
		[FieldName("Fecha_Nacimiento")]
        [DisplayName("FECHA_NACIMIENTO")]
        public DateTime _Fecha_Nacimiento
        {
            get
            {
                return Convert.ToDateTime(_Campo(GetFieldName(nameof(_Fecha_Nacimiento))));
            }
            set
            {

                _Campo(GetFieldName(nameof(_Fecha_Nacimiento)), value);
            }
        }

        /// <summary>
        /// _Observaciones
        /// </summary>
		[FieldName("Tipo_Carnet")]
        [DisplayName("TIPO_CARNET")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Tipo_Carnet
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Tipo_Carnet))));
            }
            set
            {

                _Campo(GetFieldName(nameof(_Tipo_Carnet)), value);
            }
        }




        /// <summary>
        /// Constructor vacío
        /// </summary>
        public conductores()
        {
            Inicializar();
        }

        /// <summary>
        /// Constructor con código
        /// </summary>
        /// <param name="tcCodigo"></param>
        public conductores(string tcCodigo)
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
            this._Tabla = "conductores";
            this._TituloMantenimiento = "Mantenimiento de conductores";

            this._Pantalla = "conductores";
            this._FormManteBaseType = typeof(Visual.Forms.frmconductores);

            this._Codigo = string.Empty;
        }
    }
    
    
}
