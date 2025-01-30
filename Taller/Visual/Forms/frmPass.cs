using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sage.ew.formul.Forms;


namespace sage.addons.Taller.Visual.Forms
{
    public partial class frmPass : FormDialog //FORM("sage.addons.Taller.Visual.Forms.frmPass")
    {
        public frmPass()
        {
            InitializeComponent();
        }

        private void btDocCancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDocAceptar1_Click(object sender, EventArgs e)
        {
            string licencia = txtLicencia.Text.Trim();
            string pass = "sage.ew#" + licencia.Substring(5, 3) + "&" + licencia.Substring(2, 3);
            txtPass.Text = pass;

            //copiamos al portapapeles
            Clipboard.SetText(pass);
        }
    }
}
