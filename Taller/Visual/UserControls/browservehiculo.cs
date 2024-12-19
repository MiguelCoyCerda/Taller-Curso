using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sage.ew.botones;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Browser del mantenimiento de vehiculo
    /// </summary>
    public class browservehiculo : btBrowser
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase
        /// </summary>
        public browservehiculo()
        {
            this._Campos = "Codigo,Nombre";
            this._Campo_Predet = "Nombre";
            this._Clave = "Codigo";
            this._DataBase = "TALLER";
            this._Tabla = "vehiculo";
            this._Titulo = "Listado de mantenimiento de vehículos";
            this._Titulos_Campos = "Código,Nombre";
        }
    }
}
