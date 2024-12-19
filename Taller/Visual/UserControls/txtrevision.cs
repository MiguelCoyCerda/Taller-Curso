using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using sage.ew.global;
using sage.ew.txtbox.UserControls;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Definición del txtcodlabel de mantenimientos del addon
    /// </summary>
    public partial class txtrevision : ewtxtcodlabel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public txtrevision()
        {
        }

        /// <summary>
        /// Redefinición del método Cargar_Propiedades() para establecer los valores de las propiedades
        /// </summary>
        protected override void _Cargar_Propiedades()
        {
            base._Cargar_Propiedades();

            _Tactil = false;
            _Codigo = "";
            _Relleno = '0';
            _Clave = "codigo";
            _Len = 6;
            _Expandir = false;
            _Database = "TALLER";
            _Tabla = "revision";
            _Nombre = "nombre";
            _Mante = "revision";

            _Browser_Clave = "codigo";
            _Browser_Database = "TALLER";
            _Browser_Campo_Predet = "nombre";
            _Browser_Campos = "codigo,nombre";
            _Browser_Condicion = "";
            _Browser_Tabla = "revision";
            _Browser_Titulos_Campos = "Código,Nombre";
            _Browser_Titulo = "Listado de mantenimiento de revisiones";
        }
    }
}
