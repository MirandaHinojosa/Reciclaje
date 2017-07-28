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
    public partial class Login : Form
    {
        login obj = new login();

        int intento = 3;
        string usuario, contraseña;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.logear(textBox1.Text, textBox2.Text, bD_RECICLARDataSet1.Loguearse);
            if (bD_RECICLARDataSet1.Loguearse.Count > 0)
            {
                usuario = bD_RECICLARDataSet1.Loguearse.Rows[0].ItemArray[0].ToString();
                contraseña = bD_RECICLARDataSet1.Loguearse.Rows[0].ItemArray[1].ToString();
            }
            if(usuario == textBox1.Text & contraseña==textBox2.Text){
                Principal obj1= new Principal();
                obj1.Show();
                this.Hide();
            }
            else
            {
                intento--;
                MessageBox.Show("ERROR EN USUARIO O CONTRASEÑA POR FAVOR REVISE, TIENE "+ intento+" Intentos restantes");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CREAR_LOGIN objeto = new CREAR_LOGIN();
            objeto.Show();
        }
    }
}
