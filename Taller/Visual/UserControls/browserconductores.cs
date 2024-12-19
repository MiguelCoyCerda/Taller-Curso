using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sage.ew.botones;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Browser del mantenimiento de conductores
    /// </summary>
    public class browserconductores : btBrowser
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public browserconductores()
        {
            this._Campos = "Codigo,Nombre";
            this._Campo_Predet = "Nombre";
            this._Clave = "Codigo";
            this._DataBase = "TALLER";
            this._Tabla = "conductores";
            this._Titulo = "Listado de mantenimiento de conductores";
            this._Titulos_Campos = "Código,Nombre";
        }
    }
}
