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
    public partial class txtvehiculo : ewtxtcodlabel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public txtvehiculo()
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
            _Len = 4;
            _Expandir = false;
            _Database = "TALLER";
            _Tabla = "vehiculo";
            _Nombre = "nombre";
            _Mante = "vehiculo";

            _Browser_Clave = "codigo";
            _Browser_Database = "TALLER";
            _Browser_Campo_Predet = "nombre";
            _Browser_Campos = "codigo,nombre";
            _Browser_Condicion = "";
            _Browser_Tabla = "vehiculo";
            _Browser_Titulos_Campos = "Código,Nombre";
            _Browser_Titulo = "Listado de mantenimiento de vehículos";
        }
    }
}
