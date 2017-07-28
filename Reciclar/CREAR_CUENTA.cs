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
    public partial class CREAR_CUENTA : Form
    {
        string ci,nom, pa, ma, direc;
        Usuario user = new Usuario();
        public CREAR_CUENTA()
        {
            InitializeComponent();
        }

        public void limpiar(){

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ci = textBox1.Text; nom = textBox2.Text.ToUpper(); pa = textBox3.Text.ToUpper(); ma = textBox4.Text.ToUpper();
                direc = textBox5.Text.ToUpper();
                user.addUsuario(ci, nom, pa, 0, ma, direc, bD_RECICLARDataSet1);
                limpiar();
            }
            catch
            {
                MessageBox.Show("REVISE LOS DATOS INGRESADOS");
            }
        }
    }
}
