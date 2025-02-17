using sage.ew.db;
using sage.ew.docsven;
using sage.ew.ewbase;
using sage.ew.functions;
using sage.ew.global;
using sage.ew.interficies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sage.addons.Taller.Negocio.Documentos
{
    class ventasCabeceraBase : _ExtensionDocVentaDocumento
    {
        protected string _cEjercicio = EW_GLOBAL._GetVariable("wc_any").ToString();
        string _bddaddon = "TALLER";

        public ventasCabeceraBase()
        {
            _DataBase = "TALLER";
            _CampoEmpresa = "empresa";
            _CampoLetra = "letra";
            _CampoNumero = "numero";
            _CampoLinea = "linea";
            _Condicion = "Ejercicio=" + DB.SQLString(_cEjercicio);
            _TipoUpdate = TiposUpdate.DeleteInsert;

            DefColumnas();
        }

        protected virtual void DefColumnas()
        {
            _AddPropiedad("_Ejercicio", "Ejercicio");

            DefPropiedad ldim1 = _AddPropiedad("_Receta", "Receta");
            ldim1._ColumnaGrid = new DefColumna();
            ldim1._ColumnaGrid._Header = "Receta";
            ldim1._ColumnaGrid._NoPararEnColumna = true;
            ldim1._ColumnaGrid._Visible = true;
            ldim1._ColumnaGrid._ReadOnly = false;
            ldim1._ColumnaGrid._TipoColumna = _TiposColumnaGrid.Texto;
            ldim1._ColumnaGrid._Width = 8;
            ldim1._ColumnaGrid._PosicionColumna = 2;
            ldim1._Traspasable = false;

           
        }

        //si modificamos algo de la cabecera
        public override void _Camps_Cab_Change_After(CampsDocVentaCab teCampo, ewCampo toewCampo)
        {
            switch (teCampo)
            {
                case CampsDocVentaCab.Fecha:
                    break;
                case CampsDocVentaCab.Almacen:
                    break;
                case CampsDocVentaCab.Vendedor:
                    
                    break;
                case CampsDocVentaCab.Operario:
                    break;
                case CampsDocVentaCab.FormaPago:
                    break;
                case CampsDocVentaCab.Divisa:
                    break;
                case CampsDocVentaCab.IvaInc:
                    break;
                case CampsDocVentaCab.Factura:
                    break;
                case CampsDocVentaCab.Cambio:
                    break;
                case CampsDocVentaCab.Comms:
                    break;
                case CampsDocVentaCab.Env_cli:
                    break;
                case CampsDocVentaCab.ImpDivisa:
                    break;
                case CampsDocVentaCab.Litros:
                    break;
                case CampsDocVentaCab.Peso:
                    break;
                case CampsDocVentaCab.Obra:
                    break;
                case CampsDocVentaCab.Observacio:
                    break;
                case CampsDocVentaCab.Ruta:
                    break;
                case CampsDocVentaCab.CliFinal:
                    break;
                case CampsDocVentaCab.Importe:
                    break;
                case CampsDocVentaCab.Stock_Coef:
                    break;
                case CampsDocVentaCab.Cliente:
                    saludar();
                    break;
                case CampsDocVentaCab.TotalUnidades:
                    break;
                case CampsDocVentaCab.TotalImporteIva:
                    break;
                case CampsDocVentaCab.Exportar:
                    break;
                case CampsDocVentaCab.EntregaPedido:
                    break;
                case CampsDocVentaCab.ReccAlbaran:
                    break;
                case CampsDocVentaCab.MandatoAlbaran:
                    break;
                case CampsDocVentaCab.Facturable:
                    break;
                case CampsDocVentaCab.Tarifa:
                    break;
                case CampsDocVentaCab.TraspasadoEjercicio:
                    break;
                case CampsDocVentaCab.ClientePotencial:
                    break;
                case CampsDocVentaCab.Canal:
                    break;
                default:
                    break;
            }
        }

        private void saludar()
        {
            FUNCTIONS._MessageBox("Hola");
        }
    }
}
