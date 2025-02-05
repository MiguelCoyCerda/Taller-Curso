#region Referencias WindowsForms

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

#endregion Referencias WindowsForms

#region Referencias Sage50

//Acceso a Base de Datos
//Referencia en : C:\Sage50_3\Sage50Term\Librerias\sage.ew.db.dll
using sage.ew.db;

//Acceso a variables globales
//Referencia en : C:\Sage50_3\Sage50Term\Librerias\sage.50.exe
using sage.ew.global;

//Objetos visuales (filtros y opciones)=
//Referencia en : C:\Sage50_3\Sage50Term\Librerias\sage.50.exe
using sage.ew.objetos;

//Clases utiles de listados
//Referencia en : C:\Sage50_3\Sage50Term\Librerias\sage.50.exe
using sage.ew.listados;
using sage.ew.listados.Clases;
using sage.ew.listados.Listados;
using sage.ew.functions;
using System.Windows.Forms;
using Sage.ES.S50.NuevoEjercicio.Clases;
using System.Drawing.Printing;

#endregion Referencias Sage50

/// <summary>
/// Namespace del Add-on para la clase de negocio listadoHojaCarga
/// </summary>
namespace sage.addons.Taller.Negocio.Listados
{
    /// <summary>
    /// Clase de negocio listadoHojaCarga
    /// </summary>
    public class listadoHojaCarga : sage.ew.listados.Clases.Listados
    {
        private string _empresa = EW_GLOBAL._GetVariable("wc_empresa").ToString();
        private string _ejercicio = EW_GLOBAL._GetVariable("wc_any").ToString();
        /// <summary>
        /// Definicio del nombre de report a utilizar en la impresión del listado
        /// </summary>
        public override String _ReportFile
        {
            get
            {
                return "listadohojacarga.report";
            }
        }

        public override Dictionary<string, string> _NavigateButtons
        {
            get
            {
                return new Dictionary<string, string>()
                { { "ven", "Ver Vendedor" }, { "cli", "Ver Cliente" } , { "alb", "Ver Albarán" }, { "sal", "Saludar" }};
            }
        }

        public override void _Navigate(string tcKeyNavigate, DataRow trRowList)
        {
            switch (tcKeyNavigate)
            {
                case "sal":
                    FUNCTIONS._MessageBox("Hola");
                    //FUNCTIONS._Ejecutar_Aplicacion("notepad.exe", "", "C:\\Windows\\notepad.exe");
                    break;

                case "ven":
                    string vendedor = trRowList["VENDEDOR"].ToString().Trim();
                    if (string.IsNullOrEmpty(vendedor))
                    {
                       FUNCTIONS._MessageBox("Debe seleccionar una línea con un dato de vendedor válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        _Navegar(Pantalla.Vendedor, new List<string>() { { vendedor } });
                    }                   
                    break;

                case "fac":
                    string lcNumero = trRowList["Factura"].ToString().Trim();

                    if (!string.IsNullOrEmpty(lcNumero))
                    {
                        //_Navegar(Pantalla.Pediven, new List<string>() { {EW_GLOBAL._GetVariable("wc_empresa").ToString()} , { lcNumero.Trim() }, { lcSerie.Trim() } }); //mirar siempre indice tabla para orden parametros
                        _Navegar(Pantalla.Factuven, new List<string>() { { EW_GLOBAL._GetVariable("wc_empresa").ToString() }, { lcNumero } }); //mirar siempre indice tabla para orden parametros
                    }
                    else
                    {
                        FUNCTIONS._MessageBox("Debe seleccionar una línea para navegar al documento o no existe dato a consultar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "cli":
                    string cliente = trRowList["CLIENTE"].ToString().Trim();

                    if (!string.IsNullOrEmpty(cliente))
                    {
                        _Navegar(Pantalla.Clientes, new List<string>() { { cliente } });
                    }
                    else
                    {
                        FUNCTIONS._MessageBox("Debe seleccionar una línea para navegar al documento o no existe dato a consultar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "ped":
                    string seriep = trRowList["SERIE"].ToString().Trim();
                    string pedido = trRowList["NÚMERO"].ToString().Trim();

                    if (!string.IsNullOrEmpty(pedido))
                    {
                        _Navegar(Pantalla.Pediven, new List<string>() { { _empresa }, { pedido.Trim() }, { seriep.Trim() } }); //mirar siempre indice tabla para orden parametros                    }
                    }
                    else
                    {
                        FUNCTIONS._MessageBox("Debe seleccionar una línea para navegar al documento o no existe dato a consultar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "alb":
                    string serie = trRowList["SERIE"].ToString().Trim();
                    string numero = trRowList["ALBARAN"].ToString().Trim();
                    string ejercicio = trRowList["EJEERCICIOALBARAN"].ToString().Trim();

                    if (!string.IsNullOrEmpty(serie) && !string.IsNullOrEmpty(numero) && ejercicio==_ejercicio)
                    {
                        _Navegar(Pantalla.AlbaVen, new List<string>() { { _empresa }, { numero }, { serie } });
                    }
                    else if(!string.IsNullOrEmpty(serie) && !string.IsNullOrEmpty(numero) && ejercicio != _ejercicio)
                    {
                        FUNCTIONS._MessageBox("Debe cambiar de ejercicio para poder mostrar el documento seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        FUNCTIONS._MessageBox("Debe seleccionar una línea para navegar al documento o no existe dato a consultar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }
        }

        /// <summary>
        /// Método de obtención de los datos específico para el listado
        /// </summary>
        /// <returns>Datatable con los datos</returns>
        public override DataTable _DataTable()
        {
            DataTable ldtResult = new DataTable();

            //leemosd los filtros
            string lcFiltros = "";
            //fechas, clientes y vendedores
            lcFiltros = _Filtro_Fecha(_Filtros, _Tipo_Filtro_Fecha.Fecha, "cab", "FECHA");
            lcFiltros += _Filtro_String(_Filtros, _Tipo_Filtro_String.Cliente, "cab", "CLIENTE");
            lcFiltros += _Filtro_String(_Filtros, _Tipo_Filtro_String.Vendedor, "cab", "VENDEDOR");


            string sql= $"SELECT codigo, nombre, familia FROM {DB.SQLDatabase("articulo")}";
            sql = $@"select cab.numero 'Número', cab.FECHA, cab.VENDEDOR, ven.NOMBRE 'Nombre Vendedor', veh.NOMBRE as 'Vehículo', cab.CLIENTE, cli.NOMBRE as 'Nombre cliente', cab.ALBARAN, cab.SERIE, cab.FECHAALBARAN, CAB.EJEERCICIOALBARAN
            from {DB.SQLDatabase("taller", "c_hojacarga")} cab
            left join {DB.SQLDatabase("vendedor")} ven on cab.VENDEDOR= ven.CODIGO
            left join {DB.SQLDatabase("clientes")} cli on cab.CLIENTE = cli.CODIGO
            left join {DB.SQLDatabase("taller", "vehiculo")} veh on cab.VEHICULO = veh.CODIGO
            where 
            cab.EMPRESA = {DB.SQLString(_empresa)} and cab.EJERCICIO = {DB.SQLString(_ejercicio)} {lcFiltros}
            ";

            bool ok = DB.SQLExec(sql, ref ldtResult);

            if (!ok)
            {
                FUNCTIONS._MessageBox("Sql mal formateada");
                ldtResult = new DataTable();


            }

            return ldtResult;
        }
    }
}