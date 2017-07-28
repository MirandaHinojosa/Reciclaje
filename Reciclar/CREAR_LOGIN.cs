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
    public partial class CREAR_LOGIN : Form
    {
        login obj = new login();
        public CREAR_LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj.addLogin(textBox1.Text, textBox2.Text, bD_RECICLARDataSet1);
            }
            catch
            {
                MessageBox.Show("INGRESE LOS DATOS CORRECTAMENTE");
            }

        }
    }
}
