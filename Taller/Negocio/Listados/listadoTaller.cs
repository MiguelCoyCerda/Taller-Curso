#region Referencias WindowsForms

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

#endregion Referencias WindowsForms

#region Referencias Sage50

//Acceso a Base de Datos
//Referencia en : C:\Sage50\Sage50Term\Librerias\sage.ew.db.dll
using sage.ew.db;

//Acceso a variables globales
//Referencia en : C:\Sage50\Sage50Term\Librerias\sage.50.exe
using sage.ew.global;

//Objetos visuales (filtros y opciones)=
//Referencia en : C:\Sage50\Sage50Term\Librerias\sage.50.exe
using sage.ew.objetos;

//Clases utiles de listados
//Referencia en : C:\Sage50\Sage50Term\Librerias\sage.50.exe
using sage.ew.listados;
using sage.ew.listados.Clases;
using sage.ew.listados.Listados;

#endregion Referencias Sage50

/// <summary>
/// Namespace del Add-on para la clase de negocio listadoTaller
/// </summary>
namespace sage.addons.Taller.Negocio.Listados
{
    /// <summary>
    /// Clase de negocio listadoTaller
    /// </summary>
    public class listadoTaller : sage.ew.listados.Clases.Listados
    {
        /// <summary>
        /// Definicio del nombre de report a utilizar en la impresión del listado
        /// </summary>
        public override String _ReportFile
        {
            get
            {
                return "listadotaller.report";
            }
        }

        /// <summary>
        /// Método de obtención de los datos específico para el listado
        /// </summary>
        /// <returns>Datatable con los datos</returns>
        public override DataTable _DataTable()
        {
            DataTable ldtResult = new DataTable();
            string sql = $"select * from {DB.SQLDatabase("articulo")}";
            DB.SQLExec(sql, ref ldtResult);

            //git compartir a rbrios92@gmail.com 

            return ldtResult;
        }
    }
}