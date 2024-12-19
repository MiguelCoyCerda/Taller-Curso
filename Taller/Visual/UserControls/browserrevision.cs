using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sage.ew.botones;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Browser del mantenimiento de revision
    /// </summary>
    public class browserrevision : btBrowser
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public browserrevision()
        {
            this._Campos = "Codigo,Nombre";
            this._Campo_Predet = "Nombre";
            this._Clave = "Codigo";
            this._DataBase = "TALLER";
            this._Tabla = "revision";
            this._Titulo = "Listado de mantenimiento de revisiones";
            this._Titulos_Campos = "Código,Nombre";
        }
    }
}
