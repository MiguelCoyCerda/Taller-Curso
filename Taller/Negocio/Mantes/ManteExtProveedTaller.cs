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
    public class ManteExtProveedTaller : _ExtensionMante
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
        public Visual.UserControls.TallerPROVEED usercontrolTabManteBase = null;


        #region ManteTRels



        #endregion ManteTRels


        /// <summary>
        /// _Proveedor
        /// </summary>
		[FieldName("Proveedor")]
        [DisplayName("PROVEEDOR")]
        [DefaultValue("")]
        [DataType(DataType.Text)]
        public string _Proveedor
        {
            get
            {
                 return _privateProveedor;
            }
            set
            {
                _privateProveedor = value;
            }
        }
        private string _privateProveedor  = String.Empty;

        /// <summary>
        /// _Cliente
        /// </summary>
		[FieldName("Cliente")]
        [DisplayName("CLIENTE")]
        public string _Cliente
        {
            get
            {
                 return _privateCliente;
            }
            set
            {
                _privateCliente = value;
            }
        }
        private string _privateCliente  = String.Empty;


        /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public ManteExtProveedTaller(sage.ew.interficies.IMante _mantePrincipal)
            : this()
        {
            this._Mante = _mantePrincipal;

            // Asociar mantenimientos de tablas relacionadas
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public ManteExtProveedTaller()
        {
            this._Tabla = "proveedores_adi";
            this._DataBase = "TALLER";
            this._Clave = "Proveedor";
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase y asigna objetos
        /// </summary>
        public ManteExtProveedTaller(FormMante toForm)
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
                this._Cliente = String.Empty;

                string whereclause = GetWhereClause();
                string sql = "Select Proveedor, Cliente " + 
                "From " + DB.SQLDatabase(this._DataBase, this._Tabla) + " " + 
                whereclause;


                if (!string.IsNullOrWhiteSpace(sql))
                {
                    DataTable proveedores_adiresult = new DataTable();
                    llOk = DB.SQLExec(sql, ref proveedores_adiresult);

                    if (llOk && proveedores_adiresult.Rows.Count > 0)
                    {
                this._Proveedor = Convert.ToString(proveedores_adiresult.Rows[0]["Proveedor"]);
                        this._Cliente = Convert.ToString(proveedores_adiresult.Rows[0]["Cliente"]);


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
                this._Cliente = String.Empty;

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
                    "Set Proveedor = " + DB.SQLString(this._Proveedor) + ", Cliente = " + DB.SQLString(this._Cliente) +  " " + 
                    whereclause;

                }
                else
                {
                    sql =  "Insert Into " + DB.SQLDatabase(this._DataBase, this._Tabla) + " " + 
                    "(Proveedor, Cliente) " + 
                    "Values (" + DB.SQLString(this._Proveedor) + ", " + DB.SQLString(this._Cliente) + ")";

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
    public class FormManteExtProveedTaller : _ExtensionFormMante
    {
        //private FormMante _oFormMante = null;
        private ManteExtProveedTaller extensionMante = null;

        /// <summary>
        /// Iniciarliza una nueva instancia de la clase
        /// </summary>
        /// <param name="_formMante"></param>
        /// <param name="toAddon"></param>
        public FormManteExtProveedTaller(FormMante _formMante, IModulo toAddon)
            : base(_formMante, toAddon)
        {
            #region Código generado por el asistente de componentes. No borrar.

            extensionMante = (ManteExtProveedTaller)_ExtensionMante;

            if (extensionMante == null)
                return;

            Visual.UserControls.TallerPROVEED extensionFormMante = new Visual.UserControls.TallerPROVEED(extensionMante);
			extensionMante.usercontrolTabManteBase = extensionFormMante;
            extensionMante._Load();

            _AgregarTabAddon(extensionFormMante);

            #endregion Código generado por el asistente de componentes. No borrar.
        }
    }
}
