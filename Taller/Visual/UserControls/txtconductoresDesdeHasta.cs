using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using sage.ew.global;
using sage.ew.txtbox.UserControls;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Filtro desde - hasta para agencias
    /// </summary>
    public partial class txtconductoresDesdeHasta : txtFiltroBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public txtconductoresDesdeHasta()
        {
            this._Init();
        }

        /// <summary>
        /// Constructor con parámetro _Editando
        /// </summary>
        /// <param name="tlEditando"></param>
        public txtconductoresDesdeHasta(bool tlEditando = false)
            : base(tlEditando)
        {
            this._Init();
        }

        /// <summary>
        /// Método común para el constructor de la clase
        /// </summary>
        public override void _Init()
        {
            base._Init();

            _VariableFiltro = "conductores";

            this._oFiltroDesde = new txtconductores();
            this._oFiltroHasta = new txtconductores();

            _Parametrizacion_Demorada();
        }
    }
}
