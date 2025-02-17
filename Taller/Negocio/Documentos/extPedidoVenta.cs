using sage.ew.docsven;
using sage.ew.global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sage.addons.Taller.Negocio.Documentos
{
    class extPedidoVenta : ventasCabeceraBase
    {
        public string _ejercicio = EW_GLOBAL._GetVariable("wc_any").ToString();
        public string _empresa = EW_GLOBAL._Empresa._Codigo;

        private string bddAddon = "TALLER";

        public string _Numero
        {
            get { return ((ewDocVentaPED)_Documento)._Numero; }
        }

        public string _Letra
        {
            get { return ((ewDocVentaPED)_Documento)._Letra; }
        }
    }
}
