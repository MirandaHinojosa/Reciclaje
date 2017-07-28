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
    public partial class DETALLE_RECICLAR : Form
    {
        Usuario obj = new Usuario();
        Donacion dona = new Donacion();




        int id, max, idMate, puntosMate, CatMate, Newtotal, sumaPuntos;
        string nom, pa, ma,ci,nomMate;
        DateTime fecha;
        public DETALLE_RECICLAR()
        {
            InitializeComponent();
        }

        private void DETALLE_RECICLAR_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_RECICLARDataSet.Materiales' Puede moverla o quitarla según sea necesario.
            this.materialesTableAdapter.Fill(this.bD_RECICLARDataSet.Materiales);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CREAR_CUENTA obj = new CREAR_CUENTA();
            obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dona.BuscarIdMaterial(comboBox1.Text, bD_RECICLARDataSet.BuscarMaterial);
                if (bD_RECICLARDataSet.BuscarMaterial.Count > 0)
                {
                    idMate = int.Parse(bD_RECICLARDataSet.BuscarMaterial.Rows[0].ItemArray[0].ToString());
                    CatMate = int.Parse(bD_RECICLARDataSet.BuscarMaterial.Rows[0].ItemArray[1].ToString());
                    nomMate = bD_RECICLARDataSet.BuscarMaterial.Rows[0].ItemArray[2].ToString();
                    puntosMate = int.Parse(bD_RECICLARDataSet.BuscarMaterial.Rows[0].ItemArray[3].ToString());
                }
                Newtotal = int.Parse(textBox2.Text) * puntosMate;
                dona.DetalleDonacion(idMate, max, Newtotal, bD_RECICLARDataSet);
                sumaPuntos = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells[2].Value));
                dona.BuscarDonacion(max, bD_RECICLARDataSet.Buscar_DetalleDona);
                label8.Text = Convert.ToString(sumaPuntos);
            }
            catch
            {
                MessageBox.Show(" REVISE LOS DATOS");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dona.ActualizarPuntos(id, sumaPuntos, bD_RECICLARDataSet);
                Principal obj = new Principal();
                obj.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("REVISE LOS DATOS");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                obj.buscar(textBox1.Text, bD_RECICLARDataSet.Buscar_User);
                if (bD_RECICLARDataSet.Buscar_User.Count > 0)
                {
                    id = int.Parse(bD_RECICLARDataSet.Buscar_User.Rows[0].ItemArray[0].ToString());
                    ci = bD_RECICLARDataSet.Buscar_User.Rows[0].ItemArray[1].ToString();
                    nom = bD_RECICLARDataSet.Buscar_User.Rows[0].ItemArray[2].ToString();
                    pa = bD_RECICLARDataSet.Buscar_User.Rows[0].ItemArray[3].ToString();
                    ma = bD_RECICLARDataSet.Buscar_User.Rows[0].ItemArray[5].ToString();
                }

                label11.Text = nom;
                label4.Text = pa; label6.Text = ma;
                fecha = DateTime.Parse(DateTime.Today.ToString());
                dona.AddDona(id, fecha, 0, bD_RECICLARDataSet);

                dona.Maximo(bD_RECICLARDataSet.BuscarId);
                if (bD_RECICLARDataSet.BuscarId.Count > 0)
                {
                    max = int.Parse(bD_RECICLARDataSet.BuscarId.Rows[0].ItemArray[0].ToString());
                }
            }
            catch
            {
                MessageBox.Show("REVISE LOS DATOS INGRESADOS");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Principal obj = new Principal();
            obj.Show();
            this.Hide();
        }
    }
}
