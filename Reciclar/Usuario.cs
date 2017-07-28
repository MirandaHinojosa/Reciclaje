using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciclar
{
    class Usuario
    {

        public void addUsuario(string ci, string nom, string pater, int punt, string mater,string direc, BD_RECICLARDataSet ds)
        {
            BD_RECICLARDataSetTableAdapters.QueriesTableAdapter add = new BD_RECICLARDataSetTableAdapters.QueriesTableAdapter();
            add.AddUsuario(ci, nom, pater, punt, mater,direc);
        }


        public void buscar(string ci, BD_RECICLARDataSet.Buscar_UserDataTable ds)
        {
            BD_RECICLARDataSetTableAdapters.Buscar_UserTableAdapter buscar = new BD_RECICLARDataSetTableAdapters.Buscar_UserTableAdapter();
            buscar.Fill(ds,ci);

        }

    }
}
