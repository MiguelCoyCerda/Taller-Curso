using sage.addons.Taller.Negocio.Documentos;
using sage.ew.global;
using sage.ew.objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sage.addons.Taller.Visual.UserControls
{
    public partial class pagePedidoVenta : AddonTabDoc
    {
        private extPedidoVenta _extPedidoVenta = null;
        public string _ejercicio = EW_GLOBAL._GetVariable("wc_any").ToString();
        public string _empresa = EW_GLOBAL._Empresa._Codigo;
        string _bddaddon = "TALLER";

        public pagePedidoVenta()
        {
            InitializeComponent();

            //propiedas de la pestaña
            this._TituloPagina = "Pestaña adicional";
            this._Principal = true;
            this._Resizable = true;
            this.Dock = DockStyle.None;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
