using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciclar
{
    class WEB
    {
        public void buscarDonaciones(int id, BD_RECICLARDataSet.BuscarWebDataTable ds)
        {
            BD_RECICLARDataSetTableAdapters.BuscarWebTableAdapter buscarLL = new BD_RECICLARDataSetTableAdapters.BuscarWebTableAdapter();
            buscarLL.Fill(ds, id);

        }


    }
}
