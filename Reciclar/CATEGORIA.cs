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
    public partial class CATEGORIA : Form
    {
        Item_Categorias obj = new Item_Categorias();
        int id;
        public CATEGORIA()
        {
            InitializeComponent();
        }

        private void CATEGORIA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_RECICLARDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.bD_RECICLARDataSet1.Categoria);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj.registrar(textBox1.Text.ToUpper(), bD_RECICLARDataSet1);
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("REVISE LOS DATOS");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                obj.actualizar(id, textBox1.Text.ToUpper(), bD_RECICLARDataSet1);

                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("REVISE LOS DATOS, NO SE PUEDE ACTUALIZAR");

            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

         
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
