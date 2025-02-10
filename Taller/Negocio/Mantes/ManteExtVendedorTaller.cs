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
    public class ManteExtVendedorTaller : _ExtensionMante
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
        public Visual.UserControls.TallerVENDEDOR usercontrolTabManteBase = null;


        #region ManteTRels



        #endregion ManteTRels


        /// <summary>
        /// _Vendedor
        /// </summary>
		[FieldName("Vendedor")]
        [DisplayName("VENDEDOR")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Vendedor
        {
            get
            {
                 return _privateVendedor;
            }
            set
            {
                _privateVendedor = value;
            }
        }
        private string _privateVendedor  = String.Empty;

        /// <summary>
        /// _Nuevocampo1
        /// </summary>
		[FieldName("Nuevocampo1")]
        [DisplayName("NUEVOCAMPO1")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Nuevocampo1
        {
            get
            {
                 return _privateNuevocampo1;
            }
            set
            {
                _privateNuevocampo1 = value;
            }
        }
        private string _privateNuevocampo1  = String.Empty;

        /// <summary>
        /// _Nuevocampo2
        /// </summary>
		[FieldName("Nuevocampo2")]
        [DisplayName("NUEVOCAMPO2")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Nuevocampo2
        {
            get
            {
                 return _privateNuevocampo2;
            }
            set
            {
                _privateNuevocampo2 = value;
            }
        }
        private string _privateNuevocampo2  = String.Empty;


        /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public ManteExtVendedorTaller(sage.ew.interficies.IMante _mantePrincipal)
            : this()
        {
            this._Mante = _mantePrincipal;

            // Asociar mantenimientos de tablas relacionadas
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public ManteExtVendedorTaller()
        {
            this._Tabla = "vendedores_adi";
            this._DataBase = "TALLER";
            this._Clave = "Vendedor";
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase y asigna objetos
        /// </summary>
        public ManteExtVendedorTaller(FormMante toForm)
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
                this._Nuevocampo1 = String.Empty;
                this._Nuevocampo2 = String.Empty;

                string whereclause = GetWhereClause();
                string sql = "Select Vendedor, Nuevocampo1, Nuevocampo2 " + 
                "From " + DB.SQLDatabase(this._DataBase, this._Tabla) + " " + 
                whereclause;


                if (!string.IsNullOrWhiteSpace(sql))
                {
                    DataTable vendedores_adiresult = new DataTable();
                    llOk = DB.SQLExec(sql, ref vendedores_adiresult);

                    if (llOk && vendedores_adiresult.Rows.Count > 0)
                    {
                this._Vendedor = Convert.ToString(vendedores_adiresult.Rows[0]["Vendedor"]);
                this._Nuevocampo1 = Convert.ToString(vendedores_adiresult.Rows[0]["Nuevocampo1"]);
                this._Nuevocampo2 = Convert.ToString(vendedores_adiresult.Rows[0]["Nuevocampo2"]);


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
                this._Nuevocampo1 = String.Empty;
                this._Nuevocampo2 = String.Empty;

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
                    "Set Vendedor = " + DB.SQLString(this._Vendedor) + ", Nuevocampo1 = " + DB.SQLString(this._Nuevocampo1) + ", Nuevocampo2 = " + DB.SQLString(this._Nuevocampo2) +  " " + 
                    whereclause;

                }
                else
                {
                    sql =  "Insert Into " + DB.SQLDatabase(this._DataBase, this._Tabla) + " " + 
                    "(Vendedor, Nuevocampo1, Nuevocampo2) " + 
                    "Values (" + DB.SQLString(this._Vendedor) + ", " + DB.SQLString(this._Nuevocampo1) + ", " + DB.SQLString(this._Nuevocampo2) + ")";

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
    public class FormManteExtVendedorTaller : _ExtensionFormMante
    {
        //private FormMante _oFormMante = null;
        private ManteExtVendedorTaller extensionMante = null;

        /// <summary>
        /// Iniciarliza una nueva instancia de la clase
        /// </summary>
        /// <param name="_formMante"></param>
        /// <param name="toAddon"></param>
        public FormManteExtVendedorTaller(FormMante _formMante, IModulo toAddon)
            : base(_formMante, toAddon)
        {
            #region Código generado por el asistente de componentes. No borrar.

            extensionMante = (ManteExtVendedorTaller)_ExtensionMante;

            if (extensionMante == null)
                return;

            Visual.UserControls.TallerVENDEDOR extensionFormMante = new Visual.UserControls.TallerVENDEDOR(extensionMante);
			extensionMante.usercontrolTabManteBase = extensionFormMante;
            extensionMante._Load();

            _AgregarTabAddon(extensionFormMante);

            #endregion Código generado por el asistente de componentes. No borrar.
        }
    }
}
