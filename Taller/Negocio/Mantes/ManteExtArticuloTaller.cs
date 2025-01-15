using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using sage.ew.ewbase;
using sage.ew.formul.Forms;
using sage.ew.interficies;
using sage.ew.db;
using sage.ew.ewbase.Attributes;

namespace sage.addons.Taller.Negocio.Mantes
{
    /// <summary>
    /// Extensión para el mantenimiento de clientes
    /// </summary>
    public class ManteExtArticuloTaller : _ExtensionMante
    {
        // Objeto de negocio del mantenimiento principal
        private ewMante mantePrincipal = null;

        // Formulario del mantenimiento
        private FormMante formMante = null;
		
        // Contiene si el registro existe en la tabla
        private bool rowexist = false;

        /// <summary>
        /// Referencia al UserControl asociado a esta clase
        /// </summary>
        public Visual.UserControls.TallerARTICULO usercontrolTabManteBase = null;


        #region ManteTRels



        #endregion ManteTRels


        /// <summary>
        /// _Articulo
        /// </summary>
		[FieldName("Articulo")]
        [DisplayName("ARTICULO")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Articulo
        {
            get
            {
                 return _privateArticulo;
            }
            set
            {
                _privateArticulo = value;
            }
        }
        private string _privateArticulo  = String.Empty;

        /// <summary>
        /// _Revision
        /// </summary>
		[FieldName("Revision")]
        [DisplayName("Revisión")]
        public string _Revision
        {
            get
            {
                 return _privateRevision;
            }
            set
            {
                _privateRevision = value;
            }
        }
        private string _privateRevision  = String.Empty;

        /// <summary>
        /// _Libre1
        /// </summary>
		[FieldName("Libre1")]
        [DisplayName("LIBRE1")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Libre1
        {
            get
            {
                 return _privateLibre1;
            }
            set
            {
                _privateLibre1 = value;
            }
        }
        private string _privateLibre1  = String.Empty;

        /// <summary>
        /// _Libre2
        /// </summary>
		[FieldName("Libre2")]
        [DisplayName("LIBRE2")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Libre2
        {
            get
            {
                 return _privateLibre2;
            }
            set
            {
                _privateLibre2 = value;
            }
        }
        private string _privateLibre2  = String.Empty;


        /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public ManteExtArticuloTaller(sage.ew.interficies.IMante _mantePrincipal)
            : this()
        {
            this._Mante = _mantePrincipal;

            // Asociar mantenimientos de tablas relacionadas
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public ManteExtArticuloTaller()
        {
            this._Tabla = "articulo_adi";
            this._DataBase = "TALLER";
            this._Clave = "Articulo";
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase y asigna objetos
        /// </summary>
        public ManteExtArticuloTaller(FormMante toForm)
            : this()
        {
            #region Código generado por el asistente de componentes. No borrar.

            formMante = toForm;
            mantePrincipal = toForm._ewMante;

            #endregion Código generado por el asistente de componentes. No borrar.
        }

        /// <summary>
        /// Se dispara cuando se cargan los datos en el mantenimiento principal
        /// </summary>
        /// <returns></returns>
        public override bool _Load()
        {
            bool llOk = base._Load();

            if (llOk && _eBeforeAfter == TipoExecute.After)
            {
                this._Revision = String.Empty;
                this._Libre1 = String.Empty;
                this._Libre2 = String.Empty;

                string whereclause = GetWhereClause();
                string sql = "Select Articulo, Revision, Libre1, Libre2 " + 
                "From " + DB.SQLDatabase(this._DataBase, this._Tabla) + " " + 
                whereclause;


                if (!string.IsNullOrWhiteSpace(sql))
                {
                    DataTable articulo_adiresult = new DataTable();
                    llOk = DB.SQLExec(sql, ref articulo_adiresult);

                    if (llOk && articulo_adiresult.Rows.Count > 0)
                    {
                this._Articulo = Convert.ToString(articulo_adiresult.Rows[0]["Articulo"]);
                        this._Revision = Convert.ToString(articulo_adiresult.Rows[0]["Revision"]);
                this._Libre1 = Convert.ToString(articulo_adiresult.Rows[0]["Libre1"]);
                this._Libre2 = Convert.ToString(articulo_adiresult.Rows[0]["Libre2"]);


                        rowexist = true;
                    }
                    else
                    {
                        rowexist = false;
                    }
                }

                if (usercontrolTabManteBase != null)
                {
                    usercontrolTabManteBase._Binding();
                }
            }

            return llOk;
        }

        /// <summary>
        /// Se dispara cuando se va crea un nuevo registro
        /// </summary>
        /// <param name="tcCodigo"></param>
        /// <returns></returns>
        public override bool _New(string tcCodigo = "")
        {
            bool llOk = base._New(tcCodigo);

            if (llOk && _eBeforeAfter == TipoExecute.After)
            {
                this._Revision = String.Empty;
                this._Libre1 = String.Empty;
                this._Libre2 = String.Empty;

                if (usercontrolTabManteBase != null)
                {
                    usercontrolTabManteBase._Binding();
                    usercontrolTabManteBase._BloquearControles(false);
                }
            }

            return llOk;        
        }

        /// <summary>
        /// Guardar el registro actual
        /// </summary>
        /// <returns></returns>
        public override bool _Save()
        {
            bool llOk = base._Save();

            if (llOk && _eBeforeAfter == TipoExecute.After)
            {
                string sql = "";
				string whereclause = GetWhereClause();

                if (rowexist)
                {
                    sql =  "Update " + DB.SQLDatabase(this._DataBase, this._Tabla) + " " + 
                    "Set Articulo = " + DB.SQLString(this._Articulo) + ", Revision = " + DB.SQLString(this._Revision) + ", Libre1 = " + DB.SQLString(this._Libre1) + ", Libre2 = " + DB.SQLString(this._Libre2) +  " " + 
                    whereclause;

                }
                else
                {
                    sql =  "Insert Into " + DB.SQLDatabase(this._DataBase, this._Tabla) + " " + 
                    "(Articulo, Revision, Libre1, Libre2) " + 
                    "Values (" + DB.SQLString(this._Articulo) + ", " + DB.SQLString(this._Revision) + ", " + DB.SQLString(this._Libre1) + ", " + DB.SQLString(this._Libre2) + ")";

                }

                if (!string.IsNullOrWhiteSpace(sql))
                {
                    llOk = DB.SQLExec(sql);
                }
            }

            return llOk;
        }

        /// <summary>
        /// Eliminar el registro actual
        /// </summary>
        /// <returns></returns>
        public override bool _Delete()
        {
            bool llOk = base._Delete();

            if (llOk && _eBeforeAfter == TipoExecute.After)
            {
                string sql = "";
				string whereclause = GetWhereClause();

                sql = "Delete From " + DB.SQLDatabase(this._DataBase, this._Tabla) + " " + 
                    whereclause;


                if (!string.IsNullOrWhiteSpace(sql))
                {
                    llOk = DB.SQLExec(sql);
                }
            }

            return llOk;
        }

        /// <summary>
        /// Bloquear controles de las extensiones de los mantes
        /// </summary>
        /// <param name="tlReadOnly"></param>
        public override void _Bloquear_Controles(bool tlReadOnly)
        {
            if (usercontrolTabManteBase != null)
            {
                usercontrolTabManteBase._BloquearControles(tlReadOnly);
            }
        }		
    }

    /// <summary>
    /// Clase para la extensión de los formularios
    /// </summary>
    public class FormManteExtArticuloTaller : _ExtensionFormMante
    {
        //private FormMante _oFormMante = null;
        private ManteExtArticuloTaller extensionMante = null;

        /// <summary>
        /// Iniciarliza una nueva instancia de la clase
        /// </summary>
        /// <param name="_formMante"></param>
        /// <param name="toAddon"></param>
        public FormManteExtArticuloTaller(FormMante _formMante, IModulo toAddon)
            : base(_formMante, toAddon)
        {
            #region Código generado por el asistente de componentes. No borrar.

            extensionMante = (ManteExtArticuloTaller)_ExtensionMante;

            if (extensionMante == null)
                return;

            Visual.UserControls.TallerARTICULO extensionFormMante = new Visual.UserControls.TallerARTICULO(extensionMante);
			extensionMante.usercontrolTabManteBase = extensionFormMante;
            extensionMante._Load();

            _AgregarTabAddon(extensionFormMante);

            #endregion Código generado por el asistente de componentes. No borrar.
        }
    }
}
