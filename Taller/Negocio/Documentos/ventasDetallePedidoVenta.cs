using sage.ew.ewbase;
using sage.ew.global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sage.addons.Taller.Negocio.Documentos
{
    class ventasDetallePedidoVenta : _ExtensionDocVentaDocumentoLinea
    {
        protected string _cEjercicio = EW_GLOBAL._GetVariable("wc_any").ToString();

        public string _Ejercicio
        {
            get { return _cEjercicio; }
            set { _SetValue(ref _cEjercicio, value, "_Ejercicio"); }
        }

        protected string _receta = "";
        public string _Receta
        {
            get { return _receta; }
            set
            {
                _SetValue(ref _receta, value, "_Receta");
            }
        }
    }
}
