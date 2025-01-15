using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using sage.ew.formul.Forms;
using sage.ew.formul;
using sage.ew.functions;
using sage.ew.cliente;
using sage.ew.db;
using sage.ew.global;
using sage.ew.docventatpv;
using sage.ew.serie;
using static sage.ew.listados.Clases.Listados;
using sage.ew.listados.Clases;
using sage.ew.docscompra;
using sage.ew.interficies;


namespace sage.addons.Taller.Visual.Forms
{
    public partial class frmHojaCarga : FormBaseDocumento
    {
        private string _empresa = EW_GLOBAL._GetVariable("wc_empresa").ToString();
        private string _ejercicio = EW_GLOBAL._GetVariable("wc_any").ToString();
        /// <summary>
        /// Clase de negocio del documento
        /// </summary>
        public dynamic Documento
        {
            get
            {
                if (_oDocumento == null)
                {
                    Documento = new Negocio.Documentos.HojaCarga();
                }

                return _oDocumento;
            }
            set
            {
                _Constructor_Base(value);

                _oDocumento._FormMante = this;
                btBrowHojaCarga1._Documento = value;
                btNavegacion._Navegacion = Documento.Navegacion;
                _oDocumento._Detalle._Grid = mantegridLinies;
            }
        }
		
        /// <summary>
        /// Objeto cabecera del documento
        /// </summary>
        public ew.ewbase.ewMante _ewMante;

        /// <summary>
        /// Inicializa una nueva intancia de la clase
        /// </summary>
        public frmHojaCarga()
        {
            InitializeComponent();

			this._Pantalla = "frmHojaCarga";


            this.ewtextboxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ewtextboxNumero_KeyPress);
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
        }        

        /// <summary>
        /// Constructor base
        /// </summary>
        /// <param name="toDocumento"></param>
        protected override void _Constructor_Base(dynamic toDocumento)
        {
            _ewMante = toDocumento;

            base._Constructor_Base((Negocio.Documentos.HojaCarga)toDocumento);

            // Enlazar controles
            _Binding();
        }

        /// <summary>
        /// Enlazar controles de la cabecera
        /// </summary>
        protected override void _Binding()
        {
            if (this.DesignMode)
                return;

            base._Binding();

            if (ewtextboxNumero.DataBindings["Text"] != null)
                ewtextboxNumero.DataBindings[0].ReadValue();
            else
                ewtextboxNumero.DataBindings.Add("Text", Documento, "_Numero", true);

            if (txtFecha.DataBindings["Value"] != null)
                txtFecha.DataBindings[0].ReadValue();
            else
                txtFecha.DataBindings.Add("Value", Documento, "_Fecha", true);

            if (txtVehiculo.DataBindings["_Codigo"] != null)
                txtVehiculo.DataBindings[0].ReadValue();
            else
                txtVehiculo.DataBindings.Add("_Codigo", Documento, "_Vehiculo", true);

            if (txtCliente.DataBindings["_Codigo"] != null)
                txtCliente.DataBindings[0].ReadValue();
            else
                txtCliente.DataBindings.Add("_Codigo", Documento, "_Cliente", true);

            if (ewtextboxObservaciones.DataBindings["Text"] != null)
                ewtextboxObservaciones.DataBindings[0].ReadValue();
            else
                ewtextboxObservaciones.DataBindings.Add("Text", Documento, "_Observaciones", true);

            if (txtVendedor.DataBindings["_Codigo"] != null)
                txtVendedor.DataBindings[0].ReadValue();
            else
                txtVendedor.DataBindings.Add("_Codigo", Documento, "_Vendedor", true);

            if (ewtextboxAlbaran.DataBindings["Text"] != null)
                ewtextboxAlbaran.DataBindings[0].ReadValue();
            else
                ewtextboxAlbaran.DataBindings.Add("Text", Documento, "_Albaran", true);

            if (ewtextboxSerie.DataBindings["Text"] != null)
                ewtextboxSerie.DataBindings[0].ReadValue();
            else
                ewtextboxSerie.DataBindings.Add("Text", Documento, "_Serie", true);

            if (ewtextboxEjeercicioalbaran.DataBindings["Text"] != null)
                ewtextboxEjeercicioalbaran.DataBindings[0].ReadValue();
            else
                ewtextboxEjeercicioalbaran.DataBindings.Add("Text", Documento, "_Ejeercicioalbaran", true);

            if (ewdatetimeFechaalbaran.DataBindings["Value"] != null)
                ewdatetimeFechaalbaran.DataBindings[0].ReadValue();
            else
                ewdatetimeFechaalbaran.DataBindings.Add("Value", Documento, "_Fechaalbaran", true);



        }
		
        /// <summary>
        /// Carga el documento
        /// </summary>
        /// <param name="taParams"></param>
        /// <returns></returns>
        public override bool _Init(object[] taParams)
        {
            if (Documento == null)
            {
                return false;
            }

            // Asignar valores clave
            if (taParams.Count() > 0)
            {
                string numero = taParams[0].ToString();

                if (!string.IsNullOrWhiteSpace(numero))
                {
                    Documento._Numero = numero;
                }
            }

            return true;
        }

        /// <summary>
        /// Muestra el formulario
        /// </summary>
        public override void _Show()
        {
            if (Documento == null)
            {
                return;
            }

            base._Show();
        }

        /// <summary>
        /// Método base para crear un nuevo documento
        /// </summary>
        protected override void _Nuevo_Documento()
        {
            if (Save())
            {
                base._Nuevo_Documento();
            }
        }

        /// <summary>
        /// Bloquear controles
        /// </summary>
        protected override void _Bloquear_Controles()
        {
            bool bloquearControles = (_EstadoDocumento != EstadosDocumento.HayDocumento);

            base._Bloquear_Controles();

            mantegridLinies._ReadOnly = bloquearControles;
            ewtextboxNumero.ReadOnly = !bloquearControles;
            txtFecha.Enabled = !bloquearControles;
            txtVehiculo._ReadOnly = bloquearControles;
            txtCliente._ReadOnly = bloquearControles;
            ewtextboxObservaciones.ReadOnly = bloquearControles;
            txtVendedor._ReadOnly = bloquearControles;
            ewtextboxAlbaran.ReadOnly = bloquearControles;
            ewtextboxSerie.ReadOnly = bloquearControles;
            ewtextboxEjeercicioalbaran.ReadOnly = bloquearControles;
            ewdatetimeFechaalbaran.Enabled = !bloquearControles;

        }

        /// <summary>
        /// Método base para eliminar un documento
        /// </summary>
        protected override void _Borrar_Documento(bool llPreguntar = true)
        {
            base._Borrar_Documento(llPreguntar);

            switch (_EstadoDocumento)
            {
                case EstadosDocumento.DocumentoBloqueado:
                    break;
                case EstadosDocumento.EntrandoNuevo:
                    break;
                case EstadosDocumento.HayDocumento:
                    break;
                case EstadosDocumento.NoHayDocumento:
                    ewtextboxNumero.Focus();
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Carga del documento
        /// </summary>
        public void _Cargar_Documento()
        {
            // Comprobar si el documento se puede abandonar
            if ((_EstadoDocumento != EstadosDocumento.NoHayDocumento) && !_oDocumento._Abandonar_Documento())
            {
                return;
            }

            _EstadoDocumento = EstadosDocumento.HayDocumento;

            _Binding();

            _Bloquear_Controles();

            _Refrescar_Observaciones();
        }

        /// <summary>
        /// Volver a mostrar los datos del documento
        /// </summary>
        public void _Refresh()
        {
            _Binding();
        }

        /// <summary>
        /// Método virtual para establecer un mensaje de error en cualquier control.
        /// </summary>
        /// <param name="tcBinding"></param>
        /// <param name="tcMensaje"></param>
        public void _SetError_OnControl(string tcBinding, string tcMensaje)
        {

        }

        // Guardo el documento actual
        private bool Save()
        {
            bool llOk = true;

            if (Documento != null)
            {
                llOk = this.Documento._Save();
            }

            return llOk;
        }

        // Prapara para un nuevo documento
        private void New()
        {
            if (Documento != null)
            {
                this.Documento._New();
            }

            ewtextboxNumero.Focus();
        }

        // Captura del botón nuevo
        private void btNuevo_Click(object sender, EventArgs e)
        {
            New();
        }

        // Captura Enter para disparar la carga del documento
        private void ewtextboxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(ewtextboxNumero.Text))
                {
                    Documento._Suma_Numero();
                }
                else
                {
                    Documento._Numero = ewtextboxNumero.Text;                    
                }

                Documento._Load();
            }
        }

        // Muestra el formulario
        private void frmServeis_Shown(object sender, EventArgs e)
        {
            // Forzamos el foco al número
            ewtextboxNumero.Focus();
        }

		// Click del botón opciones
        private void btOpciones_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento al validar el cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCliente_Validated(object sender, EventArgs e)
        {
            string Codcliente = txtCliente._Codigo;
            //string nombreCliente = txtCliente._DescripcionCodigo.Trim();
            
            string sql = "SELECT * FROM "+ DB.SQLDatabase("gestion","clientes") +" WHERE codigo = " + DB.SQLString(Codcliente) + "";
            string vendedor = string.Empty;
            string observaciones = string.Empty;
            //vendedor = DB._ValorSQL(sql);
            DataTable dt = new DataTable();
            bool ok = DB.SQLExec(sql, ref dt);
            if (ok && dt.Rows.Count>0)
            {
                vendedor = dt.Rows[0]["vendedor"].ToString();
                observaciones= dt.Rows[0]["observacio"].ToString();
            }
            

            //metodo 1
            if (string.IsNullOrEmpty(vendedor))
            {
                Vendedor ovendedor = new Vendedor(vendedor);
                string nombreVendedor = ovendedor._Nombre;
                ok = ovendedor._Existe_Registro();
                if (ok)
                {
                    txtVendedor._Codigo = vendedor;
                    this.Documento._Vendedor = vendedor;
                }
                
            }

            //metodo 2
            if (!string.IsNullOrEmpty(vendedor))
            {
                Cliente ocliente = new Cliente(Codcliente);
                //ocliente._Load();
                //ocliente._Codigo = Codcliente;
                vendedor = ocliente._Vendedor;
                Vendedor ovendedor = new Vendedor(vendedor);
                ok = ovendedor._Existe_Registro();
                if (ok)
                {
                    txtVendedor._Codigo = vendedor;
                }
                observaciones = ocliente._Observaciones;

                if (!string.IsNullOrEmpty(observaciones))
                {
                    ewtextboxObservaciones.Text = observaciones;
                }
            }
            


        }

        private void btn_albaran_Click(object sender, EventArgs e)
        {
            //leemos todos los datos de este documento y vamos a crear un albarán de venta para el cliente
            string empresa = this._cEmpresa;
            string tarifaPredet= EW_GLOBAL._GetVariable("wc_tarifapret").ToString();
            string seriePredet = EW_GLOBAL._GetVariable("wc_letra").ToString();

            if (!string.IsNullOrEmpty(ewtextboxAlbaran.Text))
            {
                //mostramos
                Listados oListado = new Listados();
                oListado._Navegar(Listados.Pantalla.AlbaVen, 
                    new List<string> { { empresa }, { ewtextboxAlbaran.Text }, { ewtextboxSerie.Text } });
            }
            else
            {
                //Creamos el albarán
                string fopa = string.Empty;
                string observaciones = "Albarán generado desde la hoja de carga nº " + ewtextboxNumero.Text + " de fecha " + txtFecha.Text + " para el cliente " + txtCliente._Codigo + " - " + txtCliente._DescripcionCodigo + " con el vendedor " + txtVendedor._Codigo + " - " + txtVendedor._DescripcionCodigo + " y el vehículo " + txtVehiculo._Codigo + " - " + txtVehiculo._DescripcionCodigo +"";

                Cliente ocliente = new Cliente(txtCliente._Codigo);
                fopa = ocliente._FormaPago;

                if (string.IsNullOrEmpty(fopa))
                {
                    fopa = EW_GLOBAL._GetVariable("wc_fopa").ToString();
                }
                if (string.IsNullOrEmpty(fopa))
                {
                    fopa = "01";
                }


                string cliente = txtCliente._Codigo;
                string vendedor = txtVendedor._Codigo;
                DataTable dt_detalle = new DataTable();
                string sql = $@"SELECT articulo, unidades FROM  {DB.SQLDatabase("taller", "d_hojacarga")} 
                WHERE numero = {DB.SQLString(ewtextboxNumero.Text)} 
                and empresa = {DB.SQLString(_empresa)}
                and ejercicio = {DB.SQLString(_ejercicio)}";
                bool ok = DB.SQLExec(sql, ref dt_detalle);
                if (ok && dt_detalle.Rows.Count > 0)
                {
                    //creamos el albarán
                    ewDocVentaTPV oCabecera = new ewDocVentaTPV();
                    oCabecera._New(_empresa);
                    oCabecera._Cabecera._Cliente = cliente;
                    oCabecera._Cabecera._Vendedor = vendedor;
                    oCabecera._Cabecera._Tarifa = tarifaPredet;
                    oCabecera._Cabecera._FormaPago = fopa;
                    oCabecera._Cabecera._Observacio = observaciones;

                    //recorremos el detalle
                    for (int i = 0; i < dt_detalle.Rows.Count; i++)
                    {
                        ewDocVentaLinTPV oLinea = oCabecera._AddLinea();
                        oLinea._Articulo = dt_detalle.Rows[i]["articulo"].ToString();
                        oLinea._Unidades = Convert.ToDecimal(dt_detalle.Rows[i]["unidades"]);
                        oLinea._Save();
                    }
                    ok = oCabecera._Save();

                    if (ok)
                    {
                        FUNCTIONS._MessageBox("Albarán creado correctamente");
                        ewtextboxAlbaran.Text = oCabecera._Numero;
                        ewtextboxSerie.Text = oCabecera._Letra;
                        ewtextboxEjeercicioalbaran.Text = oCabecera._Cabecera._Ejercicio;
                        this.Documento._Albaran = oCabecera._Numero;
                        this.Documento._Serie = oCabecera._Letra;
                        this.Documento._Ejeercicioalbaran = oCabecera._Cabecera._Ejercicio;

                    }
                }
            }


            

            //si ya está creado el albarán asociado a este documento, lo mostramos

        }

        private void ewbutton1_Click(object sender, EventArgs e)
        {
            //generamos pediod de compra
            string empresa = this._cEmpresa;
            string proveedor = "40000001";

            DataTable dt_detalle = new DataTable();
            string sql = $@"SELECT articulo, unidades FROM  {DB.SQLDatabase("taller", "d_hojacarga")} 
                WHERE numero = {DB.SQLString(ewtextboxNumero.Text)} 
                and empresa = {DB.SQLString(_empresa)}
                and ejercicio = {DB.SQLString(_ejercicio)}";
            bool ok = DB.SQLExec(sql, ref dt_detalle);

            if(ok && dt_detalle.Rows.Count > 0)
            {
                //cabecera
                ewDocCompraPEDIDO oCompra = new ewDocCompraPEDIDO();
                oCompra._New(empresa);
                oCompra._Cabecera._Proveedor = proveedor;
                oCompra._Fecha = Convert.ToDateTime(ewdatetimeFechaalbaran.Text.ToString());
                oCompra._Cabecera._FormaPago= "01";
                oCompra._Cabecera._Observacio = "Pedido de compra generado desde la hoja de carga nº " + ewtextboxNumero.Text + " de fecha " + txtFecha.Text + "";
                oCompra._Cabecera._Almacen = EW_GLOBAL._Empresa._AlmacenPorDefecto;

                //detalle
                for (int i=0; i<dt_detalle.Rows.Count; i++)
                {
                    ewDocCompraLinPEDIDO olinea = oCompra._AddLinea();
                    olinea._Articulo = dt_detalle.Rows[i]["articulo"].ToString();
                    olinea._Unidades = Convert.ToDecimal(dt_detalle.Rows[i]["unidades"]);
                    olinea._Precio = 100;
                    olinea._Save();
                }
                ok = oCompra._Save();

                if (ok)
                {
                   FUNCTIONS._MessageBox("Pedido de compra creado correctamente");
                }
                else
                {
                   FUNCTIONS._MessageBox("Error al crear el pedido de compra");
                }
            }

            

        }
    }
}
