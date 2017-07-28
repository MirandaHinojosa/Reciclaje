using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciclar
{
    class login
    {

        public void addLogin(string user, string contra, BD_RECICLARDataSet ds)
        {
            BD_RECICLARDataSetTableAdapters.QueriesTableAdapter add = new BD_RECICLARDataSetTableAdapters.QueriesTableAdapter();
            add.AddLogin(user, contra);

        }

        public void logear(string user, string contra, BD_RECICLARDataSet.LoguearseDataTable ds)
        {
            BD_RECICLARDataSetTableAdapters.LoguearseTableAdapter buscar = new BD_RECICLARDataSetTableAdapters.LoguearseTableAdapter();
            buscar.Fill(ds, user, contra);


        }


    }
}
