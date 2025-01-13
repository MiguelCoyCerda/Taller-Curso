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
using sage.ew.interficies;
using sage.ew.functions;
using sage.ew.formul.Forms;
using sage.ew.reports;
using System.IO;
using sage.ew.usuario;
using System.Reflection;
using sage.ew.ewbase.Clases;
using sage.ew.ewbase.Attributes;
using System.ComponentModel.DataAnnotations;

namespace sage.addons.Taller.Negocio.Documentos
{
    public partial class HojaCarga : DocumentoBase
    {       
        #region Propiedades públicas

        /// <summary>
        /// _Ejercicio
        /// </summary>
		[FieldName("Ejercicio")]
        [DisplayName("EJERCICIO")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Ejercicio
        {
           get
            {
                if (_lisCampos.ContainsKey("EJERCICIO"))
                {
                    return Convert.ToString(_lisCampos["EJERCICIO"]._NewVal);
                }
                else
                {
                     return String.Empty;
                }
            }
            set
            {
                if (_lisCampos.ContainsKey("EJERCICIO"))
                {			
					

                    _lisCampos["EJERCICIO"]._NewVal = value;                                                         
                }
            }
        }

        /// <summary>
        /// _Empresa
        /// </summary>
		[FieldName("Empresa")]
        [DisplayName("EMPRESA")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Empresa
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Empresa))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Empresa)), value);
            }
        }

        /// <summary>
        /// _Numero
        /// </summary>
		[FieldName("Numero")]
        [DisplayName("Número")][ReportProperty("Numero", "", "Número:")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Numero
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Numero))));
            }
            set
            {
				                    AsignarValoresClave();
                    value = value.PadLeft(10);

                // Descomentar para _Numero de documento
                // value = value.PadLeft(10);

				_Campo(GetFieldName(nameof(_Numero)), value);
            }
        }

        /// <summary>
        /// _Fecha
        /// </summary>
		[FieldName("Fecha")]
        [DisplayName("Fecha")][ReportProperty("Fecha", "", "Fecha:")]
        public DateTime _Fecha
        {
            get
            {
                return Convert.ToDateTime(_Campo(GetFieldName(nameof(_Fecha))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Fecha)), value);
            }
        }

        /// <summary>
        /// _Vehiculo
        /// </summary>
		[FieldName("Vehiculo")]
        [DisplayName("Vehículo")][ReportProperty("Vehiculo", "", "Vehículo:")]
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
        /// _Cliente
        /// </summary>
		[FieldName("Cliente")]
        [DisplayName("Cliente")][ReportProperty("Cliente", "", "Cliente:")]
        public string _Cliente
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Cliente))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Cliente)), value);
            }
        }

        /// <summary>
        /// _Observaciones
        /// </summary>
		[FieldName("Observaciones")]
        [DisplayName("Observaciones")][ReportProperty("Observaciones", "", "Observaciones:")]
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
        /// _Vendedor
        /// </summary>
		[FieldName("Vendedor")]
        [DisplayName("Vendedor")][ReportProperty("Vendedor", "", "Vendedor:")]
        public string _Vendedor
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Vendedor))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Vendedor)), value);
            }
        }

        /// <summary>
        /// _Albaran
        /// </summary>
		[FieldName("Albaran")]
        [DisplayName("Albarán")][ReportProperty("Albaran", "", "Albarán:")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Albaran
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Albaran))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Albaran)), value);
            }
        }

        /// <summary>
        /// _Serie
        /// </summary>
		[FieldName("Serie")]
        [DisplayName("Serie Albarán")][ReportProperty("Serie", "", "Serie Albarán:")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Serie
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Serie))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Serie)), value);
            }
        }

        /// <summary>
        /// _Ejeercicioalbaran
        /// </summary>
		[FieldName("Ejeercicioalbaran")]
        [DisplayName("Ejercicio Albarán")][ReportProperty("Ejeercicioalbaran", "", "Ejercicio Albarán:")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Ejeercicioalbaran
        {
            get
            {
                return Convert.ToString(_Campo(GetFieldName(nameof(_Ejeercicioalbaran))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Ejeercicioalbaran)), value);
            }
        }

        /// <summary>
        /// _Fechaalbaran
        /// </summary>
		[FieldName("Fechaalbaran")]
        [DisplayName("Fecha Albarán")][ReportProperty("Fechaalbaran", "", "Fecha Albarán:")]
        public DateTime _Fechaalbaran
        {
            get
            {
                return Convert.ToDateTime(_Campo(GetFieldName(nameof(_Fechaalbaran))));
            }
            set
            {
				
				_Campo(GetFieldName(nameof(_Fechaalbaran)), value);
            }
        }



        #endregion Propiedades públicas



        #region Métodos override

        /// <summary>
        /// Métodoo para incializar el documento
        /// </summary>
        protected override void Inicializar()
        {
            // Asignamos las propiedades para el mantenimiento
            this._Clave = "Ejercicio,Empresa,Numero";
            this._DataBase = "TALLER";
            this._Tabla = "c_hojacarga";
            this._TituloMantenimiento = "Nuevo documento";

            this._Pantalla = "HojaCarga";
            this._FormManteBaseType = typeof(Visual.Forms.frmHojaCarga);
            this._DetalleDocumentoType = typeof(HojaCargaDetalle);
            this._TypeLinea = typeof(HojaCargaDetalle.Linia);

            this._ReportTitlePreview = this._TituloMantenimiento;
            this._ReportBase = "TALLER.HojaCarga";
            this._NombreAddon = "TALLER";
        }

        /// <summary>
        /// Asigna los valores de la clave a _Codigo
        /// </summary>
        protected override void AsignarValoresClave()
        {
            if (string.IsNullOrWhiteSpace(_Ejercicio))
                _Ejercicio = EW_GLOBAL._GetVariable("wc_any").ToString();

            if (string.IsNullOrWhiteSpace(_Empresa))
                _Empresa = EW_GLOBAL._GetVariable("wc_empresa").ToString();




			if (_FormMante != null)
				_FormMante._Cargar_Documento();
        }

        /// <summary>
        /// Busca el siguiente número de documento
        /// </summary>
        /// <returns></returns>
        public override bool _Suma_Numero()
        {
            string numero = string.Empty;
            string clave = "";
            bool sumanumero = true;

            // Preparamos la clave de búsqueda del contador
            clave += EW_GLOBAL._GetVariable("wc_any").ToString();
            clave += EW_GLOBAL._GetVariable("wc_empresa").ToString();



            // La pasamos a la base para que busque número
            numero = base._Suma_Numero(clave);

            if (!string.IsNullOrWhiteSpace(numero))
            {
                _Numero = numero;
            }
            else
            {
                sumanumero = false;
            }

            return sumanumero;
        }

        /// <summary>
        /// Resta el numero del contador
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="numeroactual"></param>
        /// <returns></returns>
        public override bool _Resta_Numero(string numeroactual)
        {
            bool restanumeroresult = false;
            string clave = "";

            // Preparamos la clave de búsqueda del contador
            clave += EW_GLOBAL._GetVariable("wc_any").ToString();
            clave += EW_GLOBAL._GetVariable("wc_empresa").ToString();



            restanumeroresult = base._Resta_Numero(clave, numeroactual);

            return restanumeroresult;
		}

        /// <summary>
        /// Comprobar si el documento existe
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public override bool _Comprobar_Existe_Documento(string numero)
        {
            bool existedocumento = false;
            bool sqlresult;
            DataTable numeroDataTable = new DataTable();

            string camposclave = "";
            string clave = "";

            // Preparamos la clave de búsqueda del documento
            camposclave = "ejercicio+empresa";

            clave += EW_GLOBAL._GetVariable("wc_any").ToString();
            clave += EW_GLOBAL._GetVariable("wc_empresa").ToString();




            // Recuperamos el nuevo número
            sqlresult = DB.SQLExec("Select Numero " +
                                "From " + DB.SQLDatabase(this._DataBase, this._Tabla) + " " +
                                "Where  " + camposclave + " = " + DB.SQLString(clave) + " And Numero = " + DB.SQLString(numero.PadLeft(10, ' ')), ref numeroDataTable);

            if (sqlresult && numeroDataTable.Rows.Count > 0)
            {
                existedocumento = true;
            }

            return existedocumento;
        }

        /// <summary>
        /// Elimina el registro actual
        /// </summary>
        /// <returns></returns>
        public override bool _Delete()
        {
            bool borrado = false;
            string numeroactual = _Numero;

            borrado = base._Delete(numeroactual);

            return borrado;
        }

        #endregion Métodos override


    /// <summary>
    /// Clase para tabla relacionada
    /// </summary>
    public class HojaCargaDetalle : ewManteTRel<HojaCargaDetalle.Linia, HojaCargaDetalle.Clave>
    {
        /// <summary>
        /// Se dispara al añadir un nuevo registro cuando el DataSource no es un DataTable
        /// </summary>
        public delegate void _Error_Validar_HojaCargaDetalle_Handler(string tcErrorMessage);

        /// <summary>
        /// Se dispara al añadir un nuevo registro cuando el DataSource no es un DataTable
        /// </summary>
        public event _Error_Validar_HojaCargaDetalle_Handler _Error_Validar_HojaCargaDetalle;

        /// <summary>
        /// Inicializa una nueva intancia de la clase
        /// </summary>
        public HojaCargaDetalle()
        {
            CrearEstructura();
        }

        /// <summary>
        /// Inicializa una nueva intancia de la clase y carga los registros correspondientes al código del mantenimiento asociado
        /// </summary>
        public HojaCargaDetalle(string codigo)
        {
            CrearEstructura();
        }

        // Definición de la estructura del ManteTRel
        private void CrearEstructura()
        {
            // Events
            this._Error_Validar_Valor += new _Error_Validar_Valor_Handler(HojaCargaDetalle__Error_Validar_Valor);

            // Definir la base
            this._DataBase = "TALLER";
            this._Tabla = "d_hojacarga";
            this._Condicion = "";
            this._Titulo_Browser = "Buscar Artículo";

            ewCampoTRel def_Ejercicio = this._AddCampoTRel("_Ejercicio", "Ejercicio");
            def_Ejercicio._AnchoColumna = 7;
            def_Ejercicio._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Ejercicio._Editable = true;
            def_Ejercicio._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Ejercicio._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Ejercicio._ExpandirPunto = false;
            def_Ejercicio._FormatString = "";
            def_Ejercicio._PermiteDuplicados = true;
            def_Ejercicio._TipoColumna = gridColumnsTypes.Texto;
            def_Ejercicio._Titulo = "EJERCICIO";
            def_Ejercicio._Updatable = true;
            def_Ejercicio._Validar_Asignar_Cargando = false;
            def_Ejercicio._Validar_Dato_BaseDatos = "";
            def_Ejercicio._Validar_Dato_Campos = "";
            def_Ejercicio._Validar_Dato_CampoTRel_Asignar = "";
            def_Ejercicio._Validar_Dato_Clave = "";
            def_Ejercicio._Validar_Dato_Tabla = "";
            def_Ejercicio._Visible = false;
            
            ewCampoTRel def_Empresa = this._AddCampoTRel("_Empresa", "Empresa");
            def_Empresa._AnchoColumna = 7;
            def_Empresa._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Empresa._Editable = true;
            def_Empresa._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Empresa._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Empresa._ExpandirPunto = false;
            def_Empresa._FormatString = "";
            def_Empresa._PermiteDuplicados = true;
            def_Empresa._TipoColumna = gridColumnsTypes.Texto;
            def_Empresa._Titulo = "EMPRESA";
            def_Empresa._Updatable = true;
            def_Empresa._Validar_Asignar_Cargando = false;
            def_Empresa._Validar_Dato_BaseDatos = "";
            def_Empresa._Validar_Dato_Campos = "";
            def_Empresa._Validar_Dato_CampoTRel_Asignar = "";
            def_Empresa._Validar_Dato_Clave = "";
            def_Empresa._Validar_Dato_Tabla = "";
            def_Empresa._Visible = false;
            
            ewCampoTRel def_Numero = this._AddCampoTRel("_Numero", "Numero");
            def_Numero._AnchoColumna = 7;
            def_Numero._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Numero._Editable = true;
            def_Numero._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Numero._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Numero._ExpandirPunto = false;
            def_Numero._FormatString = "";
            def_Numero._PermiteDuplicados = true;
            def_Numero._TipoColumna = gridColumnsTypes.Texto;
            def_Numero._Titulo = "NUMERO";
            def_Numero._Updatable = true;
            def_Numero._Validar_Asignar_Cargando = false;
            def_Numero._Validar_Dato_BaseDatos = "";
            def_Numero._Validar_Dato_Campos = "";
            def_Numero._Validar_Dato_CampoTRel_Asignar = "";
            def_Numero._Validar_Dato_Clave = "";
            def_Numero._Validar_Dato_Tabla = "";
            def_Numero._Visible = false;
            
            ewCampoTRel def_Linea = this._AddCampoTRel("_Linea", "Linea");
            def_Linea._AnchoColumna = 7;
            def_Linea._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Linea._Editable = true;
            def_Linea._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Linea._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Linea._ExpandirPunto = false;
            def_Linea._FormatString = "";
            def_Linea._PermiteDuplicados = true;
            def_Linea._TipoColumna = gridColumnsTypes.Entero;
            def_Linea._Titulo = "LINEA";
            def_Linea._Updatable = true;
            def_Linea._Validar_Asignar_Cargando = false;
            def_Linea._Validar_Dato_BaseDatos = "";
            def_Linea._Validar_Dato_Campos = "";
            def_Linea._Validar_Dato_CampoTRel_Asignar = "";
            def_Linea._Validar_Dato_Clave = "";
            def_Linea._Validar_Dato_Tabla = "";
            def_Linea._Visible = false;
            
            ewCampoTRel def_Articulo = this._AddCampoTRel("_Articulo", "Articulo");
            def_Articulo._AnchoColumna = 15;
            def_Articulo._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Articulo._Editable = true;
            def_Articulo._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Articulo._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Articulo._ExpandirPunto = false;
            def_Articulo._FormatString = "";
            def_Articulo._PermiteDuplicados = true;
            def_Articulo._TipoColumna = gridColumnsTypes.Texto;
            def_Articulo._Titulo = "Artículo";
            def_Articulo._Updatable = true;
            def_Articulo._Validar_Asignar_Cargando = true;
            def_Articulo._Validar_Dato_BaseDatos = "GESTION";
            def_Articulo._Validar_Dato_Campos = "NOMBRE";
            def_Articulo._Validar_Dato_CampoTRel_Asignar = "_Nuevacolumna1";
            def_Articulo._Validar_Dato_Clave = "CODIGO";
            def_Articulo._Validar_Dato_Tabla = "articulo";
            def_Articulo._Visible = true;
            def_Articulo._Browser = new sage.ew.botones.btBrowser();
            def_Articulo._Browser._Campos = "Codigo,Nombre";
            def_Articulo._Browser._Campo_Predet = "Nombre";
            def_Articulo._Browser._Clave = "CODIGO";
            def_Articulo._Browser._DataBase = "GESTION";
            def_Articulo._Browser._Tabla = "articulo";
            def_Articulo._Browser._Titulo = "Buscar Artículo";
            def_Articulo._Browser._Titulos_Campos = "Código,Nombre";
            def_Articulo._Mante = new sage.ew.botones.btMante();
            def_Articulo._Mante._NombreManteNet = "ARTICULO";
            
            ewCampoTRel def_Nuevacolumna1 = this._AddCampoTRel("_Nuevacolumna1", "");
            def_Nuevacolumna1._AnchoColumna = 40;
            def_Nuevacolumna1._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Nuevacolumna1._Editable = false;
            def_Nuevacolumna1._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Nuevacolumna1._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Nuevacolumna1._ExpandirPunto = false;
            def_Nuevacolumna1._FormatString = "";
            def_Nuevacolumna1._PermiteDuplicados = true;
            def_Nuevacolumna1._TipoColumna = gridColumnsTypes.Texto;
            def_Nuevacolumna1._Titulo = "Descripción";
            def_Nuevacolumna1._Updatable = false;
            def_Nuevacolumna1._Validar_Asignar_Cargando = false;
            def_Nuevacolumna1._Validar_Dato_BaseDatos = "";
            def_Nuevacolumna1._Validar_Dato_Campos = "";
            def_Nuevacolumna1._Validar_Dato_CampoTRel_Asignar = "";
            def_Nuevacolumna1._Validar_Dato_Clave = "";
            def_Nuevacolumna1._Validar_Dato_Tabla = "";
            def_Nuevacolumna1._Visible = true;
            
            ewCampoTRel def_Unidades = this._AddCampoTRel("_Unidades", "Unidades");
            def_Unidades._AnchoColumna = 7;
            def_Unidades._AutoModeSizeColumna = DataGridViewAutoSizeColumnMode.None;
            def_Unidades._Editable = true;
            def_Unidades._Error_Duplicados = "Ha introducido un valor que ya está asignado a otro registro. No se permiten valores duplicados en este campo.";
            def_Unidades._Error_Validar_Dato = "Ha introducido un valor que no se ha encontrado en su mantenimiento origen.";
            def_Unidades._ExpandirPunto = false;
            def_Unidades._FormatString = "";
            def_Unidades._PermiteDuplicados = true;
            def_Unidades._TipoColumna = gridColumnsTypes.Número;
            def_Unidades._Titulo = "Unidades";
            def_Unidades._Updatable = true;
            def_Unidades._Validar_Asignar_Cargando = false;
            def_Unidades._Validar_Dato_BaseDatos = "";
            def_Unidades._Validar_Dato_Campos = "";
            def_Unidades._Validar_Dato_CampoTRel_Asignar = "";
            def_Unidades._Validar_Dato_Clave = "";
            def_Unidades._Validar_Dato_Tabla = "";
            def_Unidades._Visible = true;
            def_Unidades._Mascara = new ewMascara("999999999999999.99");
            

        }

		// Captura el error al validar un valor introducido.
        private void HojaCargaDetalle__Error_Validar_Valor(string errorMessage)
        {
            if (_Error_Validar_HojaCargaDetalle != null)
            {
                _Error_Validar_HojaCargaDetalle(errorMessage);
                _Refresh();
            }
        }

        /// <summary>
        /// Establecer valores de claves
        /// </summary>
        public override void _Load()
        {
            HojaCarga document = (HojaCarga)_ewMantePrincipal;
            
			                this._Claves._Ejercicio._Valor = document._Ejercicio;
                this._Claves._Empresa._Valor = document._Empresa;
                this._Claves._Numero._Valor = document._Numero;


            base._Load();
        }

        /// <summary>
        /// Campos clave para registros únicos y carga de registros
        /// </summary>
        public class Clave : IClaves
        {
                /// <summary>
                /// Ejercicio
                /// </summary>
                public ClaveTRel _Ejercicio { get; set; }
                
                /// <summary>
                /// Empresa
                /// </summary>
                public ClaveTRel _Empresa { get; set; }
                
                /// <summary>
                /// Numero
                /// </summary>
                public ClaveTRel _Numero { get; set; }
                
                /// <summary>
                /// Linea
                /// </summary>
                public ClaveTRel _Linea { get; set; }
                


                /// <summary>
                /// Inicializa una nueva instancia de la clase
                /// </summary>
                public Clave()
                {
                    // Definición de las propiedades de cada una de les claves

                    // Ejercicio
                    _Ejercicio = new ClaveTRel();
                    _Ejercicio._EsFiltro = true;
                
                    // Empresa
                    _Empresa = new ClaveTRel();
                    _Empresa._EsFiltro = true;
                
                    // Numero
                    _Numero = new ClaveTRel();
                    _Numero._EsFiltro = true;
                
                    // Linea
                    _Linea = new ClaveTRel();
                    _Linea._EsCampoLinea = true;
                

                }
        }

        /// <summary>
        /// Definir la estructura de las líneas
        /// </summary>
        public class Linia : ILinTRel
        {
        /// <summary>
        /// _Ejercicio
        /// </summary>
		
        public string _Ejercicio
        {
            get
            {
                 return _privateEjercicio;
            }
            set
            {
                _privateEjercicio = value;
            }
        }
        private string _privateEjercicio = "";

        /// <summary>
        /// _Empresa
        /// </summary>
		
        public string _Empresa
        {
            get
            {
                 return _privateEmpresa;
            }
            set
            {
                _privateEmpresa = value;
            }
        }
        private string _privateEmpresa = "";

        /// <summary>
        /// _Numero
        /// </summary>
		
        public string _Numero
        {
            get
            {
                 return _privateNumero;
            }
            set
            {
                _privateNumero = value;
            }
        }
        private string _privateNumero = "";

        /// <summary>
        /// _Linea
        /// </summary>
		
        public Int32 _Linea
        {
            get
            {
                 return _privateLinea;
            }
            set
            {
                _privateLinea = value;
            }
        }
        private Int32 _privateLinea = 0;

        /// <summary>
        /// _Articulo
        /// </summary>
		[ReportProperty("Articulo", "", "Artículo")]
        public string _Articulo
        {
            get
            {
                 return _privateArticulo;
            }
            set
            {
                if (_privateArticulo.Trim() != value.Trim())
                {

                    if (loParent != null)
                    {
                        object loNewValor;
                        if (loParent.CamposTRel_Validar_Valor("_Articulo", value, this, out loNewValor))
                        {
                            value = _privateArticulo;
                        }
                        else if (loNewValor != null)
                        {
                            value = Convert.ToString(loNewValor);
                        }
                    }
                }

                if (_privateArticulo.Trim() != value.Trim())
                {
                    _privateArticulo = value;
                    loParent._Exportar_Null();
                }
;
            }
        }
        private string _privateArticulo = "";

        /// <summary>
        /// _Nuevacolumna1
        /// </summary>
		[ReportProperty("Nuevacolumna1", "", "Descripción")]
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
        /// _Unidades
        /// </summary>
		[ReportProperty("Unidades", "", "Unidades")]
        public decimal _Unidades
        {
            get
            {
                 return _privateUnidades;
            }
            set
            {
                _privateUnidades = value;
            }
        }
        private decimal _privateUnidades = 0;

		 

            private HojaCargaDetalle loParent;
            /// <summary>
            /// Objeto padre a la instancia.
            /// </summary>
            public object _Parent
            {
                get { return loParent; }
                set { loParent = (HojaCargaDetalle)value; }
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
}