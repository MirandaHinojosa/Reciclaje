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
    public partial class BUSCAR_PERSONA : Form
    {
        Usuario obj = new Usuario();
        REPORTE report = new REPORTE();
        string ci,nom, ma, pa, direc;
        int punto,id;
        public BUSCAR_PERSONA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj.buscar(textBox1.Text, bD_RECICLARDataSet1.Buscar_User);
                if (bD_RECICLARDataSet1.Buscar_User.Count > 0)
                {
                    id = int.Parse(bD_RECICLARDataSet1.Buscar_User.Rows[0].ItemArray[0].ToString());
                    ci = bD_RECICLARDataSet1.Buscar_User.Rows[0].ItemArray[1].ToString();
                    nom = bD_RECICLARDataSet1.Buscar_User.Rows[0].ItemArray[2].ToString();
                    pa = bD_RECICLARDataSet1.Buscar_User.Rows[0].ItemArray[3].ToString();
                    punto = int.Parse(bD_RECICLARDataSet1.Buscar_User.Rows[0].ItemArray[4].ToString());
                    ma = bD_RECICLARDataSet1.Buscar_User.Rows[0].ItemArray[5].ToString();
                    direc = bD_RECICLARDataSet1.Buscar_User.Rows[0].ItemArray[6].ToString();
                }
                label3.Text = ci;
                label11.Text = nom;
                label4.Text = pa;
                label6.Text = ma;
                label9.Text = direc;
                label8.Text = Convert.ToString(punto);
            }
            catch
            {
                MessageBox.Show("REVISE EL CI DE LA PERSONA");
            }
        }

        private void BUSCAR_PERSONA_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                report.ci = int.Parse(textBox1.Text);
                report.Show();
            }
            catch
            {
                MessageBox.Show("REVISE EL CARNET DE LA PERSONA");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal obj = new Principal();
            obj.Show();
            this.Hide();
        }
    }
}
