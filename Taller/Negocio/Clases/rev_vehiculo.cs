using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using sage.ew.ewbase;
using sage.ew.interficies;

namespace sage.addons.Taller.Negocio.Clases
{
    
    /// <summary>
    /// Clase para tabla relacionada
    /// </summary>
    public class rev_vehiculo : ewManteTRel<rev_vehiculo.Linia, rev_vehiculo.Clave>
    {
        /// <summary>
        /// Se dispara al añadir un nuevo registro cuando el DataSource no es un DataTable
        /// </summary>
        public delegate void _Error_Validar_rev_vehiculo_Handler(string tcErrorMessage);

        /// <summary>
        /// Se dispara al añadir un nuevo registro cuando el DataSource no es un DataTable
        /// </summary>
        public event _Error_Validar_rev_vehiculo_Handler _Error_Validar_rev_vehiculo;

        /// <summary>
        /// Inicializa una nueva intancia de la clase
        /// </summary>
        public rev_vehiculo()
        {
            CrearEstructura();
        }

        /// <summary>
        /// Inicializa una nueva intancia de la clase y carga los registros correspondientes al código del mantenimiento asociado
        /// </summary>
        public rev_vehiculo(string codigo)
        {
            CrearEstructura();
        }

        // Definición de la estructura del ManteTRel
        private void CrearEstructura()
        {
            // Events
            this._Error_Validar_Valor += new _Error_Validar_Valor_Handler(rev_vehiculo__Error_Validar_Valor);

            // Definir la base
            this._DataBase = "TALLER";
            this._Tabla = "rev_vehiculo";
            this._Condicion = "";
            this._Titulo_Browser = "Buscar Revisión";

            ewCampoTRel def_Vehiculo = this._AddCampoTRel("_Vehiculo", "Vehiculo");
            def_Vehiculo._AnchoColumna = 7;
            def_Vehiculo._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Vehiculo._Editable = true;
            def_Vehiculo._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Vehiculo._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Vehiculo._ExpandirPunto = false;
            def_Vehiculo._FormatString = "";
            def_Vehiculo._PermiteDuplicados = true;
            def_Vehiculo._TipoColumna = gridColumnsTypes.Texto;
            def_Vehiculo._Titulo = "VEHICULO";
            def_Vehiculo._Updatable = true;
            def_Vehiculo._Validar_Asignar_Cargando = false;
            def_Vehiculo._Validar_Dato_BaseDatos = "";
            def_Vehiculo._Validar_Dato_Campos = "";
            def_Vehiculo._Validar_Dato_CampoTRel_Asignar = "";
            def_Vehiculo._Validar_Dato_Clave = "";
            def_Vehiculo._Validar_Dato_Tabla = "";
            def_Vehiculo._Visible = false;
            
            ewCampoTRel def_Clavelinea = this._AddCampoTRel("_Clavelinea", "Clavelinea");
            def_Clavelinea._AnchoColumna = 7;
            def_Clavelinea._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Clavelinea._Editable = true;
            def_Clavelinea._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Clavelinea._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Clavelinea._ExpandirPunto = false;
            def_Clavelinea._FormatString = "";
            def_Clavelinea._PermiteDuplicados = true;
            def_Clavelinea._TipoColumna = gridColumnsTypes.Entero;
            def_Clavelinea._Titulo = "CLAVELINEA";
            def_Clavelinea._Updatable = true;
            def_Clavelinea._Validar_Asignar_Cargando = false;
            def_Clavelinea._Validar_Dato_BaseDatos = "";
            def_Clavelinea._Validar_Dato_Campos = "";
            def_Clavelinea._Validar_Dato_CampoTRel_Asignar = "";
            def_Clavelinea._Validar_Dato_Clave = "";
            def_Clavelinea._Validar_Dato_Tabla = "";
            def_Clavelinea._Visible = false;

            ewCampoTRel def_Revision = this._AddCampoTRel("_Revision", "Revision");
            def_Revision._AnchoColumna = 6;
            def_Revision._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Revision._Editable = true;
            def_Revision._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Revision._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Revision._ExpandirPunto = false;
            def_Revision._FormatString = "";
            def_Revision._PermiteDuplicados = true;
            def_Revision._TipoColumna = gridColumnsTypes.Texto;
            def_Revision._Titulo = "Revisión";
            def_Revision._Updatable = true;
            def_Revision._Validar_Asignar_Cargando = true;
            def_Revision._Validar_Dato_BaseDatos = "TALLER";
            def_Revision._Validar_Dato_Campos = "NOMBRE";
            def_Revision._Validar_Dato_CampoTRel_Asignar = "_Nuevacolumna1";
            def_Revision._Validar_Dato_Clave = "CODIGO";
            def_Revision._Validar_Dato_Tabla = "revision";
            def_Revision._Visible = true;
            def_Revision._Browser = new sage.ew.botones.btBrowser();
            def_Revision._Browser._Campos = "Codigo,Nombre";
            def_Revision._Browser._Campo_Predet = "Nombre";
            def_Revision._Browser._Clave = "CODIGO";
            def_Revision._Browser._DataBase = "TALLER";
            def_Revision._Browser._Tabla = "revision";
            def_Revision._Browser._Titulo = "Buscar Revisión";
            def_Revision._Browser._Titulos_Campos = "Código,Nombre";
            def_Revision._Mante = new sage.ew.botones.btMante();
            def_Revision._Mante._NombreManteNet = "REVISION";

            ewCampoTRel def_Nuevacolumna1 = this._AddCampoTRel("_Nuevacolumna1", "");
            def_Nuevacolumna1._AnchoColumna = 12;
            def_Nuevacolumna1._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Nuevacolumna1._Editable = false;
            def_Nuevacolumna1._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Nuevacolumna1._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Nuevacolumna1._ExpandirPunto = false;
            def_Nuevacolumna1._FormatString = "";
            def_Nuevacolumna1._PermiteDuplicados = true;
            def_Nuevacolumna1._TipoColumna = gridColumnsTypes.Texto;
            def_Nuevacolumna1._Titulo = "Definición";
            def_Nuevacolumna1._Updatable = false;
            def_Nuevacolumna1._Validar_Asignar_Cargando = false;
            def_Nuevacolumna1._Validar_Dato_BaseDatos = "";
            def_Nuevacolumna1._Validar_Dato_Campos = "";
            def_Nuevacolumna1._Validar_Dato_CampoTRel_Asignar = "";
            def_Nuevacolumna1._Validar_Dato_Clave = "";
            def_Nuevacolumna1._Validar_Dato_Tabla = "";
            def_Nuevacolumna1._Visible = true;
            
            ewCampoTRel def_Km = this._AddCampoTRel("_Km", "Km");
            def_Km._AnchoColumna = 7;
            def_Km._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Km._Editable = true;
            def_Km._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Km._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Km._ExpandirPunto = false;
            def_Km._FormatString = "";
            def_Km._PermiteDuplicados = true;
            def_Km._TipoColumna = gridColumnsTypes.Número;
            def_Km._Titulo = "K.M.";
            def_Km._Updatable = true;
            def_Km._Validar_Asignar_Cargando = false;
            def_Km._Validar_Dato_BaseDatos = "";
            def_Km._Validar_Dato_Campos = "";
            def_Km._Validar_Dato_CampoTRel_Asignar = "";
            def_Km._Validar_Dato_Clave = "";
            def_Km._Validar_Dato_Tabla = "";
            def_Km._Visible = true;
            def_Km._Mascara = new ewMascara("999999999999999.999999");
            
            ewCampoTRel def_Fecha = this._AddCampoTRel("_Fecha", "Fecha");
            def_Fecha._AnchoColumna = 7;
            def_Fecha._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Fecha._Editable = true;
            def_Fecha._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Fecha._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Fecha._ExpandirPunto = false;
            def_Fecha._FormatString = "";
            def_Fecha._PermiteDuplicados = true;
            def_Fecha._TipoColumna = gridColumnsTypes.Fecha;
            def_Fecha._Titulo = "Fecha";
            def_Fecha._Updatable = true;
            def_Fecha._Validar_Asignar_Cargando = false;
            def_Fecha._Validar_Dato_BaseDatos = "";
            def_Fecha._Validar_Dato_Campos = "";
            def_Fecha._Validar_Dato_CampoTRel_Asignar = "";
            def_Fecha._Validar_Dato_Clave = "";
            def_Fecha._Validar_Dato_Tabla = "";
            def_Fecha._Visible = true;
            
            ewCampoTRel def_Notas = this._AddCampoTRel("_Notas", "Notas");
            def_Notas._AnchoColumna = 25;
            def_Notas._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Notas._Editable = true;
            def_Notas._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Notas._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Notas._ExpandirPunto = false;
            def_Notas._FormatString = "";
            def_Notas._PermiteDuplicados = true;
            def_Notas._TipoColumna = gridColumnsTypes.Texto;
            def_Notas._Titulo = "Notas";
            def_Notas._Updatable = true;
            def_Notas._Validar_Asignar_Cargando = false;
            def_Notas._Validar_Dato_BaseDatos = "";
            def_Notas._Validar_Dato_Campos = "";
            def_Notas._Validar_Dato_CampoTRel_Asignar = "";
            def_Notas._Validar_Dato_Clave = "";
            def_Notas._Validar_Dato_Tabla = "";
            def_Notas._Visible = true;
            

        }

		// Captura el error al validar un valor introducido.
        private void rev_vehiculo__Error_Validar_Valor(string errorMessage)
        {
            if (_Error_Validar_rev_vehiculo != null)
            {
                _Error_Validar_rev_vehiculo(errorMessage);
                _Refresh();
            }
        }

        /// <summary>
        /// Establecer valores de claves
        /// </summary>
        public override void _Load()
        {
            
            
			                this._Claves._Vehiculo._Valor = this._ewMantePrincipal._Codigo;

            base._Load();
        }

        /// <summary>
        /// Campos clave para registros únicos y carga de registros
        /// </summary>
        public class Clave : IClaves
        {
                /// <summary>
                /// Vehiculo
                /// </summary>
                public ClaveTRel _Vehiculo { get; set; }
                
                /// <summary>
                /// Clavelinea
                /// </summary>
                public ClaveTRel _Clavelinea { get; set; }
                


                /// <summary>
                /// Inicializa una nueva instancia de la clase
                /// </summary>
                public Clave()
                {
                    // Definición de las propiedades de cada una de les claves

                    // Vehiculo
                    _Vehiculo = new ClaveTRel();
                    _Vehiculo._EsFiltro = true;
                
                    // Clavelinea
                    _Clavelinea = new ClaveTRel();
                    _Clavelinea._EsCampoLinea = true;
                

                }
        }

        /// <summary>
        /// Definir la estructura de las líneas
        /// </summary>
        public class Linia : ILinTRel
        {
        /// <summary>
        /// _Vehiculo
        /// </summary>
		
        public string _Vehiculo
        {
            get
            {
                 return _privateVehiculo;
            }
            set
            {
                _privateVehiculo = value;
            }
        }
        private string _privateVehiculo = "";

        /// <summary>
        /// _Clavelinea
        /// </summary>
		
        public Int32 _Clavelinea
        {
            get
            {
                 return _privateClavelinea;
            }
            set
            {
                _privateClavelinea = value;
            }
        }
        private Int32 _privateClavelinea = 0;

        /// <summary>
        /// _Revision
        /// </summary>
		
        public string _Revision
        {
            get
            {
                 return _privateRevision;
            }
            set
            {
                if (_privateRevision.Trim() != value.Trim())
                {

                    if (loParent != null)
                    {
                        object loNewValor;
                        if (loParent.CamposTRel_Validar_Valor("_Revision", value, this, out loNewValor))
                        {
                            value = _privateRevision;
                        }
                        else if (loNewValor != null)
                        {
                            value = Convert.ToString(loNewValor);
                        }
                    }
                }

                if (_privateRevision.Trim() != value.Trim())
                {
                    _privateRevision = value;
                    loParent._Exportar_Null();
                }
;
            }
        }
        private string _privateRevision = "";

        /// <summary>
        /// _Nuevacolumna1
        /// </summary>
		
        public string _Nuevacolumna1
        {
            get
            {
                 return _privateNuevacolumna1;
            }
            set
            {
                _privateNuevacolumna1 = value;
            }
        }
        private string _privateNuevacolumna1 = "";

        /// <summary>
        /// _Km
        /// </summary>
		
        public decimal _Km
        {
            get
            {
                 return _privateKm;
            }
            set
            {
                _privateKm = value;
            }
        }
        private decimal _privateKm = 0;

        /// <summary>
        /// _Fecha
        /// </summary>
		
        public DateTime _Fecha
        {
            get
            {
                 return _privateFecha;
            }
            set
            {
                _privateFecha = value;
            }
        }
        private DateTime _privateFecha = DateTime.Now;

        /// <summary>
        /// _Notas
        /// </summary>
		
        public string _Notas
        {
            get
            {
                 return _privateNotas;
            }
            set
            {
                _privateNotas = value;
            }
        }
        private string _privateNotas = "";

		 

            private rev_vehiculo loParent;
            /// <summary>
            /// Objeto padre a la instancia.
            /// </summary>
            public object _Parent
            {
                get { return loParent; }
                set { loParent = (rev_vehiculo)value; }
            }

            /// <summary>
            /// Inicializa una nueva intancia de la clase
            /// </summary>
            public Linia()
            {

            }

            /// <summary>
            /// Devuelve si la línea está completa
            /// </summary>
            /// <returns></returns>
            public bool Fila_Plena()
            {
                bool lbFilaPlena = true;

                //lbFilaPlena = !string.IsNullOrWhiteSpace(campo);

                return lbFilaPlena;
            }
        }
    }

}
