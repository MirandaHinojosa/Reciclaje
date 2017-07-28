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
    public partial class MAPA : Form
    {
        WEB obj = new WEB();
        string lati, longi;
        public MAPA()
        {
            InitializeComponent();
        }

        private void MAPA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_RECICLARDataSet.BuscarTodosWeb' Puede moverla o quitarla según sea necesario.
            this.buscarTodosWebTableAdapter.Fill(this.bD_RECICLARDataSet.BuscarTodosWeb);
            // TODO: esta línea de código carga datos en la tabla 'bD_RECICLARDataSet.DonacionWeb' Puede moverla o quitarla según sea necesario.
            //this.donacionWebTableAdapter.Fill(this.bD_RECICLARDataSet.DonacionWeb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obj.buscarDonaciones(int.Parse(textBox1.Text), bD_RECICLARDataSet.BuscarWeb);
                if (bD_RECICLARDataSet.BuscarWeb.Count > 0)
                {
                    lati = bD_RECICLARDataSet.BuscarWeb.Rows[0].ItemArray[0].ToString();
                    longi = bD_RECICLARDataSet.BuscarWeb.Rows[0].ItemArray[1].ToString();
                }

                label3.Text = lati;
                label4.Text = longi;
            }
            catch
            {
                MessageBox.Show("COMPRUEBE LOS DATOS");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder queryAddres = new StringBuilder();
                queryAddres.Append("https://www.google.com.bo/maps/place/17%C2%B045'40.4%22S+63%C2%B008'49.3%22W/@" + lati + "," + longi + ",17Z/");

                webBrowser1.Navigate(queryAddres.ToString());
            }
            catch
            {
                MessageBox.Show("REVISE LOS DATOS");

            }







        }
    }
}
