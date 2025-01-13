using sage.ew.db;
using sage.ew.global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Browser de Documento
    /// </summary>
    public class btBrowHojaCarga : sage.ew.botones.btBrowDocumentoBase
    {
        private string empresa = EW_GLOBAL._GetVariable("wc_empresa").ToString();
        private string ejercicio= EW_GLOBAL._GetVariable("wc_any").ToString();

        /// <summary>
        /// Rellena las propiedades necesarias para el browser
        /// </summary>
        protected override void _PopulateBrowser()
        {
            base._PopulateBrowser();
            
            this._Clave = "NUMERO";
            this._DataBase = "TALLER";
            this._Tabla = "c_hojacarga";
            this._Condicion = "EMPRESA = " + DB.SQLString(empresa);
            this._Titulo = "HojaCarga";

            this._Campos = "Numero, Fecha, Vehiculo, Cliente, Observaciones, Vendedor, Albaran, Serie, Ejeercicioalbaran, Fechaalbaran";
            this._OrderBy = "NUMERO desc";
            this._Campo_Predet = "NUMERO";

            this._Titulos_Campos = "Número, Fecha, Vehículo, Cliente, Observaciones, Vendedor, Albarán, Serie Albarán, Ejercicio Albarán, Fecha Albarán";

            this._GroupBy = "";            
        }

        /// <summary>
        /// Cargar el nuevo documento
        /// </summary>
        /// <returns></returns>
        protected override bool _Cargar_Documento(bool aceptar)
        {
            aceptar = base._Cargar_Documento(aceptar);

            if (aceptar)
            {
                if (this._Codigo == this._Documento._Numero)
                {
                    return false;
                }

                this._Documento._Abandonar_Documento();
                this._Documento._Numero = this._Codigo;
            }

            return aceptar;
        }
    }
}
