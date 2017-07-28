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
    public partial class MATERIAL : Form
    {
        Item_Categorias itemC = new Item_Categorias();

        int idCate,Id;
        string nombre;
        public MATERIAL()
        {
            InitializeComponent();
        }

        private void MATERIAL_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_RECICLARDataSet.Material' Puede moverla o quitarla según sea necesario.
            this.materialTableAdapter.Fill(this.bD_RECICLARDataSet.Material);
            // TODO: esta línea de código carga datos en la tabla 'bD_RECICLARDataSet.Buscar_Cate' Puede moverla o quitarla según sea necesario.
            this.buscar_CateTableAdapter.Fill(this.bD_RECICLARDataSet.Buscar_Cate);

        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            nombre = textBox1.Text;
            itemC.BuscarIdCate(comboBox1.Text, bD_RECICLARDataSet.Buscar_Categoria);
            if (bD_RECICLARDataSet.Buscar_Categoria.Count > 0)
            {
                idCate = int.Parse(bD_RECICLARDataSet.Buscar_Categoria.Rows[0].ItemArray[0].ToString());
            }
            itemC.addMaterial(idCate, nombre, int.Parse(comboBox2.Text), bD_RECICLARDataSet);
            textBox1.Clear();
            this.materialTableAdapter.Fill(this.bD_RECICLARDataSet.Material);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            itemC.ActualizarMateri(Id, idCate, textBox1.Text, int.Parse(comboBox2.Text), bD_RECICLARDataSet);
            textBox1.Clear();
            this.materialTableAdapter.Fill(this.bD_RECICLARDataSet.Material);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            idCate = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal obj = new Principal();
            obj.Show();
            this.Hide();
        }
    }
}
