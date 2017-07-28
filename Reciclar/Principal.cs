using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reciclar
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aÑADIRTIPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CATEGORIA obj = new CATEGORIA();
            obj.Show();
            
        }

        private void aÑADIRMATERIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MATERIAL obj = new MATERIAL();
            obj.Show();

        }

        private void cREARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CREAR_CUENTA obj = new CREAR_CUENTA();
            obj.Show();
            this.Hide();
        }

        private void bUSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUSCAR_PERSONA obj = new BUSCAR_PERSONA();
            obj.Show();
            this.Hide();
        }

        private void eNTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DETALLE_RECICLAR obj = new DETALLE_RECICLAR();
            obj.Show();
            this.Hide();
        }

        private void bUSCARENMAPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAPA obj = new MAPA();
            obj.Show();
            this.Hide();
        }
    }
}
