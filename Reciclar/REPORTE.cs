using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reciclar
{
    public partial class REPORTE : Form
    {
        public int ci;
        public REPORTE()
        {
            InitializeComponent();
        }

        private void REPORTE_Load(object sender, EventArgs e)
        {


            BD_RECICLARDataSet ds = new BD_RECICLARDataSet();


            String tabla = "Buscar_User";
            CrystalReport1 reporte = new CrystalReport1();
            String query = "Buscar_User " + ci;

            SqlConnection conec = new SqlConnection();
            conec.ConnectionString = "Data Source=(local);Initial Catalog=BD_RECICLAR;Integrated Security=True";
            conec.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conec);
            adapter.Fill(ds, tabla);



            reporte.SetDataSource(ds.Tables[tabla]);

            VisorReporte.ReportSource = reporte;
            VisorReporte.Refresh();
        }
    }
}
