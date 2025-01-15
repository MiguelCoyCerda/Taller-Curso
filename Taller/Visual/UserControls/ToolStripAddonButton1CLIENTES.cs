using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using sage.ew.botones;

namespace sage.addons.Taller.Visual.UserControls
{
    public class ToolStripAddonButton1CLIENTES : ToolStripButtonAddon
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase System.Windows.Forms.ToolStripButton.
        /// </summary>
        public ToolStripAddonButton1CLIENTES()
        {
            // Propiedades del objeto        
            this.Position = 14;
            this.Name = "Button1";
            this.Text = "Ejecuta";
            this.ToolTipText = "Ejecuta";


			// Eventos
            this.Click += new EventHandler(ToolStripAddonButton1CLIENTES_Click);
        }
        
        // Click
        private void ToolStripAddonButton1CLIENTES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It works!");
        }        
    }
}
