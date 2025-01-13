using sage.ew.docsven;
using sage.ew.formul.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sage.addons.Taller.Visual.UserControls
{
    /// <summary>
    /// Lista previa
    /// </summary>
    public class ListasPreviasHojaCarga : ListasPreviasDocsDocumentosOtros
    {
        /// <summary>
        /// Constructor vacio.
        /// </summary>
        public ListasPreviasHojaCarga(string tcClass, Type toTipoObjeto, string tcPantalla)
            : base(tcClass, toTipoObjeto, tcPantalla)
        {
            //Tipo de documento
            this._TipoDocumento = eTipoDocumento.DocumentoBase;
        }

        /// <summary>
        /// Rellena las propiedades necesarias para el browser
        /// </summary>
        public override void PopulateBrowser()
        {
            //Tipo de documento
            this._TipoDocumento = eTipoDocumento.DocumentoBase;

            // Botón browser
            btBrowDocuments = new sage.addons.Taller.Visual.UserControls.btBrowHojaCarga();

            //Parte comun
            base.PopulateBrowser(btBrowDocuments);
        }
    }

}
