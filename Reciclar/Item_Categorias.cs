using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciclar
{
    class Item_Categorias
    {

        public void registrar(string nombre, BD_RECICLARDataSet ds)
        {
            BD_RECICLARDataSetTableAdapters.QueriesTableAdapter add = new BD_RECICLARDataSetTableAdapters.QueriesTableAdapter();
            add.RegistrarTipo(nombre);

        }
        public void actualizar(int id,string nom, BD_RECICLARDataSet ds)
        {
            BD_RECICLARDataSetTableAdapters.QueriesTableAdapter update = new BD_RECICLARDataSetTableAdapters.QueriesTableAdapter();
            update.ActualizarItem(id, nom);
        }

        public void Buscar(string nom, BD_RECICLARDataSet.BuscarDataTable ds){
            BD_RECICLARDataSetTableAdapters.BuscarTableAdapter buscar= new BD_RECICLARDataSetTableAdapters.BuscarTableAdapter();
            buscar.Fill(ds, nom);

        }
        public void buscarCate(BD_RECICLARDataSet.Buscar_CateDataTable ds)
        {
            BD_RECICLARDataSetTableAdapters.Buscar_CateTableAdapter buscarC = new BD_RECICLARDataSetTableAdapters.Buscar_CateTableAdapter();
            buscarC.Fill(ds);

        }

        public void BuscarIdCate(string Categoria, BD_RECICLARDataSet.Buscar_CategoriaDataTable ds)
        {
            BD_RECICLARDataSetTableAdapters.Buscar_CategoriaTableAdapter buscarCate = new BD_RECICLARDataSetTableAdapters.Buscar_CategoriaTableAdapter();
            buscarCate.Fill(ds, Categoria);

        }

        public void addMaterial(int idtipo, string Nombre, int puntos, BD_RECICLARDataSet ds)
        {
            BD_RECICLARDataSetTableAdapters.QueriesTableAdapter addMaterial = new BD_RECICLARDataSetTableAdapters.QueriesTableAdapter();
            addMaterial.AddMaterial(idtipo, Nombre, puntos);
        }


        public void ActualizarMateri(int id, int cate, string nom, int punt, BD_RECICLARDataSet ds)
        {
            BD_RECICLARDataSetTableAdapters.QueriesTableAdapter actualizarMa = new BD_RECICLARDataSetTableAdapters.QueriesTableAdapter();
            actualizarMa.ActualizarMaterial(id, cate, nom, punt);
        }


    }
}
